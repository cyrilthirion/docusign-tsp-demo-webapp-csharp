using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DocuSign.Demo.CsharpApp.Models;
using DocuSign.Demo.SignatureProvider.CA;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DocuSign.Demo.CsharpApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DocuSignTspController: Controller
    {
        private DocuSignConfiguration _dsConfig { get; }
        private readonly IHttpClientFactory _httpClientFactory;

        public DocuSignTspController(DocuSignConfiguration dsConfig, IHttpClientFactory httpClientFactory)
        {
            _dsConfig = dsConfig;
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public string Get()
        {
            return "It Works!";
        }

        [HttpGet("{code}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> StartTspFlow([FromQuery(Name = "code")] string authorizationCode)
        {
            return Ok(authorizationCode);
            var request = new HttpRequestMessage(HttpMethod.Post, "https://account.demo.docusign.net/oauth/token");
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            string authorizationHeaderValue = string.Format("{0}:{1}", _dsConfig.ClientId
                , _dsConfig.ClientSecret);
            string base64HeaderValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(authorizationHeaderValue));

            request.Headers.Authorization = new AuthenticationHeaderValue("Basic", base64HeaderValue);

            string grantTypeParam = "authorization_code";
            string grantParam = "code";
            string grant = authorizationCode;

            var content = new FormUrlEncodedContent(new[]
            {
                    new KeyValuePair<string, string>("grant_type", grantTypeParam),
                    new KeyValuePair<string, string>("redirect_uri", String.Format("https://{0}", "localhost:5001/api/tsp")),
                    new KeyValuePair<string, string>(grantParam, grant)
                    });

            //var contentString = await content.ReadAsStringAsync();
            //var stringContent = new StringContent(contentString, Encoding.UTF8, "application/json");
            request.Content = content;
            var client = _httpClientFactory.CreateClient();
            var result = await client.SendAsync(request);
            var response = result.Content.ReadAsStringAsync().Result;
            dynamic jObj = (JObject)JsonConvert.DeserializeObject(response);
            //Configuration config = new Configuration(new ApiClient(_dsConfig.AppUrl, _dsConfig.AuthorizationEndpoint));
            //return _dsConfig.AppUrl;
            //config.AddDefaultHeader("Authorization", "Bearer " + "");

            string accessToken = string.Empty;
            if (jObj.access_token == null)
            {
                return Ok("Fail");
            }
            accessToken = jObj.access_token.ToString();
            var userEndpoint = jObj.user_api.ToString();



            DocuSign.eSign.Client.Configuration dsConfiguration = new eSign.Client.Configuration();
            dsConfiguration.ApiClient = new eSign.Client.ApiClient("https://demo.docusign.net" + "/restapi", "https://account.demo.docusign.net");

            dsConfiguration.AddDefaultHeader("Authorization", "Bearer " + accessToken);

            DocuSign.eSign.Api.SignatureApi signatureApi = new eSign.Api.SignatureApi(dsConfiguration);


            UserCertificate userCertificate = new UserCertificate("Cyril Thirion", "cyril.thirion+demo@docusign.com", "FR", "DocuSign");

            var result1 = signatureApi.SignHashSessionInfo(new eSign.Model.SignSessionInfoRequest(Convert.ToBase64String(userCertificate.CertContainer.Certificate.GetEncoded())));

            if (result1.Documents[0] == null || result1.Documents[0].RemainingSignatures == "0")
            {
                return Ok("Nothing to sign");
            }

            byte[] hashBytes = System.Convert.FromBase64String(result1.Documents[0].Data);


            byte[] signedCmsData = SignatureProvider.SignatureProvider.Sign(hashBytes, userCertificate);

            //            string json;
            eSign.Model.DocumentUpdateInfo docInfo = new eSign.Model.DocumentUpdateInfo()
            {
                DocumentId = result1.Documents[0].DocumentId,
                Data = Convert.ToBase64String(signedCmsData),
                ReturnFormat = "CMS"
            };
            var result2 = signatureApi.CompleteSignHash(new eSign.Model.CompleteSignRequest() { DocumentUpdateInfos = new List<eSign.Model.DocumentUpdateInfo> { docInfo } });

            //System.Console.WriteLine(json);
            //request.Content = new StringContent(json, Encoding.UTF8, "application/json");
            ////client = _httpClientFactory.CreateClient();
            //result = await client.SendAsync(request);

            //    response = result.Content.ReadAsStringAsync().Result;

            //    dynamic completeResult = (JObject)JsonConvert.DeserializeObject(response);
            ViewBag.CompleteResult = result2;
            //    return Ok(ViewBag.CompleteResult);

            //}

            //ViewBag.Language = userInfoObj.language;
            return Redirect(result2.RedirectionUrl);
            //return Ok(ViewBag.SenderName);
        }
    }
}

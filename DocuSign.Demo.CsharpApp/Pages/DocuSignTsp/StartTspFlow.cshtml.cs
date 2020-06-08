using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using DocuSign.Demo.CsharpApp.Configurations;
using DocuSign.Demo.CsharpApp.Services;
using DocuSign.Demo.SignatureProvider.CA;
using DocuSign.Tsp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace DocuSign.Demo.CsharpApp.Pages.DocuSignTsp
{
    public class StartTspFlowModel : PageModel
    {
        private readonly DocuSignConfiguration _dsConfig;
        private readonly IHttpClientFactory _httpClientFactory;

        public SignatureOAuthUserToken SignatureOAuthUserToken { get; set; }
        public string error { get; set; }

        public StartTspFlowModel(DocuSignConfiguration dsconfig, IHttpClientFactory clientFactory)
        {
            _dsConfig = dsconfig;
            _httpClientFactory = clientFactory;
        }


        public async Task OnGetAsync(string code)
        {
            HttpRequestMessage request = DocuSignService.BuildBearerTokenFromCodeRequest(_dsConfig, code);

            var client = _httpClientFactory.CreateClient();
            var response = await client.SendAsync(request);
            var responseContent = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode < HttpStatusCode.OK && response.StatusCode >= HttpStatusCode.BadRequest)
            {
                error = response.Headers.ToString() + "\n" + responseContent;
            }

            SignatureOAuthUserToken = JsonConvert.DeserializeObject<SignatureOAuthUserToken>(responseContent);

            
            //// Initialize DocuSign ApiClient
            //DocuSign.eSign.Client.Configuration dsConfiguration = new eSign.Client.Configuration();
            //dsConfiguration.ApiClient = new eSign.Client.ApiClient(signatureOAuthTokenObj.user_api + "/restapi");
            //dsConfiguration.AddDefaultHeader("Authorization", "Bearer " + signatureOAuthTokenObj.access_token);

            //DocuSign.eSign.Api.SignatureApi signatureApi = new eSign.Api.SignatureApi(dsConfiguration);

            //// UserInfo
            //var userInfoResult = signatureApi.UserInfo();

            //UserCertificate userCertificate = new UserCertificate(userInfoResult.User.DisplayName, userInfoResult.User.Email, userInfoResult.Language.ToUpper(), "DocuSign");

            //var SignHashSessionInfoResult = signatureApi.SignHashSessionInfo(new eSign.Model.SignSessionInfoRequest(Convert.ToBase64String(userCertificate.CertContainer.Certificate.GetEncoded())));

            //if (SignHashSessionInfoResult.Documents[0] == null || SignHashSessionInfoResult.Documents[0].RemainingSignatures == "0")
            //{
            //    return Ok("Nothing to sign");
            //}

            //byte[] hashBytes = System.Convert.FromBase64String(SignHashSessionInfoResult.Documents[0].Data);
            //byte[] signedCmsData = SignatureProvider.SignatureProvider.Sign(hashBytes, userCertificate);

            //eSign.Model.DocumentUpdateInfo docInfo = new eSign.Model.DocumentUpdateInfo()
            //{
            //    DocumentId = SignHashSessionInfoResult.Documents[0].DocumentId,
            //    Data = Convert.ToBase64String(signedCmsData),
            //    ReturnFormat = "CMS"
            //};
            //var CompleteSignHashResult = signatureApi.CompleteSignHash(new eSign.Model.CompleteSignRequest() { DocumentUpdateInfos = new List<eSign.Model.DocumentUpdateInfo> { docInfo } });

            //ViewBag.CompleteResult = CompleteSignHashResult;

            //return Redirect(CompleteSignHashResult.RedirectionUrl);
        }
    }
}

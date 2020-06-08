using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using DocuSign.Demo.CsharpApp.Configurations;


namespace DocuSign.Demo.CsharpApp.Services
{
    public static class DocuSignService
    {
        public static HttpRequestMessage BuildBearerTokenFromCodeRequest(DocuSignConfiguration dsconfig, string code)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, dsconfig.IDPServerBaseUrl + "oauth/token");
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            string authorizationHeaderValue = string.Format("{0}:{1}", dsconfig.ClientId
                , dsconfig.ClientSecret);
            string base64HeaderValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(authorizationHeaderValue));

            request.Headers.Authorization = new AuthenticationHeaderValue("Basic", base64HeaderValue);

            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "authorization_code"),
                new KeyValuePair<string, string>("code", code),
                // The redirect_uri one is not really used in the TSP flow
                new KeyValuePair<string, string>("redirect_uri", String.Format("https://{0}", "localhost:5001/api/docusigntsp/starttspflow")),
            });

            request.Content = content;

            return request;
        }

    }
}

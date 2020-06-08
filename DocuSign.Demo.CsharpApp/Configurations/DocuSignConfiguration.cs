using System;
namespace DocuSign.Demo.CsharpApp.Models
{
    public class DocuSignConfiguration
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }

        public string BaseUrl { get; set; }

        #region IDP Configuration
        public string IDPServerBaseUrl { get; set; }
        public string AuthorizationEndpoint { get; set; }
        public string TokenEndpoint { get; set; }
        public string UserInformationEndpoint { get; set; }
        #endregion

        public string AppUrl { get; set; }

        public DocuSignConfiguration()
        {
        }
    }
}

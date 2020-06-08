namespace DocuSign.Demo.CsharpApp.Configurations
{
    public class DocuSignConfiguration
    {
        /// <summary>
        /// ClientID that will be create via the Developer
        /// sandbox as described here: https://developers.docusign.com/id-tsp-api/guides
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// ClientSecret will be generated when creating the ClientId
        /// </summary>
        public string ClientSecret { get; set; }

        /// <summary>
        /// IDPServerBaseUrl depends which DocuSign environment you
        /// are working with. Usually it will be
        /// https://account-d.docusign.com Demo environment
        /// https://account.docusign.com Prod environment
        /// </summary>
        public string IDPServerBaseUrl { get; set; }


        public DocuSignConfiguration()
        {
        }
    }
}

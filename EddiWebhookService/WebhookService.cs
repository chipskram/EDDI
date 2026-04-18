using EddiConfigService;
using EddiConfigService.Configurations;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using Utilities;

[assembly: InternalsVisibleTo( "Tests" )]
namespace EddiWebhookService
{
    public class WebhookService
    {
        private readonly HttpClient httpClient;

        public WebhookService()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent
                .ParseAdd( $"{Constants.EDDI_NAME}/{Constants.EDDI_VERSION}" );
            httpClient.DefaultRequestHeaders.Accept
                .Add( new MediaTypeWithQualityHeaderValue( "application/json" ) );
        }

        public void SendRequest(string url)
        {
            try
            {
                httpClient.PostAsync( url, new StringContent(""));
            }
            catch ( Exception ex )
            {
                Logging.Warn( $"Failed to send webhook request to {url}: {ex.Message}" );
            }
        }
    }
}

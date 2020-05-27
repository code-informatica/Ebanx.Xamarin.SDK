namespace Ebanx.Xamarin.SDK.Model
{
    public class EbanxEnvironment
    {
        const string PRODUCTION = "https://api.ebanx.com.br/";
        const string STAGING = "https://staging.ebanx.com.br/";

        public string IntegrationKey { get; set; }
        public string PublicIntegrationKey { get; set; }
        public string Endpoint { get; set; }

        public EbanxEnvironment(string baseUrl) => Endpoint = baseUrl;

        public static EbanxEnvironment Production(string integrationKey, string publicIntegrationKey)
        {
            return new EbanxEnvironment(PRODUCTION) { IntegrationKey = integrationKey,  PublicIntegrationKey = publicIntegrationKey };
        }

        public static EbanxEnvironment Staging(string integrationKey, string publicIntegrationKey)
        {
            return new EbanxEnvironment(STAGING) { IntegrationKey = integrationKey, PublicIntegrationKey = publicIntegrationKey };
        }
    }
}

namespace Ebanx.Xamarin.SDK.Model
{
    public class PaymentRequest
    {
        public string integration_key { get; private set; }
        public string operation { get => "request"; }
        public string mode { get => "full"; }

        public Payment payment { get; set; }

        public PaymentRequest(EbanxEnvironment env) 
        {
            integration_key = env.IntegrationKey;
        }
    }
}

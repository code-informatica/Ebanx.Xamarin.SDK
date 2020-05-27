namespace Ebanx.Xamarin.SDK.Model
{
    class QueryPayment
    {
        public string integration_key { get; private set; }
        public string hash { get; set; }
        public string merchant_payment_code { get; set; }

        public QueryPayment(string hash, string merchant_payment_code, EbanxEnvironment env)
        {
            integration_key = env.IntegrationKey;
            this.hash = hash;
            this.merchant_payment_code = merchant_payment_code;
        }
    }
}

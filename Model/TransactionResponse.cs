namespace Ebanx.Xamarin.SDK.Model
{
    public class TransactionResponse
    {
        public string status { get; set; }
        public string status_code { get; set; }
        public string status_message { get; set; }
        public PaymentResponse payment { get; set; }
    }
}

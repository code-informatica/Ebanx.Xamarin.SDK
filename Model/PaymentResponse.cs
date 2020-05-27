namespace Ebanx.Xamarin.SDK.Model
{
    public class PaymentResponse
    {
        public string hash { get; set; }
        public string pin { get; set; }
        public string country { get; set; }
        public string merchant_payment_code { get; set; }
        public string order_number { get; set; }
        public string status { get; set; }
        public string status_date { get; set; }
        public string open_date { get; set; }
        public string confirm_date { get; set; }
        public string transfer_date { get; set; }
        public float amount_br { get; set; }
        public float amount_iof { get; set; }
        public float amount_ext { get; set; }
        public float current_rate { get; set; }
        public float current_ext { get; set; }
        public string due_date { get; set; }
        public int instalments { get; set; }
        public string payment_type_code { get; set; }

        public PaymentResponseDetails details { get; set; }
    }

    public class PaymentResponseDetails 
    {
        public string billing_descriptor { get; set; }
        public PaymentResponseTransactionStatus transaction_status { get; set; }
        public bool pre_approved { get; set; }
        public bool capture_available { get; set; }
        public string redirect_url { get; set; }
        public string pay_with_balance_url { get; set; }
    }

    public class PaymentResponseTransactionStatus
    {
        public string acquirer { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public string authcode { get; set; }
    }
}

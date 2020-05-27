namespace Ebanx.Xamarin.SDK.Model
{
    public class PaymentItems
    {
        public string sku { get; set; }
        public string name { get; set; }

        public string description { get; set; }
        public decimal unit_price { get; set; }
        public int quantity { get; set; }
        public string type { get; set; }
    }
}

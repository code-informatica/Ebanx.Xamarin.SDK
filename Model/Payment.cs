namespace Ebanx.Xamarin.SDK.Model
{
    public class Payment
    {
        /// <summary>
        /// Nome do cliente
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// e-mail do cliente
        /// </summary>
        public string email { get; set; }

        public string currency_code { get => "BRL"; }

        /// <summary>
        /// Valor total da venda
        /// </summary>
        public decimal amount_total { get; set; }

        /// <summary>
        /// Token do pedido no sistema
        /// </summary>
        public string payment_code { get; set; }

        public string type_code { get => "creditcard"; }

        /// <summary>
        /// CPF\CNPJ do cliente (obrigtório)
        /// </summary>
        public string document { get; set; }

        /// <summary>
        /// IP local anti-fraude
        /// </summary>
        public string customer_ip { get; set; }

        public string zipcode { get; set; }

        public string address { get; set; }

        public string street_number { get; set; }

        public string street_complement { get; set; }

        public string city { get; set; }

        public string state { get; set; }

        public string country { get => "br"; }

        public string phone_number { get; set; }

        public string user_value_1 { get; set; }
        public string user_value_2 { get; set; }
        public string user_value_3 { get; set; }
        public string user_value_4 { get; set; }
        public string user_value_5 { get; set; }

        public string due_date { get; set; }

        /// <summary>
        /// Parcelas
        /// </summary>
        public int instalments { get; set; }

        public CreditCard creditcard { get; set; }

        public string note { get; set; }

        public PaymentItems[] items { get; set; }

        public string devide_id { get; set; }

        public string notification_url { get; set; }

        public string redirect_url { get; set; }
    }
}

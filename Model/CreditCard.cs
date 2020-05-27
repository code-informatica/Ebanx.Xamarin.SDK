namespace Ebanx.Xamarin.SDK.Model
{
    public class CreditCard
    {
        public string card_number { get; set; }
        public string card_name { get; set; }
        public string card_due_date { get; set; }
        public string card_cvv { get; set; }
        public bool auto_capture { get; set; }

        /// <summary>
        /// Utilizado quando o cartão de crédito já está cadastrado no sistema não necessitando o usuário informar novamente
        /// </summary>
        public string token { get; set; }
    }
}

using Ebanx.Xamarin.SDK.Model;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Ebanx.Xamarin.SDK
{
    public class EbanxApi
    {
        private EbanxEnvironment env { get; set; }

        public EbanxApi(EbanxEnvironment env) => this.env = env;

        /// <summary>
        /// Executes a payment request to Ebanx api
        /// </summary>
        /// <param name="payment">Payment object with card</param>
        /// <returns>Response of payment request</returns>
        public async Task<PaymentResponse> RequestDirectPayment(Payment payment)
        {
            try
            {
                var paymentRequest = new PaymentRequest(env) { payment = payment };
                var client = new HttpClient();

                var requestContent = new StringContent(JsonConvert.SerializeObject(paymentRequest), Encoding.UTF8, "application/json");
                var response = await client.PostAsync($"{env.Endpoint}ws/direct", requestContent);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var ebanxResult = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<PaymentResponse>(ebanxResult);
                }

                return null;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Request the payment info
        /// </summary>
        /// <param name="hash">The payment hash (EBANX unique identifier). Required if merchant_payment_code not provided</param>
        /// <param name="merchant_payment_code">The payment hash Merchant Payment Code (unique merchant ID). Required if hash not provided</param>
        /// <returns></returns>
        public async Task<PaymentResponse> QueryPayment(string hash, string merchant_payment_code)
        {
            try
            {
                var queryPaymentRequest = new QueryPayment(hash, merchant_payment_code, env);
                var client = new HttpClient();

                var requestContent = new StringContent(JsonConvert.SerializeObject(queryPaymentRequest), Encoding.UTF8, "application/json");
                var response = await client.PostAsync($"{env.Endpoint}ws/query", requestContent);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var ebanxResult = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<PaymentResponse>(ebanxResult);
                }

                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}

using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CieloPay.ClientApp.App.CieloApi.Model;
using Newtonsoft.Json;

namespace CieloPay.ClientApp.App.CieloApi
{
    public class CieloApiClient
    {
        public async Task<Sale> PostSaleAsync(Sale sale)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.cieloecommerce.cielo.com.br");
                client.DefaultRequestHeaders.Add("MerchantId", "EE2A058F-FF53-4B64-B0B2-A8ECE7C827D6");
                client.DefaultRequestHeaders.Add("MerchantKey", "keR1RauP3RA1TNheCiauTD0U5vsoOyJX0poDqyib");

                var json = JsonConvert.SerializeObject(sale);

                var response = await client.PostAsync("/1/sales", new StringContent(json, Encoding.UTF8, "text/json"));
                var strResponse = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<Sale>(strResponse);
                }

                return sale;
            }
        }
    }
}

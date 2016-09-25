using CieloPay.ClientApp.App.CieloApi.Model;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;

namespace CieloPay.ClientApp.App.CieloApi
{
    public class CieloApiClient
    {
        public Sale PostSaleAsync(Sale sale)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://apihomolog.cieloecommerce.cielo.com.br");
                client.DefaultRequestHeaders.Add("MerchantId", "B39CABDB-6CE1-4A1E-AD2A-A62E825ABD51");
                client.DefaultRequestHeaders.Add("MerchantKey", "CZ16Gawgyw5QmNRVmtxlPecLvRzNIHOiwkdUsT7N");

                var json = JsonConvert.SerializeObject(sale);

                var response = client.PostAsync("/1/sales", new StringContent(json, Encoding.UTF8, "text/json")).Result;
                var strResponse = response.Content.ReadAsStringAsync().Result;

                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<Sale>(strResponse);
                }

                return sale;
            }
        }

        public LioOrder PostOrder(LioOrder sale)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://api20160924093032.azurewebsites.net/api/pedido");

                var json = JsonConvert.SerializeObject(sale);

                var response = client.PostAsync("", new StringContent(json, Encoding.UTF8, "text/json")).Result;
                var strResponse = response.Content.ReadAsStringAsync().Result;

                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<LioOrder>(strResponse);
                }

                return sale;
            }
        }
    }
}

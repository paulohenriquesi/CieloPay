using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CieloPay.ClientApp.App.ViewModel;
using Newtonsoft.Json;

namespace CieloPay.ClientApp.App
{
    public class RestService
    {
        HttpClient client; 

        public RestService()
        {
            this.client = new HttpClient();
            this.client.BaseAddress = new Uri("http://api20160924093032.azurewebsites.net/api/");
        }

        public List<FoodMenuItemViewModel> RefreshFoodMenu()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://api20160924093032.azurewebsites.net/api/");

                var response = client.GetAsync("produto").Result;
                var content = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<FoodMenuItemViewModel>>(content);
            }
        }
            
		public List<MyOrdersViewModel> Orders()
		{
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri("http://api20160924093032.azurewebsites.net/api/");

				var response = client.GetAsync("pedido").Result;
				var content = response.Content.ReadAsStringAsync().Result;
				return JsonConvert.DeserializeObject<List<MyOrdersViewModel>>(content);
			}
		}

        public async Task<FoodMenuItemViewModel> Food(FoodMenuItemViewModel Id)
        {

            var uri = new Uri(string.Format("http://api20160924093032.azurewebsites.net/api/produto/" + Id, string.Empty));

            var response = await this.client.GetAsync(uri);
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<FoodMenuItemViewModel>(content);
        }
    }
}
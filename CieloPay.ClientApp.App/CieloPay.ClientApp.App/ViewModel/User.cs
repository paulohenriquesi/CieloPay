using System;
using System.Collections.Generic;
using CieloPay.ClientApp.App.CieloApi.Model;

namespace CieloPay.ClientApp.App
{
	public class User
	{
		public User()
		{

		}
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Telefone { get; set; }
		public string ImagemUrl { get; set; }
		public string OauthToken { get; set; }
		public List<Card> Cards { get; set; }
		public List<Address> Addresses { get; set; }


		//"{\"Id\":1,\"Name\":\"Tio Bill Gates\",\"Email\":\"bill@microsoft.com\",\"Telefone\":\"2133445566\",\"ImagemUrl\":\"https://pbs.twimg.com/profile_images/558109954561679360/j1f9DiJi.jpeg\",\"OauthToken\":\"token\",\"Addresses\":[{\"Id\":1,\"UserId\":1,\"Street\":\"Rua dos Bobos\",\"Number\":\"171\",\"ZipCode\":\"20080080\"},{\"Id\":2,\"UserId\":1,\"Street\":\"Rua dos Bobos\",\"Number\":\"171\",\"ZipCode\":\"20080080\"}]}"
	}
}

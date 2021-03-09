using CryptoWebApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;



namespace CryptoWebApi.API
{
    public class CoinApi
    {
      

        public string BASE_URL = "https://min-api.cryptocompare.com/data/pricemultifull";
        public Root getPrice()
        {
            Root bitcoin = null;
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new
                    System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("?fsyms=BTC,ETH&tsyms=USD,EUR&api_key=");
                response.Wait();
                if (response.IsCompletedSuccessfully)
                {

                    dynamic json = response.Result.Content.ReadAsStringAsync().Result;
                    bitcoin = JsonConvert.DeserializeObject<Root>(json);
                 
                }
            }
            catch
            {
                bitcoin = null;
            }
            return bitcoin;

        }
    
    }
}

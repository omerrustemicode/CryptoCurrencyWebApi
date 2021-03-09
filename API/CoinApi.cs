using CryptoWebApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;



namespace CryptoWebApi.API
{
    public class CoinApi
    {
        //private static string API_KEY = "506d03e95525c7d2fb2bb1cce97d4dc3";

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
                var response = client.GetAsync("?fsyms=BTC,ETH&tsyms=USD,EUR&api_key=11d644d5bfdc3206ed9cea895cfa808336938450a095e8ab42886c65621e4d79");
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

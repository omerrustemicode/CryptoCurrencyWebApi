using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CryptoWebApi.Models;
using System.Net;
using System.Web;
using CryptoWebApi.API;

namespace CryptoWebApi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Crypto","Home");
        }
     

        public IActionResult Crypto()
        {
            CoinApi bitcoinAPI = new CoinApi();
            ViewBag.bitcoin = bitcoinAPI.getPrice();
            bitcoinAPI.getPrice();
            return View();
        }

    }
}

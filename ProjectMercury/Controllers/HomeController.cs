using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Runtime.Serialization.Json;
using ProjectMercury.Helpers;

namespace ProjectMercury.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            

            return View();
        }

        private async void GetCatFact()
        {
            // assume failure
            ViewBag.RandomCatFact = "Darn, we couldn't get a cat fact for you...";

            // make a call to cat fact API to retrieve
            HttpResponseMessage response = null;
            var clientHandler = new HttpClientHandler();
            var client = new HttpClient(clientHandler);
            client.BaseAddress = new Uri("http://catfacts-api.appspot.com");
            string targetUrl = client.BaseAddress.ToString() + "/api/facts";
            try
            {
                response = await client.GetAsync(targetUrl);
                string json = await response.Content.ReadAsStringAsync();
                CatFact catFactResponse = System.Web.Helpers.Json.Decode(json);
                ViewBag.RandomCatFact = catFactResponse;
            }
            catch
            {
                // do nothing
                return;
            }

            // if we've gotten here, we failed for sure...

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
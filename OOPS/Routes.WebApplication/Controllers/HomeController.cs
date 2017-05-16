using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routes.WebApplication.Controllers
{
    [RoutePrefix("Car")]
    [Route("{action=honda}")]
    public class HomeController : Controller
    {
        [Route("black/honda")]
        public string Index()
        {
            return "honda";
        }

        [Route("black/bmw/{model}")]
        public string Employee(string model)
        {
            return "bmw: " + model;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ngLoginWeb.Controllers
{
 
    public class HomeController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            return View("NgApp");
        }
        
    }
}
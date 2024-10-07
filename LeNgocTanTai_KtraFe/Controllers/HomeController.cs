using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeNgocTanTai_KtraFe.Controllers
{
    public class HomeController : Controller
    {
   
        public ActionResult Tantai()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        
    }
}
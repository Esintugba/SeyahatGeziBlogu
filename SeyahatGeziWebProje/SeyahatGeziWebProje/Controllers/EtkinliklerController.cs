using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeyahatGeziWebProje.Models.Siniflar;
namespace SeyahatGeziWebProje.Controllers
{
    public class EtkinliklerController : Controller
    {
        // GET: Etkinlikler
        public ActionResult Otel()
        {
            return View();
        } 
        public ActionResult Restoranlar()
        {
            return View();
        }
        
    }
}
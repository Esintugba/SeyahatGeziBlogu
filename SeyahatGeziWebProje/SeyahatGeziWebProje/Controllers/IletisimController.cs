using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeyahatGeziWebProje.Models.Siniflar;

namespace SeyahatGeziWebProje.Controllers
{
    public class IletisimController : Controller
    {
        Context c=new Context();
        iletisim by = new iletisim();
        // GET: Iletisim
        public ActionResult Index()
        {
            by.Deger1 = c.iletisims.ToList();
            return View(by);
            
            
        }
        [HttpGet]
        public PartialViewResult MailGonder(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult MailYap(iletisim i)
        {
            c.iletisims.Add(i);
            c.SaveChanges();
            return PartialView();
        }
    }
}

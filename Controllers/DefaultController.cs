using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje1.Models.Sinifler1;
namespace TravelTripProje1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        GeziEntities4 db = new GeziEntities4();
        BlogYorum by = new BlogYorum();
        public ActionResult Index()
        {
            by.deger1 = db.BLOGs.ToList();
            return View(by);
        }

        public ActionResult Haqqimda()
        { return View(); }


        public PartialViewResult partial()
        {
            var deger = db.BLOGs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(deger); }
    
        public PartialViewResult partial2()
        {
            var deger = db.BLOGs.Where(a => a.ID == 2).ToList();
            return PartialView(deger); }
    
        public PartialViewResult partial3()
        { var deger = db.BLOGs.Take(10).ToList();
            return PartialView(deger);
        }
        public PartialViewResult partial4()
        { var deger = db.BLOGs.OrderByDescending(a => a.ID).Take(3).ToList();
            return PartialView(deger);
        }

        public PartialViewResult partial5()
        { var deger = db.BLOGs.Take(3).ToList();
            return PartialView(deger);
        }
    }
}
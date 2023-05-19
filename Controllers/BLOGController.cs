using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using TravelTripProje1.Models.Sinifler1;

namespace TravelTripProje1.Controllers
{
    public class BLOGController : Controller
    {
        // GET: BLOG
        GeziEntities4 db = new GeziEntities4();
        public ActionResult Index()
        {
            by.deger1 = db.BLOGs.ToList();
           // var deger = db.BLOGs.ToList();
            return View(by);
        }
        BlogYorum by = new BlogYorum();
        public ActionResult BlogDetay(int id)
        {
            by.deger1 = db.BLOGs.Where(x => x.ID == id).ToList();
            by.deger2 = db.YORUMLARs.Where(x => x.BLOGID == id).ToList();
            // var blogtap = db.BLOGs.Where(x => x.ID == id).ToList();
            return View(by);
        }
        [HttpGet]

        public PartialViewResult ReyBildir(int id)
      
        {
            ViewBag.deger = id;
            return PartialView();
        
        }

        [HttpPost]
        public PartialViewResult ReyBildir(YORUMLAR b)
        {
            db.YORUMLARs.Add(b);
            db.SaveChanges();
            return PartialView();
        }
    
    
    
    
    }

}
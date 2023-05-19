using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje1.Models.Sinifler1;
namespace TravelTripProje1.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        GeziEntities4 db = new GeziEntities4();
        [Authorize]
        public ActionResult Index()
        {
            var deger=db.BLOGs.ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        { return View(); }

        [HttpPost]
        public ActionResult YeniBlog(BLOG id)
        { db.BLOGs.Add(id);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        { var deger = db.BLOGs.Find(id);
            db.BLOGs.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
      
        public ActionResult Guncelle(int id)
        { var bl = db.BLOGs.Find(id);
            return View("Guncelle", bl);
     
        }
   
    public ActionResult BlogGuncelle(BLOG a)
        { var deger = db.BLOGs.Find(a.ID);
            deger.ACIQLAMA = a.ACIQLAMA;
            deger.TARIX = a.TARIX;
            deger.BLOGIMAGE = a.BLOGIMAGE;
            deger.BASLIG = a.BASLIG;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ReySeyfesi()
        {
            var deger = db.YORUMLARs.ToList();
            return View(deger);
        }
    
        public ActionResult ReySil (int id)
        {
            var deger = db.YORUMLARs.Find(id);
            db.YORUMLARs.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("ReySeyfesi");
        }

public ActionResult ReyGetir(int id)
        { var deger = db.YORUMLARs.Find(id);
            return View("ReyGetir",deger); }



        public ActionResult ReyGuncelle(YORUMLAR y)
        {
            var deger = db.YORUMLARs.Find(y.ID);
            deger.KULANICIADI = y.KULANICIADI;
            deger.MAIL = y.MAIL;
            deger.YORUM = y.YORUM;
            db.SaveChanges();
            return RedirectToAction("ReySeyfesi");
        }

    }
}
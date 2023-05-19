using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProje1.Models.Sinifler1;

namespace TravelTripProje1.Controllers
{
    public class GirisEleController : Controller
    {
        // GET: GirisEle
        GeziEntities4 db = new GeziEntities4();
        public ActionResult Index()
        {
            return View();
     
        }
    
    public ActionResult Login()
        { return View(); }

        [HttpPost]
    public ActionResult Login(ADMIN ad)
        {
            var bilgiler = db.ADMINs.FirstOrDefault(x => x.KULANICI == ad.KULANICI &&
            x.SIFRE == ad.SIFRE);

            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.KULANICI, false);
                Session["KULANICI"] = bilgiler.KULANICI.ToString();
                return RedirectToAction("Index", "Admin");

            }
            else
            {
                return View();
            }

        }




    
    }

}
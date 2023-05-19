using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje1.Models.Sinifler1;
namespace TravelTripProje1.Controllers
{
    public class HaqqimizdaController : Controller
    {
        // GET: Haqqimizda
        GeziEntities4 db = new GeziEntities4();
        public ActionResult Index()
        {
           var deger= db.HAQQIMIZDAs.ToList();
            return View(deger);
        }
    }
}
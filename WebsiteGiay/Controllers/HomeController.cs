using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteGiay.Models;

namespace WebsiteGiay.Controllers
{
    public class HomeController : Controller
    {
        QLGIAYEntities db = new QLGIAYEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }
        /*partial giày menu*/
        public PartialViewResult _GiayMenuPartial()
        {
            var lstLoaiGiay = db.LOAIGIAYs.ToList();
            return PartialView(lstLoaiGiay);
        }
        public PartialViewResult _NewGiayFooterPartial()
        {
            var lstHinhFooter = db.HINHSPs.Take(9).ToList();
            return PartialView(lstHinhFooter);
        }
        
        public PartialViewResult _GiayBBPartial()
        {
            var lstGiay = db.GIAYs.OrderBy(n => n.NgayCapNhat).Take(3).ToList();
            return PartialView(lstGiay);
        }
        public PartialViewResult _GiayBupBePartial()
        {
            var lstGiay = db.GIAYs.Where(n => n.MaLoai == "GBB").Take(4).ToList();
            return PartialView(lstGiay);
        }
        
    }
}
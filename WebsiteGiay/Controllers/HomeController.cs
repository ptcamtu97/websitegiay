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
            var lstHinhFooter = db.GIAYs.Take(9).ToList();
            return PartialView(lstHinhFooter);
        }
        
        public PartialViewResult _GiayBupBePartial()
        {
            var lstGiay = db.GIAYs.Where(n => n.MaLoai == "GBB").ToList();
            return PartialView(lstGiay);
        }

        public PartialViewResult _GiayTheThaoPartial()
        {
            var lstGiay = db.GIAYs.Where(n => n.MaLoai == "GTT").ToList();
            return PartialView(lstGiay);
        }
        public PartialViewResult _GiayCaoGotPartial()
        {
            var lstGiay = db.GIAYs.Where(n => n.MaLoai == "GCG").ToList();
            return PartialView(lstGiay);
        }
        public PartialViewResult _GiaySandalsPartial()
        {
            var lstGiay = db.GIAYs.Where(n => n.MaLoai == "GSD").ToList();
            return PartialView(lstGiay);
        }
        public ActionResult CTSanPham(int maGiay)
        {
            GIAY giay = db.GIAYs.SingleOrDefault(n => n.MaGiay == maGiay);
            return View(giay);
        }
        
    }
}
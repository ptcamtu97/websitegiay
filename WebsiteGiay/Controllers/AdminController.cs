using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebsiteGiay.Models;

namespace WebsiteGiay.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        QLGIAYEntities db = new QLGIAYEntities();
        [HttpGet]
        public ActionResult DangNhapAdmin()
        {

            return View();
        }
        [HttpPost]
        public ActionResult DangNhapAdmin(NhanVienModel nvien)
        {
            string sTenDN = nvien.TenDN.ToString();
            string sMatKhau = nvien.MatKhau.ToString();
            NHANVIEN nv = db.NHANVIENs.SingleOrDefault(n => n.TenDN == sTenDN && n.MatKhau == sMatKhau);
            if (nv != null)
            {
                Session["Admin"] = nv;
                return RedirectToAction("", "Admin");
            }
            ViewBag.ThongBao = "Tên đăng nhập hoặc mật khẩu sai";
            return View();
        }
    }
}
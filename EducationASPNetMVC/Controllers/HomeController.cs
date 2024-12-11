using EducationASPNetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EducationASPNetMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetByCategory(int PhanLoaiSanPhamID)
        {
            QuanLyBanQuanAoEntities _dbContext = new QuanLyBanQuanAoEntities();
            var products = _dbContext.Sanphams
                .Where(p => p.PhanLoaiSanPhamID == PhanLoaiSanPhamID).ToList();

            return PartialView("_ProductList", products); // Trả về PartialView
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
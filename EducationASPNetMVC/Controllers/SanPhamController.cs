using EducationASPNetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EducationASPNetMVC.Controllers
{
    public class SanPhamController : Controller
    {
        private QuanLyBanQuanAoEntities db = new QuanLyBanQuanAoEntities ();
        // GET: SanPham
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            // Lấy danh sách phân loại sản phẩm
            ViewBag.PhanLoaiSanPhamID = new SelectList(db.PhanLoaiSanPhams, "PhanLoaiSanPhamID", "TenPhanLoai");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Sanpham sanpham)
        {
            if (ModelState.IsValid)
            {
                db.Sanphams.Add(sanpham);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            // Nếu có lỗi, hiển thị lại danh sách phân loại
            ViewBag.PhanLoaiSanPhamID = new SelectList(db.PhanLoaiSanPhams, "PhanLoaiSanPhamID", "TenPhanLoai", sanpham.PhanLoaiSanPhamID);
            return View(sanpham);
        }
    }
}
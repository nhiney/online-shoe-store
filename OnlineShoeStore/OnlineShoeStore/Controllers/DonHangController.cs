using OnlineShoeStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoeStore.Controllers
{
    public class DonHangController : Controller
    {
        // GET: DonHang
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ChiTiet()
        {
            var model = new ChiTietDonHangViewModel
            {
                MaDonHang = "#123456",
                TenKhachHang = "Nguyễn Văn A",
                SDT = "0909123456",
                DiaChi = "123 Trần Hưng Đạo, Q.1, TP.HCM",
                PhuongThucThanhToan = "cod",
                SanPhams = new List<SanPhamDonHangViewModel>
                {
                    new SanPhamDonHangViewModel { TenSanPham = "Giày Sneaker", Gia = 1200000, SoLuong = 1 },
                    new SanPhamDonHangViewModel { TenSanPham = "Dép Lê", Gia = 250000, SoLuong = 2 }
                }
            };

            model.TongTien = 1700000;

            return View(model);
        }
        public ActionResult ThanhToan()
        {
            return View();
        }
        public ActionResult XacNhan()
        {
            return View();
        }
        public ActionResult LichSu()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShoeStore.Models;

namespace OnlineShoeStore.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ChiTiet()
        {
            return View();
        }
        public ActionResult Nam()
        {
            // Tạm thời data cứng để test
            var ds = new List<SanPham>
             {
                new SanPham { Id=1, TenSanPham="Dép Kẹp Màu Đen", HinhAnh="nam_sn2.jpg", Gia=350000, GiaGoc=350000, PhanTramGiam=0, Loai="dep-kep"},
                new SanPham { Id=2, TenSanPham="Dép Kẹp Màu Nâu", HinhAnh="nam_sn1.jpg", Gia=350000, GiaGoc=500000, PhanTramGiam=30, Loai="dep-kep"},
                new SanPham { Id=3, TenSanPham="Sneaker Màu Đen Đế Trắng", HinhAnh="nam_sn1.jpg", Gia=580000, GiaGoc=725000, PhanTramGiam=20, Loai="sneaker"},
                // ... thêm sản phẩm khác
               };

            return View(ds);
        }
        public ActionResult Nu()
        {
            // Data mẫu
            var ds = new List<SanPham>
            {
                new SanPham { Id=101, TenSanPham="Sneakers Màu Trắng", HinhAnh="nu_sn1.jpg", Gia=640000, GiaGoc=800000, PhanTramGiam=20, Loai="sneakers" },
                new SanPham { Id=102, TenSanPham="Sneakers Màu Hồng", HinhAnh="nu_sn2.jpg", Gia=750000, GiaGoc=750000, PhanTramGiam=0, Loai="sneakers" },
                new SanPham { Id=103, TenSanPham="Sandal Màu Đen", HinhAnh="nu_sd1.jpg", Gia=495000, GiaGoc=550000, PhanTramGiam=10, Loai="sandal" },
                new SanPham { Id=104, TenSanPham="Dép Lê Màu Đen", HinhAnh="nu_dl1.jpg", Gia=405000, GiaGoc=450000, PhanTramGiam=10, Loai="dep-le" },
                // ... thêm sản phẩm khác
            };

            return View();
        }
        public ActionResult TreEm()
        {
            var ds = new List<SanPham>
            {
                new SanPham { Id=201, TenSanPham="Sneakers Trẻ Em Trắng", HinhAnh="te_sn1.jpg", Gia=480000, GiaGoc=600000, PhanTramGiam=20, Loai="sneakers" },
                new SanPham { Id=202, TenSanPham="Sneakers Trẻ Em Hồng", HinhAnh="te_sn2.jpg", Gia=550000, GiaGoc=550000, PhanTramGiam=0, Loai="sneakers" },
                new SanPham { Id=203, TenSanPham="Sandal Trẻ Em Đen", HinhAnh="te_sn3.jpg", Gia=405000, GiaGoc=450000, PhanTramGiam=10, Loai="sandal" },
                new SanPham { Id=204, TenSanPham="Dép Lê Trẻ Em Vàng", HinhAnh="te_sn4.jpg", Gia=323000, GiaGoc=380000, PhanTramGiam=15, Loai="dep-le" },
                new SanPham { Id=205, TenSanPham="Dép Kẹp Trẻ Em Đen", HinhAnh="te_sn5.jpg", Gia=200000, GiaGoc=250000, PhanTramGiam=20, Loai="dep-kep" }
                // ... thêm các sản phẩm khác
            };
            return View();
        }
    }
}
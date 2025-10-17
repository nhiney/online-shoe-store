using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using OnlineShoeStore.Models;

namespace OnlineShoeStore.Controllers
{
    public class GioHangController : Controller
    {
        // Tạm lưu giỏ hàng trong Session
        private List<GioHangItem> GioHang
        {
            get
            {
                var gh = Session["GioHang"] as List<GioHangItem>;
                if (gh == null)
                {
                    gh = new List<GioHangItem>();
                    Session["GioHang"] = gh;
                }
                return gh;
            }
        }

        public ActionResult Index()
        {
            return View(GioHang);
        }

        public ActionResult Them(int id, string ten, string hinh, decimal gia)
        {
            var item = GioHang.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                GioHang.Add(new GioHangItem
                {
                    Id = id,
                    TenSanPham = ten,
                    HinhAnh = hinh,
                    Gia = gia,
                    SoLuong = 1
                });
            }
            else
            {
                item.SoLuong++;
            }

            return RedirectToAction("Index");
        }

        public ActionResult Xoa(int id)
        {
            var item = GioHang.FirstOrDefault(x => x.Id == id);
            if (item != null) GioHang.Remove(item);
            return RedirectToAction("Index");
        }

        public ActionResult CapNhat(int id, int soLuong)
        {
            var item = GioHang.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                item.SoLuong = soLuong;
            }
            return RedirectToAction("Index");
        }
        public ActionResult ThanhToan()
        {
            return View();
        }

        public ActionResult DonHang()
        {
            return View(); // sẽ hiển thị trang xác nhận đơn hàng
        }

    }
}

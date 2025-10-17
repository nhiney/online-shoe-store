using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoeStore.Controllers
{
    public class NguoiDungController : Controller
    {
        // GET: NguoiDung
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Profile()
        {
            return View();
        }
        // --- POST: /Account/DangNhap ---
        [HttpPost]
        public ActionResult DangNhap(string email, string password)
        {
            // ⚙️ Tạm thời chỉ kiểm tra đơn giản
            if (email == "admin@gmail.com" && password == "123")
            {
                ViewBag.ThongBao = "Đăng nhập thành công!";
                return RedirectToAction("Index", "Home");
            }

            ViewBag.ThongBao = "Email hoặc mật khẩu không đúng!";
            return View();
        }

        // --- POST: /Account/DangKy ---
        [HttpPost]
        public ActionResult DangKy(string hoTen, string email, string matKhau, string xacNhanMatKhau)
        {
            if (matKhau != xacNhanMatKhau)
            {
                ViewBag.ThongBao = "Mật khẩu xác nhận không trùng khớp!";
                return View();
            }

            // 🧠 Ở đây bạn có thể thêm lưu database sau này.
            ViewBag.ThongBao = "Đăng ký thành công! Vui lòng đăng nhập.";
            return RedirectToAction("DangNhap");
        }
    }
}
using System.Linq;
using System.Web.Mvc;
using WebBanGIay.Models;
using System.Data.Entity;

namespace WebBanGIay.Controllers
{
    public class ProductsController : Controller
    {
        private readonly QuanLyBanGiayEntities1 db = new QuanLyBanGiayEntities1();

        public ActionResult ChiTiet(string id)
        {
            var query = db.SANPHAM.AsQueryable();
            var sanPhamBanChay = query.OrderByDescending(s => s.SOLUONGTON).Take(5).ToList();

            // TRUYỀN DỮ LIỆU
            ViewBag.SanPhamBanChay = sanPhamBanChay;
            ViewBag.HangList = db.NHACUNGCAP.Select(n => n.TENNHACUNGCAP).Distinct().ToList();

            if (string.IsNullOrEmpty(id))
            {
                return HttpNotFound("Không tìm thấy sản phẩm!");
            }

            // Lấy sản phẩm theo mã (bao gồm Nhà Cung Cấp)
            var sanPham = db.SANPHAM.Include(s => s.NHACUNGCAP).FirstOrDefault(s => s.MASANPHAM == id);

            if (sanPham == null)
            {
                return HttpNotFound("Sản phẩm không tồn tại!");
            }

            // Lấy danh sách đánh giá (nếu có)
            var danhGiaList = db.DANHGIASANPHAM.Where(d => d.MASANPHAM == id).Include(d => d.KHACHHANG).ToList();

            // Tính điểm trung bình & tổng số đánh giá
            ViewBag.DanhGiaList = danhGiaList;
            ViewBag.AverageRating = danhGiaList.Any() ? danhGiaList.Average(d => d.DIEM) : 0;
            ViewBag.TotalReviews = danhGiaList.Count;

            return View(sanPham);
        }

        public ActionResult DanhSach()
        {
            var sanPhams = db.SANPHAM.Include(s => s.NHACUNGCAP).ToList();
            return View(sanPhams);
        }
    }
}
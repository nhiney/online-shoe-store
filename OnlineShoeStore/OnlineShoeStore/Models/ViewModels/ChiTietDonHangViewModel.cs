using System.Collections.Generic;

namespace OnlineShoeStore.Models.ViewModels
{
    public class ChiTietDonHangViewModel
    {
        public string MaDonHang { get; set; }
        public string TenKhachHang { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string PhuongThucThanhToan { get; set; }
        public List<SanPhamDonHangViewModel> SanPhams { get; set; }
        public decimal TongTien { get; set; }
    }

    public class SanPhamDonHangViewModel
    {
        public string TenSanPham { get; set; }
        public decimal Gia { get; set; }
        public int SoLuong { get; set; }
        public decimal ThanhTien => Gia * SoLuong;
    }
}

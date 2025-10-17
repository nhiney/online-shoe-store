using System.Collections.Generic;

namespace OnlineShoeStore.Models
{
    public class SanPham
    {
        public int Id { get; set; }
        public string TenSanPham { get; set; }
        public string HinhAnh { get; set; }
        public decimal Gia { get; set; }
        public decimal GiaGoc { get; set; }
        public int PhanTramGiam { get; set; }
        public string Loai { get; set; }
        public decimal GiaKhuyenMai { get; set; }
        public string MoTa { get; set; }
        public string ChatLieu { get; set; }
        public string MauSac { get; set; }
        public string XuatXu { get; set; }

        public List<int> DanhSachSize { get; set; }

    }
}

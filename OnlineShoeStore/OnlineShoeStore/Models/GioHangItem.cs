using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShoeStore.Models
{
    public class GioHangItem
    {
        public int Id { get; set; }
        public string TenSanPham { get; set; }
        public string HinhAnh { get; set; }
        public decimal Gia { get; set; }
        public int SoLuong { get; set; }
        public decimal ThanhTien => Gia * SoLuong;
    }
}
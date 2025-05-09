using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_PolyCafe.Entities
{
    public class SanPham
    {
        public string MaSanPham { get; set; } = string.Empty;
        public string TenSanPham { get; set; } = string.Empty;
        public decimal DonGia { get; set; }
        public string MaLoai { get; set; } = string.Empty;
        public string? HinhAnh { get; set; }
        public bool TrangThai { get; set; }
    }
}

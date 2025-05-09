using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_PolyCafe.Entities
{
    public class ChiTietPhieu
    {
        public int Id { get; set; }
        public string MaPhieu { get; set; } = string.Empty;
        public string MaSanPham { get; set; } = string.Empty;
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
    }
}

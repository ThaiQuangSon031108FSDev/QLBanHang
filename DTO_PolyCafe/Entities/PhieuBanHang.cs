using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_PolyCafe.Entities
{
    public class PhieuBanHang
    {
        public string MaPhieu { get; set; } = string.Empty;
        public string MaThe { get; set; } = string.Empty;
        public string MaNhanVien { get; set; } = string.Empty;
        public DateTime NgayTao { get; set; }
        public string TrangThai { get; set; } = string.Empty;
    }
}

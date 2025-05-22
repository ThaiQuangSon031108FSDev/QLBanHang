using System.Data;
using Microsoft.Data.SqlClient;
using DAL_PolyCafe.Utils;
using DTO_PolyCafe.Entities;

namespace DAL_PolyCafe.Repositories
{
    public class SanPhamRepository
    {
        public DataTable GetAll()
            => DBUtil.Query("sp_GetAllSanPham");

        public int Insert(SanPham e)
            => DBUtil.Execute("sp_InsertSanPham",
                new SqlParameter("@MaSanPham", e.MaSanPham),
                new SqlParameter("@TenSanPham", e.TenSanPham),
                new SqlParameter("@DonGia", e.DonGia),
                new SqlParameter("@MaLoai", e.MaLoai),
                new SqlParameter("@HinhAnh", (object?)e.HinhAnh ?? DBNull.Value),
                new SqlParameter("@TrangThai", e.TrangThai)
            );

        public int Update(SanPham e)
            => DBUtil.Execute("sp_UpdateSanPham",
                new SqlParameter("@MaSanPham", e.MaSanPham),
                new SqlParameter("@TenSanPham", e.TenSanPham),
                new SqlParameter("@DonGia", e.DonGia),
                new SqlParameter("@MaLoai", e.MaLoai),
                new SqlParameter("@HinhAnh", (object?)e.HinhAnh ?? DBNull.Value),
                new SqlParameter("@TrangThai", e.TrangThai)
            );

        public int Delete(string id)
            => DBUtil.Execute("sp_DeleteSanPham",
                new SqlParameter("@MaSanPham", id)
            );

        public DataTable Find(string kw)
            => DBUtil.Query("sp_FindSanPham",
                new SqlParameter("@Keyword", kw)
            );
        public SanPham? GetById(string maSp)
        {
            var dt = DBUtil.Query("sp_GetSanPhamById",
                new SqlParameter("@MaSanPham", maSp));
            if (dt.Rows.Count == 0) return null;

            var r = dt.Rows[0];
            // Dùng DataRow.Field<T>, trả về null nếu DB NULL
            var ma = r.Field<string>("MaSanPham");
            var ten = r.Field<string>("TenSanPham");
            var donGiaObj = r["DonGia"];
            var loai = r.Field<string>("MaLoai");
            var hinhAnh = r.Field<string?>("HinhAnh");    // cho phép null
            var trangThaiDb = r["TrangThai"];

            // Nếu bất kỳ trường bắt buộc nào null thì cũng trả null
            if (ma == null || ten == null || loai == null || donGiaObj == DBNull.Value)
                return null;

            return new SanPham
            {
                MaSanPham = ma,
                TenSanPham = ten,
                DonGia = Convert.ToDecimal(donGiaObj),
                MaLoai = loai,
                HinhAnh = hinhAnh,                       // có thể null
                TrangThai = Convert.ToBoolean(trangThaiDb)
            };
        }
    }
}

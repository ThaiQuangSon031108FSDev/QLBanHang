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
    }
}

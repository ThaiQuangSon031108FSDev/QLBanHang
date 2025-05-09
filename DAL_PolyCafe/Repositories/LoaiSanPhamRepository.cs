using System.Data;
using Microsoft.Data.SqlClient;
using DAL_PolyCafe.Utils;
using DTO_PolyCafe.Entities;

namespace DAL_PolyCafe.Repositories
{
    public class LoaiSanPhamRepository
    {
        public DataTable GetAll()
            => DBUtil.Query("sp_GetAllLoaiSanPham");

        public int Insert(LoaiSanPham e)
            => DBUtil.Execute("sp_InsertLoaiSanPham",
                new SqlParameter("@MaLoai", e.MaLoai),
                new SqlParameter("@TenLoai", e.TenLoai),
                new SqlParameter("@GhiChu", (object?)e.GhiChu ?? DBNull.Value)
            );

        public int Update(LoaiSanPham e)
            => DBUtil.Execute("sp_UpdateLoaiSanPham",
                new SqlParameter("@MaLoai", e.MaLoai),
                new SqlParameter("@TenLoai", e.TenLoai),
                new SqlParameter("@GhiChu", (object?)e.GhiChu ?? DBNull.Value)
            );

        public int Delete(string id)
            => DBUtil.Execute("sp_DeleteLoaiSanPham",
                new SqlParameter("@MaLoai", id)
            );

        public DataTable Find(string kw)
            => DBUtil.Query("sp_FindLoaiSanPham",
                new SqlParameter("@Keyword", kw)
            );
    }
}

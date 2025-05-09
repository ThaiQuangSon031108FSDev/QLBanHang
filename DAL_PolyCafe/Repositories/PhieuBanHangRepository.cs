using System.Data;
using Microsoft.Data.SqlClient;
using DAL_PolyCafe.Utils;
using DTO_PolyCafe.Entities;

namespace DAL_PolyCafe.Repositories
{
    public class PhieuBanHangRepository
    {
        public DataTable GetAll()
            => DBUtil.Query("sp_GetAllPhieuBanHang");

        public int Insert(PhieuBanHang e)
            => DBUtil.Execute("sp_InsertPhieuBanHang",
                new SqlParameter("@MaPhieu", e.MaPhieu),
                new SqlParameter("@MaThe", e.MaThe),
                new SqlParameter("@MaNhanVien", e.MaNhanVien),
                new SqlParameter("@NgayTao", e.NgayTao),
                new SqlParameter("@TrangThai", e.TrangThai)
            );

        public int Update(PhieuBanHang e)
            => DBUtil.Execute("sp_UpdatePhieuBanHang",
                new SqlParameter("@MaPhieu", e.MaPhieu),
                new SqlParameter("@MaThe", e.MaThe),
                new SqlParameter("@MaNhanVien", e.MaNhanVien),
                new SqlParameter("@NgayTao", e.NgayTao),
                new SqlParameter("@TrangThai", e.TrangThai)
            );

        public int Delete(string id)
            => DBUtil.Execute("sp_DeletePhieuBanHang",
                new SqlParameter("@MaPhieu", id)
            );

        public DataTable Find(string kw)
            => DBUtil.Query("sp_FindPhieuBanHang",
                new SqlParameter("@Keyword", kw)
            );
    }
}

using System.Data;
using Microsoft.Data.SqlClient;
using DAL_PolyCafe.Utils;
using DTO_PolyCafe.Entities;

namespace DAL_PolyCafe.Repositories
{
    public class ChiTietPhieuRepository
    {
        public DataTable GetAll()
            => DBUtil.Query("sp_GetAllChiTietPhieu");

        public int Insert(ChiTietPhieu e)
            => DBUtil.Execute("sp_InsertChiTietPhieu",
                new SqlParameter("@MaPhieu", e.MaPhieu),
                new SqlParameter("@MaSanPham", e.MaSanPham),
                new SqlParameter("@SoLuong", e.SoLuong),
                new SqlParameter("@DonGia", e.DonGia)
            );

        public int Update(ChiTietPhieu e)
            => DBUtil.Execute("sp_UpdateChiTietPhieu",
                new SqlParameter("@Id", e.Id),
                new SqlParameter("@MaPhieu", e.MaPhieu),
                new SqlParameter("@MaSanPham", e.MaSanPham),
                new SqlParameter("@SoLuong", e.SoLuong),
                new SqlParameter("@DonGia", e.DonGia)
            );

        public int Delete(int id)
            => DBUtil.Execute("sp_DeleteChiTietPhieu",
                new SqlParameter("@Id", id)
            );

        public DataTable FindByPhieu(string maPhieu)
            => DBUtil.Query("sp_FindChiTietByPhieu",
                new SqlParameter("@MaPhieu", maPhieu)
            );
    }
}

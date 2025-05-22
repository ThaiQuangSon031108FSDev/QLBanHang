// ChiTietPhieuRepository.cs
using System.Data;
using Microsoft.Data.SqlClient;
using DAL_PolyCafe.Utils;
using DTO_PolyCafe.Entities;

namespace DAL_PolyCafe.Repositories
{
    public class ChiTietPhieuRepository
    {
        public DataTable GetByPhieu(string maPhieu)
            => DBUtil.Query("sp_GetChiTietByPhieu",
                new SqlParameter("@MaPhieu", maPhieu));

        public int Insert(ChiTietPhieu ct)
            => DBUtil.Execute("sp_InsertChiTietPhieu",
                new SqlParameter("@MaPhieu", ct.MaPhieu),
                new SqlParameter("@MaSanPham", ct.MaSanPham),
                new SqlParameter("@SoLuong", ct.SoLuong),
                new SqlParameter("@DonGia", ct.DonGia)
            );

        public int Update(ChiTietPhieu ct)
            => DBUtil.Execute("sp_UpdateChiTietPhieu",
                new SqlParameter("@MaPhieu", ct.MaPhieu),
                new SqlParameter("@MaSanPham", ct.MaSanPham),
                new SqlParameter("@SoLuong", ct.SoLuong),
                new SqlParameter("@DonGia", ct.DonGia)
            );

        public int Delete(string maPhieu, string maSanPham)
            => DBUtil.Execute("sp_DeleteChiTietPhieu",
                new SqlParameter("@MaPhieu", maPhieu),
                new SqlParameter("@MaSanPham", maSanPham)
            );
    }
}
// File: DAL_PolyCafe/Repositories/NhanVienRepository.cs
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using DAL_PolyCafe.Utils;
using DTO_PolyCafe.Entities;

namespace DAL_PolyCafe.Repositories
{
    public class NhanVienRepository
    {
        public DataTable GetAll()
            => DBUtil.Query("sp_GetAllNhanVien");

        public int Insert(NhanVien e)
            => DBUtil.Execute("sp_InsertNhanVien",
                new SqlParameter("@MaNhanVien", e.MaNhanVien),
                new SqlParameter("@HoTen", e.HoTen),
                new SqlParameter("@Email", e.Email),
                new SqlParameter("@MatKhau", e.MatKhau),
                new SqlParameter("@VaiTro", e.VaiTro),
                new SqlParameter("@TrangThai", e.TrangThai)
            );

        public int Update(NhanVien e)
            => DBUtil.Execute("sp_UpdateNhanVien",
                new SqlParameter("@MaNhanVien", e.MaNhanVien),
                new SqlParameter("@HoTen", e.HoTen),
                new SqlParameter("@Email", e.Email),
                new SqlParameter("@MatKhau", e.MatKhau),
                new SqlParameter("@VaiTro", e.VaiTro),
                new SqlParameter("@TrangThai", e.TrangThai)
            );

        public int Delete(string id)
            => DBUtil.Execute("sp_DeleteNhanVien",
                new SqlParameter("@MaNhanVien", id)
            );

        public DataTable Find(string kw)
            => DBUtil.Query("sp_FindNhanVien",
                new SqlParameter("@Keyword", kw)
            );

        /// <summary>
        /// Trả về true nếu MaNV và mật khẩu khớp
        /// </summary>
        public bool CheckLogin(string maNV, string hashedPass)
        {
            var result = DBUtil.Scalar("sp_CheckLogin",
                new SqlParameter("@MaNhanVien", maNV),
                new SqlParameter("@MatKhau", hashedPass)
            );
            return Convert.ToInt32(result) == 1;
        }

        /// <summary>
        /// Đổi mật khẩu
        /// </summary>
        public int ChangePassword(string maNV, string newHashedPass)
            => DBUtil.Execute("sp_ChangePassword",
                new SqlParameter("@MaNhanVien", maNV),
                new SqlParameter("@MatKhau", newHashedPass)
            );
    }
}

// File: DAL_PolyCafe/Repositories/NhanVienRepository.cs
using System;
using System.Data;
using DAL_PolyCafe.Utils;
using Microsoft.Data.SqlClient;
using DTO_PolyCafe.Entities;

namespace DAL_PolyCafe.Repositories
{
    public class NhanVienRepository
    {
        private const string SP_GET_ALL = "sp_GetAllNhanVien";
        private const string SP_GET_BY_ID = "sp_GetNhanVienById";
        private const string SP_INSERT = "sp_InsertNhanVien";
        private const string SP_UPDATE = "sp_UpdateNhanVien";
        private const string SP_DELETE = "sp_DeleteNhanVien";
        private const string SP_SEARCH = "sp_SearchNhanVien";
        private const string SP_CHECK_LOGIN = "sp_CheckLogin";
        private const string SP_CHANGE_PW = "sp_ChangePassword";

        public DataTable GetAll()
        {
            return DBUtil.Query(SP_GET_ALL);
        }

        public DataTable Find(string keyword)
        {
            var p = new SqlParameter("@Keyword", SqlDbType.NVarChar, 100) { Value = keyword };
            return DBUtil.Query(SP_SEARCH, p);
        }

        public int Insert(NhanVien nv)
        {
            var ps = new[]
            {
                new SqlParameter("@MaNhanVien", nv.MaNhanVien),
                new SqlParameter("@HoTen",       nv.HoTen),
                new SqlParameter("@Email",       nv.Email),
                new SqlParameter("@MatKhau",     nv.MatKhau),
                new SqlParameter("@VaiTro",      nv.VaiTro),
                new SqlParameter("@TrangThai",   nv.TrangThai)
            };
            return DBUtil.Execute(SP_INSERT, ps);
        }

        public int Update(NhanVien nv)
        {
            var ps = new[]
            {
                new SqlParameter("@MaNhanVien", nv.MaNhanVien),
                new SqlParameter("@HoTen",       nv.HoTen),
                new SqlParameter("@Email",       nv.Email),
                new SqlParameter("@MatKhau",     nv.MatKhau),
                new SqlParameter("@VaiTro",      nv.VaiTro),
                new SqlParameter("@TrangThai",   nv.TrangThai)
            };
            return DBUtil.Execute(SP_UPDATE, ps);
        }

        public int Delete(string maNhanVien)
        {
            var p = new SqlParameter("@MaNhanVien", SqlDbType.NVarChar, 10) { Value = maNhanVien };
            return DBUtil.Execute(SP_DELETE, p);
        }

        public bool CheckLoginByEmail(string email, string passwordHash)
        {
            var p1 = new SqlParameter("@Email", SqlDbType.NVarChar, 100) { Value = email };
            var p2 = new SqlParameter("@PasswordHash", SqlDbType.NVarChar, 64) { Value = passwordHash };
            var result = DBUtil.Scalar("sp_CheckLogin", p1, p2);
            return Convert.ToInt32(result) == 1;
        }


        public int ChangePassword(string maNhanVien, string oldHash, string newHash)
        {
            var ps = new[]
            {
                new SqlParameter("@MaNhanVien",     SqlDbType.NVarChar, 10) { Value = maNhanVien },
                new SqlParameter("@OldPasswordHash", SqlDbType.NVarChar, 64) { Value = oldHash },
                new SqlParameter("@NewPasswordHash", SqlDbType.NVarChar, 64) { Value = newHash }
            };
            var result = DBUtil.Scalar(SP_CHANGE_PW, ps);
            return Convert.ToInt32(result);
        }
    }
}

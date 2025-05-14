// File: BLL_PolyCafe/Services/NhanVienService.cs
using System;
using System.Data;
using DAL_PolyCafe.Repositories;
using DTO_PolyCafe.Entities;

namespace BLL_PolyCafe.Services
{
    public class NhanVienService
    {
        private readonly NhanVienRepository _repo = new();

        /// <summary>
        /// Lấy tất cả nhân viên
        /// </summary>
        public DataTable GetAll() => _repo.GetAll();

        /// <summary>
        /// Thêm mới nhân viên
        /// </summary>
        public int Add(NhanVien nv) => _repo.Insert(nv);

        /// <summary>
        /// Cập nhật thông tin nhân viên
        /// </summary>
        public int Update(NhanVien nv) => _repo.Update(nv);

        /// <summary>
        /// Xóa nhân viên theo mã
        /// </summary>
        public int Delete(string maNV) => _repo.Delete(maNV);

        /// <summary>
        /// Tìm kiếm nhân viên theo từ khóa
        /// </summary>
        public DataTable Search(string keyword) => _repo.Find(keyword);

        /// <summary>
        /// Đăng nhập bằng Email và mật khẩu gốc (plain), sẽ băm trước khi truyền xuống DB
        /// </summary>
        /// <param name="email">Email đăng nhập</param>
        /// <param name="plainPass">Mật khẩu gốc</param>
        /// <param name="hashFunc">Hàm băm SHA256</param>
        /// <returns>true nếu đăng nhập thành công</returns>
        public bool Login(string email, string plainPass, Func<string, string> hashFunc)
        {
            // Băm mật khẩu
            var hash = hashFunc(plainPass);
            // Gọi Repository
            return _repo.CheckLoginByEmail(email, hash);
        }

        /// <summary>
        /// Đổi mật khẩu cho nhân viên
        /// </summary>
        /// <param name="maNV">Mã nhân viên</param>
        /// <param name="oldPlainPass">Mật khẩu cũ gốc</param>
        /// <param name="newPlainPass">Mật khẩu mới gốc</param>
        /// <param name="hashFunc">Hàm băm SHA256</param>
        /// <returns>true nếu đổi mật khẩu thành công</returns>
        public bool ChangePassword(string maNV, string oldPlainPass, string newPlainPass, Func<string, string> hashFunc)
        {
            // Băm mật khẩu cũ và mới
            var oldHash = hashFunc(oldPlainPass);
            var newHash = hashFunc(newPlainPass);
            // Gọi Repository (trả về 1 nếu thành công)
            return _repo.ChangePassword(maNV, oldHash, newHash) == 1;
        }
    }
}

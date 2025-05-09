// File: BLL_PolyCafe/Services/NhanVienService.cs
using System.Data;
using DAL_PolyCafe.Repositories;
using DTO_PolyCafe.Entities;

namespace BLL_PolyCafe.Services
{
    public class NhanVienService
    {
        private readonly NhanVienRepository _repo = new();

        public DataTable GetAll() => _repo.GetAll();

        public int Add(NhanVien nv) => _repo.Insert(nv);

        public int Update(NhanVien nv) => _repo.Update(nv);

        public int Delete(string maNV) => _repo.Delete(maNV);

        public DataTable Search(string keyword) => _repo.Find(keyword);

        public bool Login(string maNV, string plainPass, Func<string, string> hashFunc)
        {
            // hashFunc: hàm băm SHA256 truyền từ UI/PL
            var hash = hashFunc(plainPass);
            return _repo.CheckLogin(maNV, hash);
        }

        public int ChangePassword(string maNV, string newPlainPass, Func<string, string> hashFunc)
        {
            var hash = hashFunc(newPlainPass);
            return _repo.ChangePassword(maNV, hash);
        }
    }
}

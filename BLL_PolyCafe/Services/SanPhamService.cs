// SanPhamService.cs
using System.Data;
using DAL_PolyCafe.Repositories;
using DTO_PolyCafe.Entities;

namespace BLL_PolyCafe.Services
{
    public class SanPhamService
    {
        private readonly SanPhamRepository _repo = new();

        public DataTable GetAll() => _repo.GetAll();
        public int Add(SanPham e) => _repo.Insert(e);
        public int Update(SanPham e) => _repo.Update(e);
        public int Delete(string id) => _repo.Delete(id);
        public DataTable Search(string kw) => _repo.Find(kw);

        // BỔ SUNG phương thức GetById:
        public SanPham? GetById(string maSp)
            => _repo.GetById(maSp);
    }
}

// LoaiSanPhamService.cs
using System.Data;
using DAL_PolyCafe.Repositories;
using DTO_PolyCafe.Entities;

namespace BLL_PolyCafe.Services
{
    public class LoaiSanPhamService
    {
        private readonly LoaiSanPhamRepository _repo = new();
        public DataTable GetAll() => _repo.GetAll();
        public int Add(LoaiSanPham e) => _repo.Insert(e);
        public int Update(LoaiSanPham e) => _repo.Update(e);
        public int Delete(string id) => _repo.Delete(id);
        public DataTable Search(string kw) => _repo.Find(kw);
    }
}

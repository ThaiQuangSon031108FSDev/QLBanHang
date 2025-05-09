// ChiTietPhieuService.cs
using System.Data;
using DAL_PolyCafe.Repositories;
using DTO_PolyCafe.Entities;

namespace BLL_PolyCafe.Services
{
    public class ChiTietPhieuService
    {
        private readonly ChiTietPhieuRepository _repo = new();
        public DataTable GetAll() => _repo.GetAll();
        public int Add(ChiTietPhieu e) => _repo.Insert(e);
        public int Update(ChiTietPhieu e) => _repo.Update(e);
        public int Delete(int id) => _repo.Delete(id);
        public DataTable GetByPhieu(string map) => _repo.FindByPhieu(map);
    }
}

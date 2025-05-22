using System.Data;
using DAL_PolyCafe.Repositories;
using DTO_PolyCafe.Entities;

namespace BLL_PolyCafe.Services
{
    public class ChiTietPhieuService
    {
        private readonly ChiTietPhieuRepository _repo = new();
        public DataTable GetByPhieu(string maPhieu) => _repo.GetByPhieu(maPhieu);
        public int Add(ChiTietPhieu ct) => _repo.Insert(ct);
        public int Update(ChiTietPhieu ct) => _repo.Update(ct);
        public int Delete(string maPhieu, string maSanPham) => _repo.Delete(maPhieu, maSanPham);
    }
}
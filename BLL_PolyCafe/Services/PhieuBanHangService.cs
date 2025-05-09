// PhieuBanHangService.cs
using System.Data;
using DAL_PolyCafe.Repositories;
using DTO_PolyCafe.Entities;

namespace BLL_PolyCafe.Services
{
    public class PhieuBanHangService
    {
        private readonly PhieuBanHangRepository _repo = new();
        public DataTable GetAll() => _repo.GetAll();
        public int Add(PhieuBanHang e) => _repo.Insert(e);
        public int Update(PhieuBanHang e) => _repo.Update(e);
        public int Delete(string id) => _repo.Delete(id);
        public DataTable Search(string kw) => _repo.Find(kw);
    }
}

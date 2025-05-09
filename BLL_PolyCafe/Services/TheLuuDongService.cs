// TheLuuDongService.cs
using System.Data;
using DAL_PolyCafe.Repositories;
using DTO_PolyCafe.Entities;

namespace BLL_PolyCafe.Services
{
    public class TheLuuDongService
    {
        private readonly TheLuuDongRepository _repo = new();
        public DataTable GetAll() => _repo.GetAll();
        public int Add(TheLuuDong e) => _repo.Insert(e);
        public int Update(TheLuuDong e) => _repo.Update(e);
        public int Delete(string id) => _repo.Delete(id);
        public DataTable Search(string kw) => _repo.Find(kw);
    }
}

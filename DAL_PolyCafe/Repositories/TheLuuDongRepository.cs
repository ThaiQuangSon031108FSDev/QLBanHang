using System.Data;
using Microsoft.Data.SqlClient;
using DAL_PolyCafe.Utils;
using DTO_PolyCafe.Entities;

namespace DAL_PolyCafe.Repositories
{
    public class TheLuuDongRepository
    {
        public DataTable GetAll()
            => DBUtil.Query("sp_GetAllTheLuuDong");

        public TheLuuDong? GetById(string maThe)
        {
            var dt = DBUtil.Query("sp_GetTheLuuDongById",
                new SqlParameter("@MaThe", maThe));
            if (dt.Rows.Count == 0) return null;
            var r = dt.Rows[0];
            return new TheLuuDong
            {
                MaThe = r.Field<string>("MaThe")!,
                ChuSoHuu = r.Field<string>("ChuSoHuu")!,
                TrangThai = r.Field<bool>("TrangThai")!
            };
        }

        public int Insert(TheLuuDong e)
            => DBUtil.Execute("sp_InsertTheLuuDong",
                new SqlParameter("@MaThe", e.MaThe),
                new SqlParameter("@ChuSoHuu", e.ChuSoHuu),
                new SqlParameter("@TrangThai", e.TrangThai)
            );

        public int Update(TheLuuDong e)
            => DBUtil.Execute("sp_UpdateTheLuuDong",
                new SqlParameter("@MaThe", e.MaThe),
                new SqlParameter("@ChuSoHuu", e.ChuSoHuu),
                new SqlParameter("@TrangThai", e.TrangThai)
            );

        public int Delete(string maThe)
            => DBUtil.Execute("sp_DeleteTheLuuDong",
                new SqlParameter("@MaThe", maThe)
            );

        public DataTable Find(string kw)
            => DBUtil.Query("sp_FindTheLuuDong",
                new SqlParameter("@Keyword", kw)
            );
    }
}

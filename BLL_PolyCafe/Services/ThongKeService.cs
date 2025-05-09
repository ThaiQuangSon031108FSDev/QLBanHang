// ThongKeService.cs
using System.Data;
using DAL_PolyCafe.Utils;
using Microsoft.Data.SqlClient;

namespace BLL_PolyCafe.Services
{
    public class ThongKeService
    {
        public DataTable ThongKeNhapTheoNV()
            => DBUtil.Query("sp_ThongKeNhapTheoNV");

        public DataTable ThongKeTonKho()
            => DBUtil.Query("sp_ThongKeTonKho");
    }
}

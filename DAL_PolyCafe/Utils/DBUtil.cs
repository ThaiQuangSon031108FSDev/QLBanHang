using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace DAL_PolyCafe.Utils
{
    public static class DBUtil
    {
        private static readonly string _conn =
            ConfigurationManager.ConnectionStrings["QLBanHangDemo"].ConnectionString;

        public static SqlCommand GetCmd(string sp, params SqlParameter[] ps)
        {
            var c = new SqlConnection(_conn);
            var cmd = new SqlCommand(sp, c)
            {
                CommandType = CommandType.StoredProcedure
            };
            if (ps != null) cmd.Parameters.AddRange(ps);
            return cmd;
        }

        public static DataTable Query(string sp, params SqlParameter[] ps)
        {
            using var cmd = GetCmd(sp, ps);
            using var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static int Execute(string sp, params SqlParameter[] ps)
        {
            using var cmd = GetCmd(sp, ps);
            cmd.Connection.Open();
            return cmd.ExecuteNonQuery();
        }

        public static object? Scalar(string sp, params SqlParameter[] ps)
        {
            using var cmd = GetCmd(sp, ps);
            cmd.Connection.Open();
            return cmd.ExecuteScalar();
        }
    }
}

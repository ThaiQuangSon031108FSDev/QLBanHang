using System;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace DAL_PolyCafe.Utils
{
    public static class DBUtil
    {
        // Chỉ lưu chuỗi kết nối, không khởi tạo Connection ở đây
        private static readonly string _connString;

        // Static constructor: chạy một lần duy nhất khi lần đầu class được truy cập
        static DBUtil()
        {
            // Lấy connection string từ App.config/Web.config
            var settings = ConfigurationManager.ConnectionStrings["QLBanHangDemo"];
            if (settings == null)
                throw new InvalidOperationException(
                    "Chuỗi kết nối 'QLBanHangDemo' không tìm thấy trong configuration.");

            _connString = settings.ConnectionString;

            // Chỉ dùng để debug: liệt kê tất cả tên connection strings
            foreach (ConnectionStringSettings cs in ConfigurationManager.ConnectionStrings)
            {
                Console.WriteLine($"Connection string name: {cs.Name}");
            }
        }

        // Trả về một SqlCommand đã gán StoredProcedure và parameters
        public static SqlCommand GetCmd(string sp, params SqlParameter[] ps)
        {
            var conn = new SqlConnection(_connString);
            var cmd = new SqlCommand(sp, conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            if (ps != null && ps.Length > 0)
                cmd.Parameters.AddRange(ps);
            return cmd;
        }

        // Thực thi query trả về DataTable
        public static DataTable Query(string sp, params SqlParameter[] ps)
        {
            using var cmd = GetCmd(sp, ps);
            using var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // Thực thi non-query (INSERT/UPDATE/DELETE)
        public static int Execute(string sp, params SqlParameter[] ps)
        {
            using var cmd = GetCmd(sp, ps);
            cmd.Connection.Open();
            return cmd.ExecuteNonQuery();
        }

        // Thực thi scalar (ví dụ COUNT, SUM)
        public static object? Scalar(string sp, params SqlParameter[] ps)
        {
            using var cmd = GetCmd(sp, ps);
            cmd.Connection.Open();
            return cmd.ExecuteScalar();
        }
    }
}



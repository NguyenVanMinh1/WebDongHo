using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhaCungCap 
    {

        string stringConnect = @"Server=ADMIN-PC\SQLEXPRESS;Database=Project_Winform;integrated security=true";
        public DataTable GetNhaCungCap()
        {
            SqlConnection conn = new SqlConnection(stringConnect);
            DataTable table = new DataTable(); // trả ra dữ liệu bảng 
            try
            {
                conn.Open(); // mở chuỗi kết nối , truy vấn
                string query = "SELECT * FROM dbo.NHA_CUNG_CAP";
                SqlDataAdapter data = new SqlDataAdapter(query, conn);
                data.Fill(table);
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
            return table;
        }
    }
}

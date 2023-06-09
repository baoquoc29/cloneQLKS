using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace Hotel_Management_System_Winforrm
{
    class QuanLyTaiKhoan
    {
        SqlCommand sqlCommand;
        SqlDataAdapter adapter; 
        // dung de truy van cac cau lenh insert update delete v.v
        SqlDataReader reader; // doc trong database
        public List<TaiKhoan> TaiKhoan(string query)
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open(); 
                sqlCommand = new SqlCommand(query, sqlConnection);  
                reader = sqlCommand.ExecuteReader(); // tien hanh doc
                while(reader.Read()) // read doc tung dong
                {
                    list.Add(new TaiKhoan(reader.GetString(0),reader.GetString(1)));    
                }

                sqlConnection.Close();
            }

                return list;
        }   
       public DataTable getNhanVien()
        {
            DataTable dt = new DataTable();
            string query = "select * from DangNhap";
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
               
                adapter = new SqlDataAdapter(query, sqlConnection);
                adapter.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }
        public bool insert(TaiKhoan tk)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "insert into DangNhap values (@taikhoan,@matkhau,@Ten,@ngaysinh,@gioitinh,@sdt)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@taikhoan", tk.Tentaikhoan);
                sqlCommand.Parameters.AddWithValue("@matkhau", tk.Matkhau);
                sqlCommand.Parameters.AddWithValue("@Ten", tk.Tennv);
                sqlCommand.Parameters.AddWithValue("@gioitinh", tk.Gioitinh);
                sqlCommand.Parameters.AddWithValue("@sdt", tk.Sdt);
                sqlCommand.Parameters.AddWithValue("@ngaysinh", tk.Ngaysinh.ToShortDateString());
                sqlCommand.ExecuteNonQuery();   

            }
            catch
            {

            }
            finally
            {
                sqlConnection.Close();  
            }
            return true;
        }
    }
}

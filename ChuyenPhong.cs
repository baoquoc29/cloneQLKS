using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Hotel_Management_System_Winforrm
{
    class ChuyenPhong
    {
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;

        public DataTable danhSachPhongTrong()
        {
            string query = "select * from phong where trangthai = 'Trong'";
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public DataTable timTheoLoaiPhong(string loaiphong)
        {
            string query = "select * from phong where loaiphong = N'" + loaiphong + "'";
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public bool capNhapPhongCu(string tenphong)
        {
            string query = "update phong set trangthai = 'Trong' where phong = @tenphong";

            SqlConnection sqlConnection = null;

            try
            {
                sqlConnection = Connection.getConnection();
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@tenphong", tenphong);
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

        public bool capNhapPhongMoi(string tenphong)
        {
            string query = "update phong set trangthai = 'Co nguoi o' where phong = @tenphong";

            SqlConnection sqlConnection = null;

            try
            {
                sqlConnection = Connection.getConnection();
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@tenphong", tenphong);
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

        public bool xoaPhongCu(string tenphong)
        {
            string query = "delete from thuephong where phong = @tenphong";

            SqlConnection sqlConnection = null;

            try
            {
                sqlConnection = Connection.getConnection();
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@tenphong", tenphong);
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

        public bool chuyenSangPhongMoi(ThuePhong thuePhong, string tenphong, string loaiphong)
        {
            string query = "insert into thuephong values(@phong, @loaiphong, @tenkhachhang, @ngaysinh, @gioitinh, " +
                "@sodienthoai, @cmnd, @songuoio, @quoctich, @ngayden, @ngaydi, @tienphaitra)";

            SqlConnection sqlConnection = null;
            
            try
            {
                sqlConnection = Connection.getConnection();
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@phong", tenphong);
                sqlCommand.Parameters.AddWithValue("@loaiphong", loaiphong);
                sqlCommand.Parameters.AddWithValue("@tenkhachhang", thuePhong.Tenkhachhang);
                sqlCommand.Parameters.AddWithValue("@ngaysinh", thuePhong.Ngaysinh);
                sqlCommand.Parameters.AddWithValue("@gioitinh", thuePhong.Gioitinh);
                sqlCommand.Parameters.AddWithValue("@sodienthoai", thuePhong.Sodienthoai);
                sqlCommand.Parameters.AddWithValue("@cmnd", thuePhong.Cmnd);
                sqlCommand.Parameters.AddWithValue("@songuoio", thuePhong.Songuoio);
                sqlCommand.Parameters.AddWithValue("@quoctich", thuePhong.Quoctich);
                sqlCommand.Parameters.AddWithValue("@ngayden", thuePhong.Ngayden);
                sqlCommand.Parameters.AddWithValue("@ngaydi", thuePhong.Ngaydi);
                sqlCommand.Parameters.AddWithValue("@tienphaitra", thuePhong.Tienphaitra);
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

        public bool thongTinKhachThuePhong(ThuePhong thuePhong, string tenphong)
        {
            string query = "SELECT TOP 1 * FROM thuephong where phong = @tenphong";
            SqlConnection sqlConnection = null;
            SqlDataReader reader = null;
            try
            {
                sqlConnection = Connection.getConnection();
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@tenphong", tenphong);
                reader = sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        thuePhong.Tenphong = reader["phong"].ToString();
                        thuePhong.Loaiphong = reader["loaiphong"].ToString();
                        thuePhong.Tenkhachhang = reader["tenkhachhang"].ToString();
                        thuePhong.Ngaysinh = Convert.ToDateTime(reader["ngaysinh"]);
                        thuePhong.Gioitinh = reader["gioitinh"].ToString();
                        thuePhong.Sodienthoai = reader["sodienthoai"].ToString();
                        thuePhong.Cmnd = reader["cmnd"].ToString();
                        thuePhong.Songuoio = Convert.ToInt32(reader["songuoio"]);
                        thuePhong.Quoctich = reader["quoctich"].ToString();
                        thuePhong.Ngayden = Convert.ToDateTime(reader["ngayden"]);
                        thuePhong.Ngaydi = Convert.ToDateTime(reader["ngaydi"]);
                        thuePhong.Tienphaitra = float.Parse(reader["tienphaitra"].ToString());
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                    reader.Close();

                if (sqlConnection != null && sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }
            return true;
        }
    }
}

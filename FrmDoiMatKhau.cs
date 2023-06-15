using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System_Winforrm
{
    public partial class FrmDoiMatKhau : Form
    {
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }
        QuanLyTaiKhoan tk = new QuanLyTaiKhoan();
        public bool checkPassword(string check)
        {
            return Regex.IsMatch(check, "^[a-zA-Z0-9.!@#$%^&*(),.?\":{}|<> ]{6,24}$");
        }
        private void btndmk_Click(object sender, EventArgs e)
        {
            string mkcu = txtPasswordOld.Text;
            string mkmoi = txtPasswordNew.Text;
            string tentk = txtUsername.Text;
            string remk = txtPassWordNewRw.Text;
            if (!checkPassword(mkmoi))
            {
                MessageBox.Show("Vui Lòng Nhập Đúng Thông Tin Yêu Cầu Dộ Dài 6-24 Kí Tự", "Cảnh Báo Sai Thông Tin", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            if (tk.Account("Select * from DangNhap where taikhoan = '" + tentk + "'").Count() == 0)
            {
                MessageBox.Show("Tên Tài Khoản Không Tồn Tại Trong Hệ Thống", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (!mkmoi.Equals(remk))
            {
                MessageBox.Show("2 Mật Khẩu Không Trùng Khớp", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            if (tk.Update(mkmoi, tentk, mkcu))
            {
                MessageBox.Show("Đã Đổi Mật Khẩu Thành Công");
            }
            else
            {
                MessageBox.Show("Thất Bại Khi Đổi Mật Khẩu");
            }
        }
    }
}

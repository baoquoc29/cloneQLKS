using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Hotel_Management_System_Winforrm
{
    public partial class ThongTinNhanVienCaTruc : Form
    {
        public ThongTinNhanVienCaTruc()
        {
            InitializeComponent();
        }
        QuanLyTaiKhoan tk = new QuanLyTaiKhoan();
        TaiKhoan thongtin = new TaiKhoan();
        FrmLogin fr = new FrmLogin();
        private void ThongTinNhanVienCaTruc_Load(object sender, EventArgs e)
        {
            txt_tk.Enabled = false;
                dataGridView1.DataSource = tk.getThongTinNhanVien();
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string gt = txt_gt.Text;
            string ngaySinh = dtpNs.Value.ToString();
            string tkt = txt_tk.Text;
            string mk = txt_password.Text;
            
            if (tk.UpdateTK(mk,name, gt, ngaySinh, tkt) == true)
            {
                dataGridView1.DataSource = tk.getThongTinNhanVien();
            }
            else
            {
                MessageBox.Show("Mật Khẩu Thông tin Không Chính Xác");
            }
            txtName.Text = "";
            txt_gt.Text = "";
            txt_tk.Text = "";
            txt_password.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[e.RowIndex];
                txtName.Text = row.Cells[0].Value.ToString();
                txt_tk.Text = row.Cells[1].Value.ToString();
                dtpNs.Value = Convert.ToDateTime(row.Cells[2].Value);
                txt_gt.Text = row.Cells[3].Value.ToString();  
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System_Winforrm
{
    public partial class FrmChuyenPhong1 : Form
    {
        private string tenphong;
        private ChuyenPhong chuyenPhong;
        private ThuePhong thuePhong;
        private Button btnPhong;

        public FrmChuyenPhong1(string tenphong, Button btnPhong)
        {
            InitializeComponent();
            this.tenphong = tenphong;
            this.btnPhong = btnPhong;
            txtPhong.Text = tenphong;
            chuyenPhong = new ChuyenPhong();
        }



        private void FrmChuyenPhong1_Load(object sender, EventArgs e)
        {
            try
            {
                dgvPhongTrong.DataSource = chuyenPhong.danhSachPhongTrong();
            }
            catch
            {
                MessageBox.Show("Lỗi hiển thị danh sách phòng trống!");
            }
            cboLoaiPhong.SelectedItem = "Tat ca";
            thuePhong = new ThuePhong();
            if (chuyenPhong.thongTinKhachThuePhong(thuePhong, tenphong))
            {
                txtLoaiPhong.Text = thuePhong.Loaiphong;
                txtTenKhach.Text = thuePhong.Tenkhachhang;
                dtpNgaySinh.Value = thuePhong.Ngaysinh;
                if (thuePhong.Gioitinh == "Nam") rdoNam.Checked = true;
                else rdoNu.Checked = true;
                txtSDT.Text = thuePhong.Sodienthoai;
                txtCMND.Text = thuePhong.Cmnd;
                cboQuocTich.Text = thuePhong.Quoctich.ToString();
                dtpNgayDen.Value = thuePhong.Ngayden;
                dtpNguoiDi.Value = thuePhong.Ngaydi;
                txtTienPhaiTra.Text = thuePhong.ToString();
                txtSoNguoiO.Text = thuePhong.Songuoio.ToString();
            }
            else
            {
                MessageBox.Show("Lỗi hiển thị thông tin khách đang ở!");
            }
        }

        private void reset()
        {
            txtPhongChuyen.Text = "";
            txtLoaiPhongChuyen.Text = "";
            txtMoTa.Text = "";
            txtSoNguoiO_PhongChuyen.Text = "";
            txtTrangThaiChuyen.Text = "";
            txtGiaPhongChuyen.Text = "";
        }

        private void btnChuyenPhong_Click(object sender, EventArgs e)
        {
            if(chuyenPhong.chuyenSangPhongMoi(thuePhong, txtPhongChuyen.Text, txtLoaiPhongChuyen.Text) && chuyenPhong.xoaPhongCu(tenphong) && chuyenPhong.capNhapPhongCu(tenphong) && chuyenPhong.capNhapPhongMoi(txtPhongChuyen.Text))
            {
                btnPhong.BackColor = Color.White;
                txtPhong.Text = txtPhongChuyen.Text;
                txtLoaiPhong.Text = txtLoaiPhong.Text;
                reset();
                try
                {
                    dgvPhongTrong.DataSource = chuyenPhong.danhSachPhongTrong();
                }
                catch
                {
                    MessageBox.Show("Lỗi hiển thị danh sách phòng trống!");
                }
                btnChuyenPhong.Enabled = false;
            }
            else
            {
                MessageBox.Show("Lỗi không chuyển được!");
            }
        }

        private void dgvPhongTrong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvPhongTrong.Rows[e.RowIndex];
            if (e.RowIndex >= 0 && e.RowIndex < dgvPhongTrong.RowCount - 1)
            {
                txtPhongChuyen.Text = row.Cells[0].Value.ToString();
                txtLoaiPhongChuyen.Text = row.Cells[1].Value.ToString();
                txtMoTa.Text = row.Cells[2].Value.ToString();
                txtSoNguoiO_PhongChuyen.Text = row.Cells[3].Value.ToString();
                txtTrangThaiChuyen.Text = row.Cells[4].Value.ToString();
                txtGiaPhongChuyen.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string loaiPhong = cboLoaiPhong.SelectedItem.ToString();
            if(loaiPhong == "" || loaiPhong == "Tat ca")
            {
                try
                {
                    dgvPhongTrong.DataSource = chuyenPhong.danhSachPhongTrong();
                }
                catch
                {
                    MessageBox.Show("Lỗi hiển thị danh sách phòng trống!");
                }
            }
            else
            {
                try
                {
                    dgvPhongTrong.DataSource = chuyenPhong.timTheoLoaiPhong(loaiPhong);
                }
                catch
                {
                    MessageBox.Show("Lỗi hiển thị danh sách phòng trống!");
                }
            }
        }
    }
}

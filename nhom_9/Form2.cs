using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nhom_9
{
    public partial class frm_dang_nhap : Form
    {
        string tenTaiKhoan = "admin";
        string matKhau = "12345";
        public frm_dang_nhap()
        {
            InitializeComponent();
        }

        private void frm_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frm_dangnhap_Click(object sender, EventArgs e)
        {
            if (kiemTraDangNhap(txt_tentaikhoan.Text, txt_matkhau.Text))
            {
                frm_dat_lich f = new frm_dat_lich();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai Tên Tài Khoản Hoặc Mật Khẩu", "Lỗi");

            }
        }
        bool kiemTraDangNhap(string tenTaiKhoan, string matkhau)
        {
            if (tenTaiKhoan == this.tenTaiKhoan && matkhau == this.matKhau)
            {
                return true;
            }
            return false; ;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_dang_nhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frm_dang_nhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("BạnCó Muốn Thoát Chương Trình", "Cảnh Báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                e.Cancel = true;
        }
    }
}

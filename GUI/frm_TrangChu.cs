using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS464O_Nhom7.GUI
{
    public partial class frm_TrangChu : Form
    {
        public frm_TrangChu()
        {
            InitializeComponent();
        }


        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DangNhap dangNhap = new frm_DangNhap();
            dangNhap.Show();
            this.Close();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void khoHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (Application.OpenForms["frm_QuanLyKH"] == null)
            {
                frm_QuanLyKH quanLyKH = new frm_QuanLyKH();
                quanLyKH.MdiParent = this;
                quanLyKH.Show();

            }
            else Application.OpenForms["frm_QuanLyKH"].Activate();

        }

        private void sanphamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (Application.OpenForms["frm_QuanLySP"] == null)
            {
                frm_QuanLySP sp = new frm_QuanLySP();
                sp.MdiParent = this;
                sp.Show();

            }
            else Application.OpenForms["frm_QuanLySP"].Activate();
        }

        private void HDToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (Application.OpenForms[" frm_HoaDon"] == null)
            {
                frm_HoaDon hoaDon = new frm_HoaDon();
                hoaDon.MdiParent = this;
                hoaDon.Show();

            }
            else Application.OpenForms[" frm_HoaDon"].Activate();
        }
    }
}

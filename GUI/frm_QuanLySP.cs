using CS464O_Nhom7.DAL;
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
    public partial class frm_QuanLySP : Form
    {
        public frm_QuanLySP()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            bllp = new BLL.BllPhong(this);
        }
        LopDungChung lopchung;
        BLL.BllPhong bllp;

        private void Phong_Load(object sender, EventArgs e)
        {
            loadgird();
            loadcombo();
        }
        public void loadgird()
        {
            bllp.BllGrid();
        }
        public void loadcombo()
        {
            bllp.Bllloadcombo();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            bllp.BllThem();
            loadgird();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            bllp.BllSua();
            loadgird();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            bllp.BllXoa();
            loadgird();
        }

        private void btn_Dem_Click(object sender, EventArgs e)
        {
            bllp.Blldem();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_masp.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_soluong.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_tensp.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_giatien.Text = dataGridView1.CurrentRow.Cells[04].Value.ToString();
            
            cb_trangthai.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value.ToString();
           
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

        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_QuanLyKH quanLyKH = new frm_QuanLyKH();
            quanLyKH.Show();
        }

        private void HDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_HoaDon hoaDon = new frm_HoaDon();
            hoaDon.Show();
        }

        private void cb_trangthai_SelectedIndexChanged(object sender, EventArgs e)
        {
            bllp.BllLocCombo();
        }
    }
}

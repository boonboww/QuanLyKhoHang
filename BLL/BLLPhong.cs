using CS464O_Nhom7.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS464O_Nhom7.BLL
{
    internal class BllPhong
    {
        DAL.DalSanPham dap;
        frm_QuanLySP P;
        public BllPhong(frm_QuanLySP fP)
        {
            dap = new DAL.DalSanPham();
            P = fP;
        }
        public void BllGrid()
        {
            P.dataGridView1.DataSource = dap.DalLoadGrid();
        }
        public void Bllloadcombo()
        {
            P.cb_trangthai.DataSource = dap.DalLoadCombo();
            P.cb_trangthai.DisplayMember = "TrangThai";
            P.cb_trangthai.ValueMember ="TrangThai";
        }
        public void Blldem() {
            P.txt_Dem.Text = dap.DalDem().ToString();
        }

        public void BllThem()
        {
           dap.DalThem(P.txt_masp.Text,P.txt_soluong.Text,P.cb_trangthai.SelectedValue.ToString(),P.txt_tensp.Text,P.txt_giatien.Text);
        }
        public void BllSua()
        {
            dap.DalSua(P.txt_masp.Text, P.txt_soluong.Text, P.cb_trangthai.SelectedValue.ToString(), P.txt_tensp.Text, P.txt_giatien.Text);

        }
        public void BllXoa()
        {
            dap.DalXoa(P.txt_masp.Text);
        }
        public void BllLocCombo()
        {
            P.dataGridView1.DataSource = dap.DalLocCombo(P.cb_trangthai.SelectedValue.ToString());
        }
    }
}

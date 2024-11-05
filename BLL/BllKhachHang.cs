using CS464O_Nhom7.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS464O_Nhom7.BLL
{
    internal class BllKhachHang
    {
        
            DAL.DalKhoHang daKh;
            frm_QuanLyKH KH;
            public BllKhachHang(frm_QuanLyKH fKh)
            {
                daKh = new DAL.DalKhoHang();
                KH = fKh;
            }
            public void BllGrid()
            {
               KH.dataGridView1.DataSource = daKh.DalLoadGrid();
            }
        public void BllThem()
        {
            daKh.DalThem(KH.txt_Makh.Text,KH.txt_tenhk.Text,KH.txt_diachi.Text,KH.txt_tenHinh.Text);
        }
        public void BllSua()
        {daKh.DalSua(KH.txt_Makh.Text, KH.txt_tenhk.Text, KH.txt_diachi.Text, KH.txt_tenHinh.Text);
           
        }
        public void BllXoa()
        {
            daKh.DalXoa(KH.txt_Makh.Text);
        }
        public void Blltim()
        {
            KH.dataGridView1.DataSource= daKh.DalTim(KH.txt_Tim.Text);
        }


    }
}

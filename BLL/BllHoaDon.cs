using CS464O_Nhom7.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS464O_Nhom7.BLL
{
    internal class BllHoaDon
    {
        DAL.DalHoaDon dahd;
        frm_HoaDon HD;
        public BllHoaDon(frm_HoaDon fhd)
        {
            dahd = new DAL.DalHoaDon();
            HD = fhd;
        }
        public void BllGrid()
        {
            HD.dataGridView1.DataSource = dahd.DalLoadGrid();
        }
        public void BllThem()
        {
            dahd.DalThem(HD.txt_mahd.Text,HD.txt_masp.Text,HD.txt_makh.Text,HD.dateTime_ngayvao.Value,HD.dateTime_ngaydi.Value);
        }
        public void BllSua()
        {
            dahd.DalSua(HD.txt_mahd.Text, HD.txt_masp.Text, HD.txt_makh.Text, HD.dateTime_ngayvao.Value, HD.dateTime_ngaydi.Value);
        }
        public void BllXoa()
        {
            dahd.DalXoa(HD.txt_mahd.Text);
        }

    }
}

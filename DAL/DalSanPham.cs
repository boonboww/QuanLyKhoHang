using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS464O_Nhom7.DAL
{
    internal class DalSanPham
    {
        LopDungChung lopchung;

        public string tenhinh { get; private set; }

        public DalSanPham()
        {
            lopchung = new LopDungChung();
        }
        public DataTable DalLoadGrid()
        {
            String sqlGrid = "select * from SanPham";
            return lopchung.LoadDaTa(sqlGrid);

        }
        public DataTable DalLoadCombo()
        {
            String sqlGrid = "select * from SanPham ";
            return lopchung.LoadDaTa(sqlGrid);

        }
        public int DalDem()
        {
            String sqlDem = "select COUNT (*) from SanPham";
            int kq = (int)lopchung.Scalar(sqlDem);
            return kq;
        }
        public DataTable DalLocCombo(String trangthai)
        {
            String sqlGrid = "select * from SanPham where TrangThai =N'" + trangthai + "'";
            return lopchung.LoadDaTa(sqlGrid);

        }
        public void DalThem(String Masp, String Sol, String TrangThai, string Tensp, string giatien)
        {
            String sqlThem = "insert into SanPham values('" + Masp + "', N'" + Sol + "',N'" + TrangThai + "',N'" + Tensp + "','"+float.Parse(giatien)+"')";
            lopchung.Nonquery(sqlThem);
        }
        public void DalSua(String Masp, String Sol, String TrangThai, string Tensp, string giatien)
        {
            String sqlSua = "update SanPham set  SoLuong =N'" + Sol + "',TrangThai =N'" + TrangThai + "',TenSP =N'" + Tensp + "', GiaTien ='"+giatien+"'where MaSP =N'"+Masp+"'";
            lopchung.Nonquery(sqlSua);
        }
        public void DalXoa(String masp)
        {
            String sqlXoa = "delete from SanPham where MaSP = '" + masp + "'";
            lopchung.Nonquery(sqlXoa);
        }
    }
}

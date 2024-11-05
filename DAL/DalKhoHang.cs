using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS464O_Nhom7.DAL
{
    internal class DalKhoHang
    {
        LopDungChung lopchung;
        public DalKhoHang()
        {
            lopchung = new LopDungChung();
        }
        public DataTable DalLoadGrid()
        {
            String sqlGrid = "select * from KhoHang";
            return lopchung.LoadDaTa(sqlGrid);

        }
        public void DalThem(String makh, String tenkh,String diachi, string tenhinh)
        {
            String sqlThem = "insert into KhoHang values('" + makh + "', N'" + tenkh + "','"+diachi+"','"+tenhinh+"')";
            lopchung.Nonquery(sqlThem);
        }
        public void DalSua(String makh, String tenkh, String diachi, string tenhinh)
        {
            String sqlSua = "update KhoHang set  TenKh = N'" + tenkh + "',DiaChi = '"+diachi+"',HinhAnh =N'"+tenhinh+"'where MaKh =N'" + makh + "'";
            lopchung.Nonquery(sqlSua);
        }
        public void DalXoa(String makh)
        {
            String sqlXoa = "delete from KhoHang where MaKh = '" + makh + "'";
            lopchung.Nonquery(sqlXoa);
        }
        public DataTable DalTim(String tim)
        {
            String sqlGrid = "select * from KhoHang where MaKh like '%" + tim + "%' or" +
                " TenKh like '%" + tim + "%'";
            return lopchung.LoadDaTa(sqlGrid);
        }
    }
}

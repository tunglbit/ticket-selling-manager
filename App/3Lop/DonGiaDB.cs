using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace _QuanLyBanVeXe
{
    public class DonGiaDB
    {
        private DbManager manager;

        public DonGiaDB()
        {
            manager = new DbManager();
            manager.open();
        }

        public List<DonGia> getAll()
        {
            String sql = "select * from DonGia";
            DataTable table = manager.executeQuery(sql);

            List<DonGia> list = new List<DonGia>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];

                string maDonGia = (string)row["maDonGia"];
                string maTuyenDi = (string)row["maTuyenDi"];
                Decimal gia = Convert.ToDecimal(row["gia"]);

                DonGia c = new DonGia(maDonGia, maTuyenDi, gia);

                list.Add(c);
            }

            return list;
        }

        public bool add(DonGia c)
        {
            try
            {
                String sql = "insert into DonGia values(@maDonGia, @maTuyenDi, @gia)";

                SqlParameter p1 = new SqlParameter("@maDonGia", c.MaDonGia);
                SqlParameter p2 = new SqlParameter("@maTuyenDi", c.MaTuyenDi);
                SqlParameter p3 = new SqlParameter("@gia", c.Gia);

                SqlParameter[] param = {p1, p2, p3};

                return manager.executeUpdate(sql, param);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool delete(string maDonGia)
        {
            String sql = "delete from DonGia where maDonGia = @maDonGia";
            SqlParameter p1 = new SqlParameter("@maDonGia", maDonGia);
            SqlParameter[] param = { p1 };

            return manager.executeUpdate(sql, param);
        }

        public bool update(DonGia c)
        {
            String sql = "update DonGia set maTuyenDi = @maTuyenDi, gia = @gia where maDonGia = @maDonGia";
            SqlParameter p1 = new SqlParameter("@maDonGia", c.MaDonGia);
            SqlParameter p2 = new SqlParameter("@maTuyenDi", c.MaTuyenDi);
            SqlParameter p3 = new SqlParameter("@gia", c.Gia);

            SqlParameter[] param = { p1, p2, p3 };

            return manager.executeUpdate(sql, param);
        }

    }
}

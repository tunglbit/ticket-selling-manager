using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace _QuanLyBanVeXe
{
    public class VeXeDB
    {
        private DbManager manager;

        public VeXeDB()
        {
            manager = new DbManager();
            manager.open();
        }

        public List<VeXe> getAll()
        {
            String sql = "select * from VeXe";
            DataTable table = manager.executeQuery(sql);

            List<VeXe> list = new List<VeXe>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];

                string maVeXe = (string)row["maVeXe"];
                string maChuyenDi = (string)row["maChuyenDi"];
                string maHanhKhach = (string)row["maHanhKhach"];
                decimal giaTien = (decimal)row["giaTien"];

                VeXe c = new VeXe(maVeXe, maChuyenDi, maHanhKhach, giaTien);

                list.Add(c);
            }

            return list;
        }

        public bool add(VeXe c)
        {
            try
            {
                String sql = "insert into VeXe values(@maVeXe, @maChuyenDi, @maHanhKhach, @giaTien)";

                SqlParameter p1 = new SqlParameter("@maVeXe", c.MaVeXe);
                SqlParameter p2 = new SqlParameter("@maChuyenDi", c.MaChuyenDi);
                SqlParameter p3 = new SqlParameter("@maHanhKhach", c.MaHanhKhach);
                SqlParameter p4 = new SqlParameter("@giaTien", c.GiaTien);

                SqlParameter[] param = { p1, p2, p3, p4 };

                return manager.executeUpdate(sql, param);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool delete(string maVeXe)
        {
            String sql = "delete from VeXe where maVeXe = @maVeXe";
            SqlParameter p1 = new SqlParameter("@maVeXe", maVeXe);
            SqlParameter[] param = { p1 };

            return manager.executeUpdate(sql, param);
        }

        public bool update(VeXe c)
        {
            String sql = "update VeXe set maChuyenDi = @maChuyenDi, maHanhKhach = @maHanhKhach, giaTien = @giaTien where maVeXe = @maVeXe";

            SqlParameter p1 = new SqlParameter("@maVeXe", c.MaVeXe);
            SqlParameter p2 = new SqlParameter("@maChuyenDi", c.MaChuyenDi);
            SqlParameter p3 = new SqlParameter("@maHanhKhach", c.MaHanhKhach);
            SqlParameter p4 = new SqlParameter("@giaTien", c.GiaTien);

            SqlParameter[] param = { p1, p2, p3, p4 };

            return manager.executeUpdate(sql, param);
        }
    }
}

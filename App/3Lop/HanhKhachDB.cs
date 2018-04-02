using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace _QuanLyBanVeXe
{
    public class HanhKhachDB
    {
        private DbManager manager;

        public HanhKhachDB()
        {
            manager = new DbManager();
            manager.open();
        }

        public List<HanhKhach> getAll()
        {
            String sql = "select * from HanhKhach";
            DataTable table = manager.executeQuery(sql);

            List<HanhKhach> list = new List<HanhKhach>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];

                string maHanhKhach = (string)row["maHanhKhach"];
                string tenHanhKhach = (string)row["tenHanhKhach"];
                string cmnd = (string)row["cmnd"];
                string dienThoai = (string)row["dienThoai"];

                HanhKhach c = new HanhKhach(maHanhKhach, tenHanhKhach, cmnd, dienThoai);

                list.Add(c);
            }

            return list;
        }

        public HanhKhach selectHanhKhach(string maHK)
        {
            String sql = "select * from HanhKhach where maHanhKhach = @maHanhKhach";

            DataTable table = manager.executeQuery(sql);
          
            DataRow row = table.Rows[0];

            string maHanhKhach = (string)row["maHanhKhach"];
            string tenHanhKhach = (string)row["tenHanhKhach"];
            string cmnd = (string)row["cmnd"];
            string dienThoai = (string)row["dienThoai"];

            HanhKhach c = new HanhKhach(maHanhKhach, tenHanhKhach, cmnd, dienThoai);

            return c;
        }

        public bool add(HanhKhach c)
        {
            try
            {
                String sql = "insert into HanhKhach values(@maHanhKhach, @tenHanhKhach, @cmnd, @dienThoai)";

                SqlParameter p1 = new SqlParameter("@maHanhKhach", c.MaHanhKhach);
                SqlParameter p2 = new SqlParameter("@tenHanhKhach", c.TenHanhKhach);
                SqlParameter p3 = new SqlParameter("@cmnd", c.Cmnd);
                SqlParameter p4 = new SqlParameter("@dienThoai", c.DienThoai);

                SqlParameter[] param = { p1, p2, p3, p4 };

                return manager.executeUpdate(sql, param);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool delete(string maHanhKhach)
        {
            String sql = "delete from HanhKhach where maHanhKhach = @maHanhKhach";
            SqlParameter p1 = new SqlParameter("@maHanhKhach", maHanhKhach);
            SqlParameter[] param = { p1 };

            return manager.executeUpdate(sql, param);
        }

        public bool update(HanhKhach c)
        {
            String sql = "update HanhKhach set tenHanhKhach = @tenHanhKhach, cmnd = @cmnd, dienThoai = @dienThoai where maHanhKhach = @maHanhKhach";
            
            SqlParameter p1 = new SqlParameter("@maHanhKhach", c.MaHanhKhach);
            SqlParameter p2 = new SqlParameter("@tenHanhKhach", c.TenHanhKhach);
            SqlParameter p3 = new SqlParameter("@cmnd", c.Cmnd);
            SqlParameter p4 = new SqlParameter("@dienThoai", c.DienThoai);

            SqlParameter[] param = { p1, p2, p3, p4 };

            return manager.executeUpdate(sql, param);
        }
    }
}

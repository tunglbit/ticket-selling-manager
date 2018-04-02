using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace _QuanLyBanVeXe
{
    public class BenXeDB
    {
        private DbManager manager;

        public BenXeDB()
        {
            manager = new DbManager();
            manager.open();
        }

        public List<BenXe> getAll()
        {
            String sql = "select * from BenXe";
            DataTable table = manager.executeQuery(sql);

            List<BenXe> list = new List<BenXe>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];

                string maBenXe = (string)row["maBenXe"];
                string tenBenXe = (string)row["tenBenXe"];

                BenXe c = new BenXe(maBenXe, tenBenXe);

                list.Add(c);
            }
            


            return list;
        }

        public bool add(BenXe c)
        {
            try
            {
                String sql = "insert into BenXe values(@maBenXe, @tenBenXe)";

                SqlParameter p1 = new SqlParameter("@maBenXe", c.MaBenXe);
                SqlParameter p2 = new SqlParameter("@tenBenXe", c.TenBenXe);

                SqlParameter[] param = { p1, p2};

                return manager.executeUpdate(sql, param);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool delete(string maBenXe)
        {
            String sql = "delete from BenXe where maBenXe = @maBenXe";
            SqlParameter p1 = new SqlParameter("@maBenXe", maBenXe);
            SqlParameter[] param = { p1 };

            return manager.executeUpdate(sql, param);
        }

        public bool update(BenXe c)
        {
            String sql = "update BenXe set tenBenXe = @tenBenXe where maBenXe = @maBenXe";
            SqlParameter p1 = new SqlParameter("@maBenXe", c.MaBenXe);
            SqlParameter p2 = new SqlParameter("@tenBenXe", c.TenBenXe);

            SqlParameter[] param = { p1, p2};

            return manager.executeUpdate(sql, param);
        }

    }
}

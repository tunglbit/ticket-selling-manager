using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace _QuanLyBanVeXe
{
    public class TuyenDiDB
    {
        private DbManager manager;

        public TuyenDiDB()
        {
            manager = new DbManager();
            manager.open();
        }

        public List<TuyenDi> getAll()
        {
            String sql = "select * from TuyenDi";
            DataTable table = manager.executeQuery(sql);

            List<TuyenDi> list = new List<TuyenDi>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];

                string maTuyenDi = (string)row["maTuyenDi"];
                string benXeDi = (string)row["benXeDi"];
                string benXeDen = (string)row["benXeDen"];

                TuyenDi c = new TuyenDi(maTuyenDi, benXeDi, benXeDen);

                list.Add(c);
            }
            


            return list;
        }

        public bool add(TuyenDi c)
        {
            try
            {
                String sql = "insert into TuyenDi values(@maTuyenDi, @benXeDi, @benXeDen)";

                SqlParameter p1 = new SqlParameter("@maTuyenDi", c.MaTuyenDi);
                SqlParameter p2 = new SqlParameter("@benXeDi", c.BenXeDi);
                SqlParameter p3 = new SqlParameter("@benXeDen", c.BenXeDen);

                SqlParameter[] param = { p1, p2, p3 };

                return manager.executeUpdate(sql, param);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool delete(string maTuyenDi)
        {
            String sql = "delete from TuyenDi where maTuyenDi = @maTuyenDi";
            SqlParameter p1 = new SqlParameter("@maTuyenDi", maTuyenDi);
            SqlParameter[] param = { p1 };

            return manager.executeUpdate(sql, param);
        }

        public bool update(TuyenDi c)
        {
            String sql = "update TuyenDi set benXeDi = @benXeDi, benXeDen = @benXeDen where maTuyenDi = @maTuyenDi";
            SqlParameter p1 = new SqlParameter("@maTuyenDi", c.MaTuyenDi);
            SqlParameter p2 = new SqlParameter("@benXeDi", c.BenXeDi);
            SqlParameter p3 = new SqlParameter("@benXeDen", c.BenXeDen);

            SqlParameter[] param = { p1, p2, p3 };

            return manager.executeUpdate(sql, param);
        }

    }
}

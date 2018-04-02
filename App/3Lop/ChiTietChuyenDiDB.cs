using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace _QuanLyBanVeXe
{
    public class ChiTietChuyenDiDB
    {
        private DbManager manager;

        public ChiTietChuyenDiDB()
        {
            manager = new DbManager();
            manager.open();
        }

        public List<ChiTietChuyenDi> getAll(string maChuyenDi)
        {
            String sql = "select * from ChiTietChuyenDi where maChuyenDi = @maChuyenDi";

            SqlParameter p1 = new SqlParameter("@maChuyenDi", maChuyenDi);

            SqlParameter[] param = { p1 };
            DataTable table = manager.executeQuery(sql, param);

            List<ChiTietChuyenDi> list = new List<ChiTietChuyenDi>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];

                string benXeTrungGian = (string)row["benXeTrungGian"];
                int thoiGianDung = (int)row["thoiGianDung"];
                string ghiChu = (string)row["ghiChu"];

                ChiTietChuyenDi c = new ChiTietChuyenDi(maChuyenDi, benXeTrungGian, thoiGianDung, ghiChu);

                list.Add(c);
            }

            return list;
        }

        public bool add(ChiTietChuyenDi c)
        {
            try
            {
                String sql = "insert into ChiTietChuyenDi values(@maChuyenDi, @benXeTrungGian, @thoiGianDung, @ghiChu)";

                SqlParameter p1 = new SqlParameter("@maChuyenDi", c.MaChuyenDi);
                SqlParameter p2 = new SqlParameter("@benXeTrungGian", c.BenXeTrungGian);
                SqlParameter p3 = new SqlParameter("@thoiGianDung", c.ThoiGianDung);
                SqlParameter p4 = new SqlParameter("@ghiChu", c.GhiChu);

                SqlParameter[] param = { p1, p2, p3, p4 };

                return manager.executeUpdate(sql, param);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool delete(string maChiTietChuyenDi, string benXeTrungGian)
        {
            String sql = "delete from ChiTietChuyenDi where maChuyenDi = @maChuyenDi and benXeTrungGian = @benXeTrungGian";

            SqlParameter p1 = new SqlParameter("@maChuyenDi", maChiTietChuyenDi);
            SqlParameter p2 = new SqlParameter("@benXeTrungGian", benXeTrungGian);

            SqlParameter[] param = { p1, p2 };

            return manager.executeUpdate(sql, param);
        }

        public bool update(ChiTietChuyenDi c)
        {
            String sql = "update ChiTietChuyenDi set thoiGianDung = @thoiGianDung, ghiChu = @ghiChu where maChuyenDi = @maChuyenDi and benXeTrungGian = @benXeTrungGian";
            
            SqlParameter p1 = new SqlParameter("@maChuyenDi", c.MaChuyenDi);
            SqlParameter p2 = new SqlParameter("@benXeTrungGian", c.BenXeTrungGian);
            SqlParameter p3 = new SqlParameter("@thoiGianDung", c.ThoiGianDung);
            SqlParameter p4 = new SqlParameter("@ghiChu", c.GhiChu);

            SqlParameter[] param = { p1, p2, p3, p4 };

            return manager.executeUpdate(sql, param);
        }
    }
}

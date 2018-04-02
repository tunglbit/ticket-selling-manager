using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace _QuanLyBanVeXe
{
    public class PhieuDatChoDB
    {
        private DbManager manager;

        public PhieuDatChoDB()
        {
            manager = new DbManager();
            manager.open();
        }

        public List<PhieuDatCho> getAll()
        {
            String sql = "select * from PhieuDatCho";
            DataTable table = manager.executeQuery(sql);

            List<PhieuDatCho> list = new List<PhieuDatCho>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];

                string maPhieuDatCho = (string)row["maPhieuDatCho"];
                string maChuyenDi = (string)row["maChuyenDi"];
                string maHanhKhach = (string)row["maHanhKhach"];
                decimal giaTien = (decimal)row["giaTien"];
                DateTime ngayDat = (DateTime)row["ngayDat"];

                PhieuDatCho c = new PhieuDatCho(maPhieuDatCho, maChuyenDi, maHanhKhach, giaTien, ngayDat);

                list.Add(c);
            }
            
            return list;
        }

        public bool add(PhieuDatCho c)
        {
            try
            {
                String sql = "insert into PhieuDatCho values(@maPhieuDatCho, @maChuyenDi, @maHanhKhach, @giaTien, @ngayDat)";

                SqlParameter p1 = new SqlParameter("@maPhieuDatCho", c.MaPhieuDatCho);
                SqlParameter p2 = new SqlParameter("@maChuyenDi", c.MaChuyenDi);
                SqlParameter p3 = new SqlParameter("@maHanhKhach", c.MaHanhKhach);
                SqlParameter p4 = new SqlParameter("@giaTien", c.GiaTien);
                SqlParameter p5 = new SqlParameter("@ngayDat", c.NgayDat);

                SqlParameter[] param = { p1, p2, p3, p4, p5 };

                return manager.executeUpdate(sql, param);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool delete(string maPhieuDatCho)
        {
            String sql = "delete from PhieuDatCho where maPhieuDatCho = @maPhieuDatCho";
            SqlParameter p1 = new SqlParameter("@maPhieuDatCho", maPhieuDatCho);
            SqlParameter[] param = { p1 };

            return manager.executeUpdate(sql, param);
        }

        public bool update(PhieuDatCho c)
        {
            String sql = "update PhieuDatCho set maChuyenDi = @maChuyenDi, maHanhKhach = @maHanhKhach, giaTien = @giaTien, ngayDat = @ngayDat where maPhieuDatCho = @maPhieuDatCho";

            SqlParameter p1 = new SqlParameter("@maPhieuDatCho", c.MaPhieuDatCho);
            SqlParameter p2 = new SqlParameter("@maChuyenDi", c.MaChuyenDi);
            SqlParameter p3 = new SqlParameter("@maHanhKhach", c.MaHanhKhach);
            SqlParameter p4 = new SqlParameter("@giaTien", c.GiaTien);
            SqlParameter p5 = new SqlParameter("@ngayDat", c.NgayDat);

            SqlParameter[] param = { p1, p2, p3, p4, p5 };

            return manager.executeUpdate(sql, param);
        }
    }
}

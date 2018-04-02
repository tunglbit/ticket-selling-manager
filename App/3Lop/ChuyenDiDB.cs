using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace _QuanLyBanVeXe
{
    public class ChuyenDiDB
    {
        private DbManager manager;

        public ChuyenDiDB()
        {
            manager = new DbManager();
            manager.open();
        }

        public List<ChuyenDi> getAll()
        {
            String sql = "select * from ChuyenDi";
            DataTable table = manager.executeQuery(sql);

            List<ChuyenDi> list = new List<ChuyenDi>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];

                string maChuyenDi = (string)row["maChuyenDi"];
                string maTuyenDi = (string)row["maTuyenDi"];
                DateTime ngayGio = (DateTime)row["ngayGio"];
                int thoiGianDi = (int)row["thoiGianDi"];
                int soLuongGhe = (int)row["soLuongGhe"];

                ChuyenDi c = new ChuyenDi(maChuyenDi, maTuyenDi, ngayGio, thoiGianDi, soLuongGhe);

                list.Add(c);
            }

            return list;
        }

        public bool add(ChuyenDi c)
        {
            try
            {
                String sql = "insert into ChuyenDi values(@maChuyenDi, @maTuyenDi, @ngayGio, @thoiGianDi, @soLuongGhe)";

                SqlParameter p1 = new SqlParameter("@maChuyenDi", c.MaChuyenDi);
                SqlParameter p2 = new SqlParameter("@maTuyenDi", c.MaTuyenDi);
                SqlParameter p3 = new SqlParameter("@ngayGio", c.NgayGio);
                SqlParameter p4 = new SqlParameter("@thoiGianDi", c.ThoiGianDi);
                SqlParameter p5 = new SqlParameter("@soLuongGhe", c.SoLuongGhe);

                SqlParameter[] param = { p1, p2, p3, p4, p5 };

                return manager.executeUpdate(sql, param);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool delete(string maChuyenDi)
        {
            String sql = "delete from ChuyenDi where maChuyenDi = @maChuyenDi";
            SqlParameter p1 = new SqlParameter("@maChuyenDi", maChuyenDi);
            SqlParameter[] param = { p1 };

            return manager.executeUpdate(sql, param);
        }

        public bool update(ChuyenDi c)
        {
            String sql = "update ChuyenDi set maTuyenDi = @maTuyenDi, ngayGio = @ngayGio, thoiGianDi = @thoiGianDi, soLuongGhe = @soLuongGhe where maChuyenDi = @maChuyenDi";

            SqlParameter p1 = new SqlParameter("@maChuyenDi", c.MaChuyenDi);
            SqlParameter p2 = new SqlParameter("@maTuyenDi", c.MaTuyenDi);
            SqlParameter p3 = new SqlParameter("@ngayGio", c.NgayGio);
            SqlParameter p4 = new SqlParameter("@thoiGianDi", c.ThoiGianDi);
            SqlParameter p5 = new SqlParameter("@soLuongGhe", c.SoLuongGhe);

            SqlParameter[] param = { p1, p2, p3, p4, p5 };

            return manager.executeUpdate(sql, param);
        }

        public List<ChuyenDi> selectChuyenDiTheoThoiGian(string maTuyenDi, string thoiGianDau, string thoiGianCuoi)
        {
            String sql = "select * from ChuyenDi where maTuyenDi = @maTuyenDi and ngayGio >= @thoiGianDau and ngayGio <= @thoiGianCuoi";
            SqlParameter p1 = new SqlParameter("@maTuyenDi", maTuyenDi);
            SqlParameter p2 = new SqlParameter("@thoiGianDau", thoiGianDau);
            SqlParameter p3 = new SqlParameter("@thoiGianCuoi", thoiGianCuoi);

            SqlParameter[] param = { p1, p2, p3 };

            DataTable table = manager.executeQuery(sql, param);

            List<ChuyenDi> list = new List<ChuyenDi>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];

                string maChuyenDi = (string)row["maChuyenDi"];
                DateTime ngayGio = (DateTime)row["ngayGio"];
                int thoiGianDi = (int)row["thoiGianDi"];
                int soLuongGhe = (int)row["soLuongGhe"];

                ChuyenDi c = new ChuyenDi(maChuyenDi, maTuyenDi, ngayGio, thoiGianDi, soLuongGhe);

                list.Add(c);
            }

            return list;
        }
    }
}

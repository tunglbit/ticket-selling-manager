using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace _QuanLyBanVeXe
{
    class ThamSoDB
    {
        private DbManager manager;

        public ThamSoDB()
        {
            manager = new DbManager();
            manager.open();
        }

        public List<ThamSo> getAll()
        {
            String sql = "select * from ThamSo";
            DataTable table = manager.executeQuery(sql);

            List<ThamSo> list = new List<ThamSo>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];

                int thoiGianDiToiThieu = (int)row["thoiGianDiToiThieu"];
                int soBenXeTrungGianToiDa = (int)row["soBenXeTrungGianToiDa"];
                int thoiGianDungToiThieu = (int)row["thoiGianDungToiThieu"];
                int thoiGianDungToiDa = (int)row["thoiGianDungToiDa"];
                int thoiGianDatVeChamNhat = (int)row["thoiGianDatVeChamNhat"];
                int thoiGianHuyDatVeChamNhat = (int)row["thoiGianHuyDatVeChamNhat"];

                ThamSo c = new ThamSo(thoiGianDiToiThieu, soBenXeTrungGianToiDa, thoiGianDungToiThieu, thoiGianDungToiDa, thoiGianDatVeChamNhat, thoiGianHuyDatVeChamNhat);

                list.Add(c);
            }

            return list;
        }

        public bool updateChuyenDi(ThamSo c)
        {
            String sql = "update ThamSo set thoiGianDiToiThieu = @thoiGianDiToiThieu, soBenXeTrungGianToiDa = @soBenXeTrungGianToiDa, thoiGianDungToiThieu = @thoiGianDungToiThieu, thoiGianDungToiDa = @thoiGianDungToiDa";
            SqlParameter p1 = new SqlParameter("@thoiGianDiToiThieu", c.ThoiGianDiToiThieu);
            SqlParameter p2 = new SqlParameter("@soBenXeTrungGianToiDa", c.SoBenXeTrungGianToiDa);
            SqlParameter p3 = new SqlParameter("@thoiGianDungToiThieu", c.ThoiGianDungToiThieu);
            SqlParameter p4 = new SqlParameter("@thoiGianDungToiDa", c.ThoiGianDungToiDa);

            SqlParameter[] param = {p1, p2, p3, p4};

            return manager.executeUpdate(sql, param);
        }

        public bool updateHanDatVe(ThamSo c)
        {
            String sql = "update ThamSo set thoiGianDatVeChamNhat = @thoiGianDatVeChamNhat, thoiGianHuyDatVeChamNhat = @thoiGianHuyDatVeChamNhat";
            SqlParameter p1 = new SqlParameter("@thoiGianDatVeChamNhat", c.ThoiGianDatVeChamNhat);
            SqlParameter p2 = new SqlParameter("@thoiGianHuyDatVeChamNhat", c.ThoiGianHuyDatVeChamNhat);

            SqlParameter[] param = {p1, p2};

            return manager.executeUpdate(sql, param);
        }

    }
}

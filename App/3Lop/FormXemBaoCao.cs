using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace _QuanLyBanVeXe
{
    public partial class FormXemBaoCao : Form
    {
        private DbManager manager;

        public FormXemBaoCao()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            manager = new DbManager();
            manager.open();
            String sql = "select MaChuyenDi,(select count(*) from VEXE vx inner join CHUYENDI cd on vx.MaChuyenDi = cd.MaChuyenDi " +
                         "where vx.MaChuyenDi = CHUYENDI.MaChuyenDi and month(cd.NgayGio) = '" + cbThang.Text + "' and year(cd.NgayGio) = '" + cbNam.Text + "') as soVe,(select count(*) * vx.GiaTien " +
                         "from VEXE vx inner join CHUYENDI cd on vx.MaChuyenDi = cd.MaChuyenDi where vx.MaChuyenDi = " +
                         "CHUYENDI.MaChuyenDi and month(cd.NgayGio) = '" + cbThang.Text + "' and year(cd.NgayGio) = '" + cbNam.Text + "' group by vx.GiaTien) as doanhThu from CHUYENDI";

            DataTable table = manager.executeQuery(sql);
            int tongDoanhThu = 0;
            List<DoanhThuThang> list = new List<DoanhThuThang>();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                string maChuyenDi = (string)row["maChuyenDi"];
                int soVe = (int)row["soVe"];
                decimal doanhThu;
                if (soVe == 0)
                {
                    doanhThu = 0;
                }
                else
                {
                    doanhThu = Convert.ToDecimal(row["doanhThu"]);
                }
                tongDoanhThu = tongDoanhThu + (int)doanhThu;
                DoanhThuThang c = new DoanhThuThang(maChuyenDi, soVe, doanhThu);
                list.Add(c);
            }

            lblTongDoanhThu.Text = tongDoanhThu + " VND";
            gridView.DataSource = list;
        }
    }
}

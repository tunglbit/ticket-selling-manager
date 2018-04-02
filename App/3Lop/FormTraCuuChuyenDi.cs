using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace _QuanLyBanVeXe
{
    public partial class FormTraCuuChuyenDi : Form
    {
        public FormTraCuuChuyenDi()
        {
            InitializeComponent();
            chuyenDiDB = new ChuyenDiDB();
            dtpThoiGianDau.Format = DateTimePickerFormat.Custom;
            dtpThoiGianDau.CustomFormat = "dd/MM/yyyy";
            dtpThoiGianCuoi.Format = DateTimePickerFormat.Custom;
            dtpThoiGianCuoi.CustomFormat = "dd/MM/yyyy"; 
        }

        private ChuyenDiDB chuyenDiDB;
        List<ChuyenDi> list;

        private void loadComboMaTuyenDi()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2KGQNIN;Initial Catalog=QuanLyBanVeXe;Integrated Security=True");
            //SqlConnection conn = new SqlConnection(@"Data Source=MRLYNK;Initial Catalog=QuanLyBanVeXe;Integrated Security=True");
            conn.Open();
            SqlCommand sc = new SqlCommand("select maTuyenDi from TuyenDi", conn);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Columns.Add("maTuyenDi", typeof(string));
            dt.Load(reader);

            cbbMaTuyenDi.ValueMember = "maTuyenDi";
            cbbMaTuyenDi.DisplayMember = "maTuyenDi";
            cbbMaTuyenDi.DataSource = dt;

            conn.Close();
        }
        private void FormTraCuuChuyenDi_Load(object sender, EventArgs e)
        {
            loadComboMaTuyenDi();
            loadData();
            gridView.ClearSelection();
        }

        private void loadData()
        {
            string maTuyenDi = cbbMaTuyenDi.Text.Trim();
            string thoiGianDau = dtpThoiGianDau.Value.ToString();
            string thoiGianCuoi = dtpThoiGianCuoi.Value.ToString();

            list = chuyenDiDB.selectChuyenDiTheoThoiGian(maTuyenDi, thoiGianDau, thoiGianCuoi);
            gridView.DataSource = list;
        }

        private void gridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int row = e.RowIndex;

            if (row % 2 != 0)
            {
                gridView.Rows[row].DefaultCellStyle.BackColor = Color.Bisque;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

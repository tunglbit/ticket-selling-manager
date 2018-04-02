using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace _QuanLyBanVeXe
{
    public partial class FormNhanLich : Form
    {
        private ChiTietChuyenDiDB chiTietChuyenDiDB;
        List<ChiTietChuyenDi> list;

        public FormNhanLich()
        {
            InitializeComponent();
            chiTietChuyenDiDB = new ChiTietChuyenDiDB();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maChuyenDi = cbbMaChuyenDi.Text.Trim();
            string benXeTrungGian = cbbBenXeTrungGian.Text.Trim();
            int thoiGianDung = Convert.ToInt32(txtThoiGianDung.Text.Trim());
            string ghiChu = txtGhiChu.Text.Trim();

            ChiTietChuyenDi m = new ChiTietChuyenDi(maChuyenDi, benXeTrungGian, thoiGianDung, ghiChu);

            list.Add(m);
            gridView.DataSource = null;
            gridView.DataSource = list;
            addChiTietChuyenDi(m);

        }

        private void addChiTietChuyenDi(ChiTietChuyenDi m)
        {
            try
            {
                bool kq = chiTietChuyenDiDB.add(m);
                if (kq)
                {
                    loadData();
                    ClearInput();
                }
                else
                {
                    MessageBox.Show("Them ko thanh cong");
                }
            }
            catch (Exception e)
            {
                if (e.Message.Contains("UNIQUE"))
                {
                    MessageBox.Show("Email trung lap");
                }
                else
                {
                    MessageBox.Show("Khong the thuc hien duoc: " + e.Message);
                }
            }
        }

        private bool isInputValid()
        {
            String maChuyenDi = cbbMaChuyenDi.Text.Trim();

            if (maChuyenDi.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã chuyến đi");
                cbbMaChuyenDi.Focus();
                return false;
            }

            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
            setEditMode(false);
            gridView.ClearSelection();
            loadComboBenXeTrungGian();
            loadComboMaChuyenDi();
        }

        private void loadComboMaChuyenDi()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2KGQNIN;Initial Catalog=QuanLyBanVeXe;Integrated Security=True");
            //SqlConnection conn = new SqlConnection(@"Data Source=MRLYNK;Initial Catalog=QuanLyBanVeXe;Integrated Security=True");
            conn.Open();
            SqlCommand sc = new SqlCommand("select maChuyenDi from ChuyenDi", conn);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Columns.Add("maChuyenDi", typeof(string));
            dt.Load(reader);

            cbbMaChuyenDi.ValueMember = "maChuyenDi";
            cbbMaChuyenDi.DisplayMember = "maChuyenDi";
            cbbMaChuyenDi.DataSource = dt;

            conn.Close();
        }

        private void loadComboBenXeTrungGian()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2KGQNIN;Initial Catalog=QuanLyBanVeXe;Integrated Security=True");
            //SqlConnection conn = new SqlConnection(@"Data Source=MRLYNK;Initial Catalog=QuanLyBanVeXe;Integrated Security=True");
            conn.Open();
            SqlCommand sc = new SqlCommand("select maBenXe from BenXE", conn);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Columns.Add("maBenXe", typeof(string));
            dt.Load(reader);

            cbbBenXeTrungGian.ValueMember = "maBenXe";
            cbbBenXeTrungGian.DisplayMember = "maBenXe";
            cbbBenXeTrungGian.DataSource = dt;

            conn.Close();
        }

        private void loadData()
        {
            list = chiTietChuyenDiDB.getAll(cbbMaChuyenDi.Text);
            gridView.DataSource = list;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String maChuyenDi = cbbMaChuyenDi.Text;
            String benXeTrungGian = cbbBenXeTrungGian.Text;

            if (maChuyenDi.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã chuyến đi");
                cbbMaChuyenDi.Focus();
                return;
            }

            bool ketQua = chiTietChuyenDiDB.delete(maChuyenDi, benXeTrungGian);

            // thong bao
            if (ketQua)
            {
                MessageBox.Show("Xóa thành công");
                loadData();
            }
            else
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void gridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            if (row < 0 || row >= list.Count)
            {
                return;
            }

            ChiTietChuyenDi c = list[row];
            Display(c);
        }

        private void Display(ChiTietChuyenDi c)
        {
            cbbMaChuyenDi.Text = c.MaChuyenDi;
            cbbBenXeTrungGian.Text = c.BenXeTrungGian;
            txtThoiGianDung.Text = c.ThoiGianDung.ToString();
            txtGhiChu.Text = c.GhiChu;

            setEditMode(true);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
            setEditMode(false);
        }

        private void ClearInput()
        {
            cbbMaChuyenDi.Text = "";
            cbbBenXeTrungGian.Text = "";
            txtThoiGianDung.Text = "";
            txtGhiChu.Text = "";
        }

        private void setEditMode(bool enabled)
        {
            btnAdd.Enabled = !enabled;
            btnDelete.Enabled = enabled;
            btnUpdate.Enabled = enabled;
            btnClear.Enabled = enabled;

            if(!enabled)
            {
                ClearInput();
                AcceptButton = btnAdd;
            }
            else
            {
                AcceptButton = btnUpdate;
            }
        }

        private void gridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int row = e.RowIndex;

            if (row % 2 != 0)
            {
                gridView.Rows[row].DefaultCellStyle.BackColor = Color.Bisque;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!isInputValid())
            {
                return;
            }

            string maChuyenDi = cbbMaChuyenDi.Text.Trim();
            string benXeTrungGian = cbbBenXeTrungGian.Text.Trim();
            int thoiGianDung = Convert.ToInt32(txtThoiGianDung.Text.Trim());
            string ghiChu = txtGhiChu.Text.Trim();

            DialogResult result = MessageBox.Show("Ban co muon cap nhat " + maChuyenDi, "Cap nhat thong tin ", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }

            ChiTietChuyenDi m = new ChiTietChuyenDi(maChuyenDi, benXeTrungGian, thoiGianDung, ghiChu);

            bool ketQua = chiTietChuyenDiDB.update(m);

            // thong bao
            if (ketQua)
            {
                MessageBox.Show("Cap nhat thanh cong");
            }
            else
            {
                MessageBox.Show("Cap nhat ko thanh cong");
            }

            list = chiTietChuyenDiDB.getAll(cbbMaChuyenDi.Text);
            gridView.DataSource = null;
            gridView.DataSource = list;
        }

        private void cbbMaChuyenDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}

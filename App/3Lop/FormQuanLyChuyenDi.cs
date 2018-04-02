using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _QuanLyBanVeXe
{
    public partial class FormQuanLyChuyenDi : Form
    {
        public FormQuanLyChuyenDi()
        {
            InitializeComponent();
            chuyenDiDB = new ChuyenDiDB();
            dtpNgayGio.Format = DateTimePickerFormat.Custom;
            dtpNgayGio.CustomFormat = "dd/MM/yyyy hh:mm:ss"; 
        }

        private ChuyenDiDB chuyenDiDB;
        List<ChuyenDi> list;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maChuyenDi = txtMaChuyenDi.Text.Trim();
            string maTuyenDi = txtMaTuyenDi.Text.Trim();
            DateTime ngayGio = dtpNgayGio.Value;
            int thoiGianDi = Convert.ToInt32(txtThoiGianDi.Text.Trim());
            int soLuongGhe = Convert.ToInt32(txtSoLuongGhe.Text.Trim());

            ChuyenDi m = new ChuyenDi(maChuyenDi, maTuyenDi, ngayGio, thoiGianDi, soLuongGhe);

            list.Add(m);
            gridView.DataSource = null;
            gridView.DataSource = list;
            addChuyenDi(m);

        }

        private void addChuyenDi(ChuyenDi m)
        {
            try
            {
                bool kq = chuyenDiDB.add(m);
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
            String maChuyenDi = txtMaChuyenDi.Text.Trim();

            if (maChuyenDi.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã chuyến đi");
                txtMaChuyenDi.Focus();
                return false;
            }

            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
            setEditMode(false);
            gridView.ClearSelection();
        }

        private void loadData()
        {
            list = chuyenDiDB.getAll();
            gridView.DataSource = list;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String maChuyenDi = txtMaChuyenDi.Text;
            if (maChuyenDi.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã chuyến đi");
                txtMaChuyenDi.Focus();
                return;
            }

            bool ketQua = chuyenDiDB.delete(maChuyenDi);

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

            ChuyenDi c = list[row];
            Display(c);
        }

        private void Display(ChuyenDi c)
        {
            txtMaChuyenDi.Text = c.MaChuyenDi;
            txtMaTuyenDi.Text = c.MaTuyenDi;
            dtpNgayGio.Value = c.NgayGio;
            txtThoiGianDi.Text = c.ThoiGianDi.ToString();
            txtSoLuongGhe.Text = c.SoLuongGhe.ToString();

            setEditMode(true);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
            setEditMode(false);
        }

        private void ClearInput()
        {
            txtMaChuyenDi.Text = "";
            txtMaTuyenDi.Text = "";
            dtpNgayGio.Value = DateTime.Now;
            txtThoiGianDi.Text = "";
            txtSoLuongGhe.Text = "";
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

            string maChuyenDi = txtMaChuyenDi.Text.Trim();
            string maTuyenDi = txtMaTuyenDi.Text.Trim();
            DateTime ngayGio = dtpNgayGio.Value;
            int thoiGianDi = Convert.ToInt32(txtThoiGianDi.Text.Trim());
            int soLuongGhe = Convert.ToInt32(txtSoLuongGhe.Text.Trim());

            DialogResult result = MessageBox.Show("Ban co muon cap nhat " + maChuyenDi, "Cap nhat thong tin ", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }

            ChuyenDi m = new ChuyenDi(maChuyenDi, maTuyenDi, ngayGio, thoiGianDi, soLuongGhe);
            bool ketQua = chuyenDiDB.update(m);

            // thong bao
            if (ketQua)
            {
                MessageBox.Show("Cap nhat thanh cong");
            }
            else
            {
                MessageBox.Show("Cap nhat ko thanh cong");
            }

            list = chuyenDiDB.getAll();
            gridView.DataSource = null;
            gridView.DataSource = list;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _QuanLyBanVeXe
{
    public partial class FormQuyDinhDonGiaVe : Form
    {
        private DonGiaDB DonGiaDB;
        List<DonGia> list;
        public FormQuyDinhDonGiaVe()
        {
            InitializeComponent();
            DonGiaDB = new DonGiaDB();
        }

        private void FormQuyDinhDonGiaVe_Load(object sender, EventArgs e)
        {
            loadData();
            setEditMode(false);
            gridView.ClearSelection();
        }

        private void loadData()
        {
            list = DonGiaDB.getAll();
            gridView.DataSource = list;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maDonGia = txtMaDonGia.Text.Trim();
            string maTuyenDi = txtMaTuyenDi.Text.Trim();
            Decimal gia = Convert.ToDecimal(txtGia.Text.Trim());

            DonGia m = new DonGia(maDonGia, maTuyenDi, gia);

            list.Add(m);
            gridView.DataSource = null;
            gridView.DataSource = list;
            addDonGia(m);
        }

        private void addDonGia(DonGia m)
        {
            try
            {
                bool kq = DonGiaDB.add(m);
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
                    MessageBox.Show("Mã tuyến đi đã tồn tại.");
                }
                else
                {
                    MessageBox.Show("Khong the thuc hien duoc: " + e.Message);
                }
            }
        }

        private bool isInputValid()
        {
            String maDonGia = txtMaDonGia.Text.Trim();

            if (maDonGia.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã đơn giá");
                txtMaDonGia.Focus();
                return false;
            }

            return true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String maDonGia = txtMaDonGia.Text;
            if (maDonGia.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã đơn giá");
                txtMaTuyenDi.Focus();
                return;
            }

            bool ketQua = DonGiaDB.delete(maDonGia);

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

            DonGia c = list[row];
            Display(c);
        }

        private void Display(DonGia c)
        {
            txtMaDonGia.Text = c.MaDonGia;
            txtMaTuyenDi.Text = c.MaTuyenDi;
            txtGia.Text = c.Gia.ToString();

            setEditMode(true);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!isInputValid())
            {
                return;
            }

            string maDonGia = txtMaDonGia.Text.Trim();
            string maTuyenDi = txtMaTuyenDi.Text.Trim();
            Decimal gia = Convert.ToDecimal(txtGia.Text.Trim());

            DialogResult result = MessageBox.Show("Ban co muon cap nhat " + maDonGia, "Cap nhat thong tin ", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }

            DonGia m = new DonGia(maDonGia, maTuyenDi, gia);
            bool ketQua = DonGiaDB.update(m);

            // thong bao
            if (ketQua)
            {
                MessageBox.Show("Cap nhat thanh cong");
            }
            else
            {
                MessageBox.Show("Cap nhat ko thanh cong");
            }

            list = DonGiaDB.getAll();
            gridView.DataSource = null;
            gridView.DataSource = list;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
            setEditMode(false);
        }

        private void ClearInput()
        {
            txtMaDonGia.Text = "";
            txtMaTuyenDi.Text = "";
            txtGia.Text = "";
        }

        private void setEditMode(bool enabled)
        {
            btnAdd.Enabled = !enabled;
            btnDelete.Enabled = enabled;
            btnUpdate.Enabled = enabled;
            btnClear.Enabled = enabled;

            if (!enabled)
            {
                ClearInput();
                AcceptButton = btnAdd;
            }
            else
            {
                AcceptButton = btnUpdate;
            }
        }
    }
}

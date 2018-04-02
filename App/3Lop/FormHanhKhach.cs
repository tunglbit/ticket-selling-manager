using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _QuanLyBanVeXe
{
    public partial class FormHanhKhach : Form
    {
        private HanhKhachDB hanhKhachDB;
        List<HanhKhach> list;

        public FormHanhKhach()
        {
            InitializeComponent();
            hanhKhachDB = new HanhKhachDB();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maHanhKhach = txtMaHanhKhach.Text.Trim();
            string tenHanhKhach = txtTenHanhKhach.Text.Trim();
            string cmnd = txtCmnd.Text.Trim();
            string dienThoai = txtDienThoai.Text.Trim();

            HanhKhach m = new HanhKhach(maHanhKhach, tenHanhKhach, cmnd, dienThoai);

            list.Add(m);
            gridView.DataSource = null;
            gridView.DataSource = list;
            addHanhKhach(m);

        }

        private void addHanhKhach(HanhKhach m)
        {
            try
            {
                bool kq = hanhKhachDB.add(m);
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
                MessageBox.Show("Khong the thuc hien duoc: " + e.Message);
            }
        }

        private bool isInputValid()
        {
            String maHanhKhach = txtMaHanhKhach.Text.Trim();

            if (maHanhKhach.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã hành khách");
                txtMaHanhKhach.Focus();
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
            list = hanhKhachDB.getAll();
            gridView.DataSource = list;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String maHanhKhach = txtMaHanhKhach.Text;
            if (maHanhKhach.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã hành khách");
                txtMaHanhKhach.Focus();
                return;
            }

            bool ketQua = hanhKhachDB.delete(maHanhKhach);

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

            HanhKhach c = list[row];
            Display(c);
        }

        private void Display(HanhKhach c)
        {
            txtMaHanhKhach.Text = c.MaHanhKhach;
            txtTenHanhKhach.Text = c.TenHanhKhach;
            txtCmnd.Text = c.Cmnd;
            txtDienThoai.Text = c.DienThoai;

            setEditMode(true);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
            setEditMode(false);
        }

        private void ClearInput()
        {
            txtMaHanhKhach.Text = "";
            txtTenHanhKhach.Text = "";
            txtCmnd.Text = "";
            txtDienThoai.Text = "";
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

            string maHanhKhach = txtMaHanhKhach.Text.Trim();
            string tenHanhKhach = txtTenHanhKhach.Text.Trim();
            string cmnd = txtCmnd.Text.Trim();
            string dienThoai = txtDienThoai.Text.Trim();

            DialogResult result = MessageBox.Show("Ban co muon cap nhat " + maHanhKhach, "Cap nhat thong tin ", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }

            HanhKhach m = new HanhKhach(maHanhKhach, tenHanhKhach, cmnd, dienThoai);
            bool ketQua = hanhKhachDB.update(m);

            // thong bao
            if (ketQua)
            {
                MessageBox.Show("Cap nhat thanh cong");
            }
            else
            {
                MessageBox.Show("Cap nhat ko thanh cong");
            }

            list = hanhKhachDB.getAll();
            gridView.DataSource = null;
            gridView.DataSource = list;
        }
    }
}

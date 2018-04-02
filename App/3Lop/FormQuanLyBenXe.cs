using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _QuanLyBanVeXe
{
    public partial class FormQuanLyBenXe : Form
    {
        private BenXeDB BenXeDB;
        List<BenXe> list;

        public FormQuanLyBenXe()
        {
            InitializeComponent();
            BenXeDB = new BenXeDB();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maBenXe = txtMaBenXe.Text.Trim();
            string tenBenXe = txtTenBenXe.Text.Trim();

            BenXe m = new BenXe(maBenXe, tenBenXe);

            list.Add(m);
            gridView.DataSource = null;
            gridView.DataSource = list;
            addBenXe(m);

        }

        private void addBenXe(BenXe m)
        {
            try
            {
                bool kq = BenXeDB.add(m);
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
            String maBenXe = txtMaBenXe.Text.Trim();

            if (maBenXe.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã bến xe");
                txtMaBenXe.Focus();
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
            list = BenXeDB.getAll();
            gridView.DataSource = list;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String maBenXe = txtMaBenXe.Text;
            if (maBenXe.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã bến xe");
                txtMaBenXe.Focus();
                return;
            }

            bool ketQua = BenXeDB.delete(maBenXe);

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

            BenXe c = list[row];
            Display(c);
        }

        private void Display(BenXe c)
        {
            txtMaBenXe.Text = c.MaBenXe;
            txtTenBenXe.Text = c.TenBenXe;

            setEditMode(true);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
            setEditMode(false);
        }

        private void ClearInput()
        {
            txtMaBenXe.Text = "";
            txtTenBenXe.Text = "";
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

            string maBenXe = txtMaBenXe.Text.Trim();
            string tenBenXe = txtTenBenXe.Text.Trim();

            DialogResult result = MessageBox.Show("Ban co muon cap nhat " + maBenXe, "Cap nhat thong tin ", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }

            BenXe m = new BenXe(maBenXe, tenBenXe);
            bool ketQua = BenXeDB.update(m);

            // thong bao
            if (ketQua)
            {
                MessageBox.Show("Cap nhat thanh cong");
            }
            else
            {
                MessageBox.Show("Cap nhat ko thanh cong");
            }

            list = BenXeDB.getAll();
            gridView.DataSource = null;
            gridView.DataSource = list;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _QuanLyBanVeXe
{
    public partial class FormQuanLyTuyenDi : Form
    {
        private TuyenDiDB TuyenDiDB;
        List<TuyenDi> list;

        public FormQuanLyTuyenDi()
        {
            InitializeComponent();
            TuyenDiDB = new TuyenDiDB();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maTuyenDi = txtMaTuyenDi.Text.Trim();
            string benXeDi = txtBenXeDi.Text.Trim();
            string benXeDen = txtBenXeDen.Text.Trim();

            TuyenDi m = new TuyenDi(maTuyenDi, benXeDi, benXeDen);

            list.Add(m);
            gridView.DataSource = null;
            gridView.DataSource = list;
            addTuyenDi(m);

        }

        private void addTuyenDi(TuyenDi m)
        {
            try
            {
                bool kq = TuyenDiDB.add(m);
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
            String maTuyenDi = txtMaTuyenDi.Text.Trim();

            if (maTuyenDi.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã tuyến đi");
                txtMaTuyenDi.Focus();
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
            list = TuyenDiDB.getAll();
            gridView.DataSource = list;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String maTuyenDi = txtMaTuyenDi.Text;
            if (maTuyenDi.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã tuyến đi");
                txtMaTuyenDi.Focus();
                return;
            }

            bool ketQua = TuyenDiDB.delete(maTuyenDi);

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

            TuyenDi c = list[row];
            Display(c);
        }

        private void Display(TuyenDi c)
        {
            txtMaTuyenDi.Text = c.MaTuyenDi;
            txtBenXeDi.Text = c.BenXeDi;
            txtBenXeDen.Text = c.BenXeDen;

            setEditMode(true);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
            setEditMode(false);
        }

        private void ClearInput()
        {
            txtMaTuyenDi.Text = "";
            txtBenXeDi.Text = "";
            txtBenXeDen.Text = "";
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

            string maTuyenDi = txtMaTuyenDi.Text.Trim();
            string benXeDi = txtBenXeDi.Text.Trim();
            string benXeDen = txtBenXeDen.Text.Trim();

            DialogResult result = MessageBox.Show("Ban co muon cap nhat " + maTuyenDi, "Cap nhat thong tin ", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }

            TuyenDi m = new TuyenDi(maTuyenDi, benXeDi, benXeDen);
            bool ketQua = TuyenDiDB.update(m);

            // thong bao
            if (ketQua)
            {
                MessageBox.Show("Cap nhat thanh cong");
            }
            else
            {
                MessageBox.Show("Cap nhat ko thanh cong");
            }

            list = TuyenDiDB.getAll();
            gridView.DataSource = null;
            gridView.DataSource = list;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _QuanLyBanVeXe
{
    public partial class FormQuyDinhHanDatVe : Form
    {
        private ThamSoDB ThamSoDB;
        List<ThamSo> list;

        public FormQuyDinhHanDatVe()
        {
            InitializeComponent();
            ThamSoDB = new ThamSoDB();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isInputValid())
            {
                return;
            }
            int thoiGianDatVeChamNhat = Convert.ToInt32(txtThoiGianDatVeChamNhat.Text.Trim());
            int thoiGianHuyDatVeChamNhat = Convert.ToInt32(txtThoiGianHuyDatVeChamNhat.Text.Trim());

            DialogResult result = MessageBox.Show("Ban co chac muon cap nhat", "Cap nhat thong tin", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }

            ThamSo m = new ThamSo(thoiGianDatVeChamNhat, thoiGianHuyDatVeChamNhat);
            bool ketQua = ThamSoDB.updateHanDatVe(m);

            // thong bao
            if (ketQua)
            {
                MessageBox.Show("Cap nhat thanh cong");
            }
            else
            {
                MessageBox.Show("Cap nhat ko thanh cong");
            }

            list = ThamSoDB.getAll();
            ThamSo c = list[0];
            txtThoiGianDatVeChamNhat.Text = c.ThoiGianDatVeChamNhat.ToString();
            txtThoiGianHuyDatVeChamNhat.Text = c.ThoiGianHuyDatVeChamNhat.ToString();
        }

        private void FormQuyDinhHanDatVe_Load(object sender, EventArgs e)
        {
            list = ThamSoDB.getAll();
            ThamSo c = list[0];
            txtThoiGianDatVeChamNhat.Text = c.ThoiGianDatVeChamNhat.ToString();
            txtThoiGianHuyDatVeChamNhat.Text = c.ThoiGianHuyDatVeChamNhat.ToString();
        }

        private bool isInputValid()
        {
            String thoiGianDatVeChamNhat = txtThoiGianDatVeChamNhat.Text.Trim();
            String thoiGianHuyDatVeChamNhat = txtThoiGianHuyDatVeChamNhat.Text.Trim();

            if (thoiGianDatVeChamNhat.Length == 0 || thoiGianHuyDatVeChamNhat.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                txtThoiGianDatVeChamNhat.Focus();
                return false;
            }

            return true;
        }
    }
}

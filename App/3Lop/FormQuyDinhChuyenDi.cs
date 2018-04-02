using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _QuanLyBanVeXe
{
    public partial class FormQuyDinhChuyenDi : Form
    {
        private ThamSoDB ThamSoDB;
        List<ThamSo> list;

        public FormQuyDinhChuyenDi()
        {
            InitializeComponent();
            ThamSoDB = new ThamSoDB();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!isInputValid())
            {
                return;
            }
            int thoiGianDiToiThieu = Convert.ToInt32(txtThoiGianDiToiThieu.Text.Trim());
            int soBenXeTrungGianToiDa = Convert.ToInt32(txtSoBenXeTrungGianToiDa.Text.Trim());
            int thoiGianDungToiThieu = Convert.ToInt32(txtThoiGianDungToiThieu.Text.Trim());
            int thoiGianDungToiDa = Convert.ToInt32(txtThoiGianDungToiDa.Text.Trim());

            DialogResult result = MessageBox.Show("Ban co chac muon cap nhat", "Cap nhat thong tin", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }

            ThamSo m = new ThamSo(thoiGianDiToiThieu, soBenXeTrungGianToiDa, thoiGianDungToiThieu, thoiGianDungToiDa);
            bool ketQua = ThamSoDB.updateChuyenDi(m);

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
            txtThoiGianDiToiThieu.Text = c.ThoiGianDiToiThieu.ToString();
            txtSoBenXeTrungGianToiDa.Text = c.SoBenXeTrungGianToiDa.ToString();
            txtThoiGianDungToiThieu.Text = c.ThoiGianDungToiThieu.ToString();
            txtThoiGianDungToiDa.Text = c.ThoiGianDungToiDa.ToString();
        }

        private void FormQuyDinhChuyenDi_Load(object sender, EventArgs e)
        {
            list = ThamSoDB.getAll();
            ThamSo c = list[0];
            txtThoiGianDiToiThieu.Text = c.ThoiGianDiToiThieu.ToString();
            txtSoBenXeTrungGianToiDa.Text = c.SoBenXeTrungGianToiDa.ToString();
            txtThoiGianDungToiThieu.Text = c.ThoiGianDungToiThieu.ToString();
            txtThoiGianDungToiDa.Text = c.ThoiGianDungToiDa.ToString();
        }

        private bool isInputValid()
        {
            String thoiGianDiToiThieu = txtThoiGianDiToiThieu.Text.Trim();
            String soBenXeTrungGianToiDa = txtSoBenXeTrungGianToiDa.Text.Trim();
            String thoiGianDungToiThieu = txtThoiGianDungToiThieu.Text.Trim();
            String thoiGianDungToiDa = txtThoiGianDungToiDa.Text.Trim();

            if (thoiGianDiToiThieu.Length == 0 || soBenXeTrungGianToiDa.Length == 0 || thoiGianDungToiThieu.Length == 0 || thoiGianDungToiDa.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                txtThoiGianDiToiThieu.Focus();
                return false;
            }

            return true;
        }
    }
}

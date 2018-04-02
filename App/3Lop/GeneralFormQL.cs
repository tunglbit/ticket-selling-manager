using System;
using System.Windows.Forms;

namespace _QuanLyBanVeXe
{
    public partial class GeneralFormQL : Form
    {
        public GeneralFormQL()
        {
            InitializeComponent();
        }

        private void btnQuanLyTuyenDi_Click(object sender, EventArgs e)
        {
            FormQuanLyTuyenDi formQuanLyTuyenDi = new FormQuanLyTuyenDi();
            formQuanLyTuyenDi.Show();
        }

        private void btnQuanLyBenXe_Click(object sender, EventArgs e)
        {
            FormQuanLyBenXe formQuanLyBenXe = new FormQuanLyBenXe();
            formQuanLyBenXe.Show();
        }

        private void btnQuanLyChuyenDi_Click(object sender, EventArgs e)
        {
            FormQuanLyChuyenDi formQuanLyChuyenDi = new FormQuanLyChuyenDi();
            formQuanLyChuyenDi.Show();
        }

        private void btnQuyDinhChuyenDi_Click(object sender, EventArgs e)
        {
            FormQuyDinhChuyenDi formQuyDinhChuyenDi = new FormQuyDinhChuyenDi();
            formQuyDinhChuyenDi.Show();
        }

        private void btnQuyDinhHanDatVe_Click(object sender, EventArgs e)
        {
            FormQuyDinhHanDatVe formQuyDinhHanDatVe = new FormQuyDinhHanDatVe();
            formQuyDinhHanDatVe.Show();
        }

        private void btnQuyDinhDonGiaVe_Click(object sender, EventArgs e)
        {
            FormQuyDinhDonGiaVe formQuyDinhDonGiaVe = new FormQuyDinhDonGiaVe();
            formQuyDinhDonGiaVe.Show();
        }

        private void GeneralFormQL_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 1)
                Application.Exit();
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            FormXemBaoCao formXemBaoCao = new FormXemBaoCao();
            formXemBaoCao.Show();
        }
    }
}

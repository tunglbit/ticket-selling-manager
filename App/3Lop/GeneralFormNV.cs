using System;
using System.Windows.Forms;

namespace _QuanLyBanVeXe
{
    public partial class GeneralFormNV : Form
    {
        public GeneralFormNV()
        {
            InitializeComponent();
        }

        private void btnNhanLich_Click(object sender, EventArgs e)
        {
            FormNhanLich formNhanLich = new FormNhanLich();
            formNhanLich.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDatVe formDatVe = new FormDatVe();
            formDatVe.Show();
        }

        private void btnBanVe_Click(object sender, EventArgs e)
        {
            FormBanVe formBanVe = new FormBanVe();
            formBanVe.Show();
        }


        private void GeneralFormNV_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 1)
                Application.Exit();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            FormTraCuuChuyenDi formTraCuuChuyenDi = new FormTraCuuChuyenDi();
            formTraCuuChuyenDi.Show();
        }
    }
}

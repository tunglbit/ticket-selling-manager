using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _QuanLyBanVeXe
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isQL = true;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2KGQNIN;Initial Catalog=QuanLyBanVeXe;Integrated Security=True");
            //SqlConnection conn = new SqlConnection(@"Data Source=MRLYNK;Initial Catalog=QuanLyBanVeXe;Integrated Security=True");
            string query = "select * from ACCOUNT where username = '" + txtUsername.Text.Trim() 
                + "' and password = '" + txtPassword.Text.Trim() + "'";
            if (txtUsername.Text.Trim() != "QuanLy")
                isQL = false;
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                if (isQL)
                {
                    GeneralFormQL generalForm = new GeneralFormQL();
                    Hide();
                    generalForm.Show();
                }
                else
                {
                    GeneralFormNV generalForm = new GeneralFormNV();
                    Hide();
                    generalForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Username hoặc Password sai");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

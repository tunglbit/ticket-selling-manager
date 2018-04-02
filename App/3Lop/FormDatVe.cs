﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _QuanLyBanVeXe
{
    public partial class FormDatVe : Form
    {
        private PhieuDatChoDB phieuDatChoDB;

        public FormDatVe()
        {
            InitializeComponent();
            phieuDatChoDB = new PhieuDatChoDB();
            dtpNgayDat.Format = DateTimePickerFormat.Custom;
            dtpNgayDat.CustomFormat = "dd/MM/yyyy hh:mm:ss"; 
        }

        private void FormDatVe_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2KGQNIN;Initial Catalog=QuanLyBanVeXe;Integrated Security=True");
            //SqlConnection conn = new SqlConnection(@"Data Source=MRLYNK;Initial Catalog=QuanLyBanVeXe;Integrated Security=True");
            conn.Open();
            SqlCommand sc = new SqlCommand("select maChuyenDi from ChuyenDi", conn);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Columns.Add("maChuyenDi", typeof(string));
            dt.Load(reader);

            cbbMaChuyenDi.ValueMember = "maChuyenDi";
            cbbMaChuyenDi.DisplayMember = "maChuyenDi";
            cbbMaChuyenDi.DataSource = dt;

            conn.Close();

            loadComboMaKhachHang();
        }

        private void loadComboMaKhachHang()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2KGQNIN;Initial Catalog=QuanLyBanVeXe;Integrated Security=True");
            //SqlConnection conn = new SqlConnection(@"Data Source=MRLYNK;Initial Catalog=QuanLyBanVeXe;Integrated Security=True");
            conn.Open();
            SqlCommand sc = new SqlCommand("select maHanhKhach from HanhKhach", conn);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Columns.Add("maHanhKhach", typeof(string));
            dt.Load(reader);

            cbbMaHanhKhach.ValueMember = "maHanhKhach";
            cbbMaHanhKhach.DisplayMember = "maHanhKhach";
            cbbMaHanhKhach.DataSource = dt;

            conn.Close();
        }

        private void cbbMaChuyenDi_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2KGQNIN;Initial Catalog=QuanLyBanVeXe;Integrated Security=True");
            //SqlConnection conn = new SqlConnection(@"Data Source=MRLYNK;Initial Catalog=QuanLyBanVeXe;Integrated Security=True");
            conn.Open();
            SqlCommand sc = new SqlCommand("select Gia from DONGIA where MaTuyenDi = (select MaTuyenDi from CHUYENDI where MaChuyenDi = '" +
                                           cbbMaChuyenDi.Text + "')", conn);
            object result = sc.ExecuteScalar();
            if(result != null)
                txtGiaTien.Text = result.ToString();

            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lblSoGheTrong.Text == "0")
            {
                MessageBox.Show("Đã hết vé! Không thể thêm");
                return;
            }

            string maPhieuDatCho = txtMaPhieuDatCho.Text.Trim();
            string maChuyenDi = cbbMaChuyenDi.Text.Trim();
            string maHanhKhach = cbbMaHanhKhach.Text.Trim();
            decimal giaTien = Convert.ToDecimal(txtGiaTien.Text.Trim());
            DateTime ngayDat = dtpNgayDat.Value;

            PhieuDatCho m = new PhieuDatCho(maPhieuDatCho, maChuyenDi, maHanhKhach, giaTien, ngayDat);

            addPhieuDatCho(m);

        }

        private void addPhieuDatCho(PhieuDatCho m)
        {
            try
            {
                if (!isInputValid())
                {
                    return;
                }

                bool kq = phieuDatChoDB.add(m);
                if (kq)
                {
                    ClearInput();
                    MessageBox.Show("Them thanh cong");
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
            String maPhieuDatCho = txtMaPhieuDatCho.Text.Trim();

            if (maPhieuDatCho.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã phiếu đặt chỗ");
                txtMaPhieuDatCho.Focus();
                return false;
            }

            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void ClearInput()
        {
            txtMaPhieuDatCho.Text = "";
            cbbMaChuyenDi.Text = "";
            cbbMaHanhKhach.Text = "";
            txtGiaTien.Text = "";
            dtpNgayDat.Value = DateTime.Now;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormHanhKhach formHanhKhach = new FormHanhKhach();
            formHanhKhach.Show();
            loadComboMaKhachHang();
        }

        private void cbbMaChuyenDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2KGQNIN;Initial Catalog=QuanLyBanVeXe;Integrated Security=True");
            //SqlConnection conn = new SqlConnection(@"Data Source=MRLYNK;Initial Catalog=QuanLyBanVeXe;Integrated Security=True");
            conn.Open();

            SqlCommand sc2 = new SqlCommand("select COUNT (*) from VEXE where MaChuyenDi = '" +
                                           cbbMaChuyenDi.Text + "'", conn);
            int soVeXe = Convert.ToInt32(sc2.ExecuteScalar().ToString());
            SqlCommand sc3 = new SqlCommand("select COUNT (*) from PhieuDatCho where MaChuyenDi = '" +
                                           cbbMaChuyenDi.Text + "'", conn);
            int soPhieuDatCho = Convert.ToInt32(sc3.ExecuteScalar().ToString());

            SqlCommand sc4 = new SqlCommand("select soLuongGhe from ChuyenDi where MaChuyenDi = '" +
                                           cbbMaChuyenDi.Text + "'", conn);
            int soLuongGhe = Convert.ToInt32(sc4.ExecuteScalar().ToString());

            lblSoGheTrong.Text = (soLuongGhe - soVeXe - soPhieuDatCho).ToString();

            conn.Close();
        }
    }
}

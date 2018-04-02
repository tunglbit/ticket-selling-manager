using System;

namespace _QuanLyBanVeXe
{
    public class DonGia
    {
        private string maDonGia;

        public string MaDonGia
        {
            get { return maDonGia; }
            set { maDonGia = value; }
        }

        private string maTuyenDi;

        public string MaTuyenDi
        {
            get { return maTuyenDi; }
            set { maTuyenDi = value; }
        }

        private Decimal gia;

        public Decimal Gia
        {
            get { return gia; }
            set { gia = value; }
        }

        public DonGia(string maDonGia, string maTuyenDi, Decimal gia)
        {
            this.maDonGia = maDonGia;
            this.maTuyenDi = maTuyenDi;
            this.gia = gia;
        }

    }
}

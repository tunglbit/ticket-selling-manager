using System;

namespace _QuanLyBanVeXe
{
    public class ChuyenDi
    {
        private string maChuyenDi;

        public string MaChuyenDi
        {
            get { return maChuyenDi; }
            set { maChuyenDi = value; }
        }
        private string maTuyenDi;

        public string MaTuyenDi
        {
            get { return maTuyenDi; }
            set { maTuyenDi = value; }
        }
        private DateTime ngayGio;

        public DateTime NgayGio
        {
            get { return ngayGio; }
            set { ngayGio = value; }
        }
        private int thoiGianDi;

        public int ThoiGianDi
        {
            get { return thoiGianDi; }
            set { thoiGianDi = value; }
        }
        private int soLuongGhe;

        public int SoLuongGhe
        {
            get { return soLuongGhe; }
            set { soLuongGhe = value; }
        }

        public ChuyenDi(string maChuyenDi, string maTuyenDi, DateTime ngayGio, int thoiGianDi, int soLuongGhe)
        {
            this.maChuyenDi = maChuyenDi;
            this.maTuyenDi = maTuyenDi;
            this.ngayGio = ngayGio;
            this.thoiGianDi = thoiGianDi;
            this.soLuongGhe = soLuongGhe;
        }
    }
}

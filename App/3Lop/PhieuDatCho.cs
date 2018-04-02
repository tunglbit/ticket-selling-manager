using System;

namespace _QuanLyBanVeXe
{
    public class PhieuDatCho
    {
        private string maPhieuDatCho;

        public string MaPhieuDatCho
        {
            get { return maPhieuDatCho; }
            set { maPhieuDatCho = value; }
        }
        private string maChuyenDi;

        public string MaChuyenDi
        {
            get { return maChuyenDi; }
            set { maChuyenDi = value; }
        }
        private string maHanhKhach;

        public string MaHanhKhach
        {
            get { return maHanhKhach; }
            set { maHanhKhach = value; }
        }
        private DateTime ngayDat;

        public DateTime NgayDat
        {
            get { return ngayDat; }
            set { ngayDat = value; }
        }

        private decimal giaTien;

        public decimal GiaTien
        {
            get { return giaTien; }
            set { giaTien = value; }
        }
        public PhieuDatCho(string maPhieuDatCho, string maChuyenDi, string maHanhKhach, decimal giaTien, DateTime ngayDat)
        {
            this.maPhieuDatCho = maPhieuDatCho;
            this.maChuyenDi = maChuyenDi;
            this.maHanhKhach = maHanhKhach;       
            this.giaTien = giaTien;
            this.ngayDat = ngayDat;
        }
    }
}

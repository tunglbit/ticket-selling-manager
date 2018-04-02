

namespace _QuanLyBanVeXe
{
    public class VeXe
    {
        private string maVeXe;

        public string MaVeXe
        {
            get { return maVeXe; }
            set { maVeXe = value; }
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
        private decimal giaTien;

        public decimal GiaTien
        {
            get { return giaTien; }
            set { giaTien = value; }
        }

        public VeXe(string maVeXe, string maChuyenDi, string maHanhKhach, decimal giaTien)
        {
            this.maVeXe = maVeXe;
            this.maChuyenDi = maChuyenDi;
            this.maHanhKhach = maHanhKhach;
            this.giaTien = giaTien;
        }
    }
}

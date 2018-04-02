

namespace _QuanLyBanVeXe
{
    class DoanhThuThang
    {
        private string maChuyenDi;

        public string MaChuyenDi
        {
            get { return maChuyenDi; }
            set { maChuyenDi = value; }
        }

        private int soVe;

        public int SoVe
        {
            get { return soVe; }
            set { soVe = value; }
        }

        private decimal doanhThu;

        public decimal DoanhThu
        {
            get { return doanhThu; }
            set { doanhThu = value; }
        }

        public DoanhThuThang(string maChuyenDi, int soVe, decimal doanhThu)
        {
            this.maChuyenDi = maChuyenDi;
            this.soVe = soVe;
            this.doanhThu = doanhThu;
        }
    }
}

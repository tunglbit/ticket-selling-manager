

namespace _QuanLyBanVeXe
{
    public class ChiTietChuyenDi
    {
        private string maChuyenDi;

        public string MaChuyenDi
        {
            get { return maChuyenDi; }
            set { maChuyenDi = value; }
        }
        private string benXeTrungGian;

        public string BenXeTrungGian
        {
            get { return benXeTrungGian; }
            set { benXeTrungGian = value; }
        }
        private int thoiGianDung;

        public int ThoiGianDung
        {
            get { return thoiGianDung; }
            set { thoiGianDung = value; }
        }
        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

        public ChiTietChuyenDi(string maChuyenDi, string benXeTrungGian, int thoiGianDung, string ghiChu)
        {
            this.maChuyenDi = maChuyenDi;
            this.benXeTrungGian = benXeTrungGian;
            this.thoiGianDung = thoiGianDung;
            this.ghiChu = ghiChu;
        }
    }
}

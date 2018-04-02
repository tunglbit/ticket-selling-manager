

namespace _QuanLyBanVeXe
{
    public class HanhKhach
    {
        private string maHanhKhach;

        public string MaHanhKhach
        {
            get { return maHanhKhach; }
            set { maHanhKhach = value; }
        }
        private string tenHanhKhach;

        public string TenHanhKhach
        {
            get { return tenHanhKhach; }
            set { tenHanhKhach = value; }
        }
        private string cmnd;

        public string Cmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }
        private string dienThoai;

        public string DienThoai
        {
            get { return dienThoai; }
            set { dienThoai = value; }
        }

        public HanhKhach(string maHanhKhach, string tenHanhKhach, string cmnd, string dienThoai)
        {
            this.maHanhKhach = maHanhKhach;
            this.tenHanhKhach = tenHanhKhach;
            this.cmnd = cmnd;
            this.dienThoai = dienThoai;
        }
    }
}

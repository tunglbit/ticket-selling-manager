

namespace _QuanLyBanVeXe
{
    class ThamSo
    {
        private int thoiGianDiToiThieu;

        public int ThoiGianDiToiThieu
        {
            get { return thoiGianDiToiThieu; }
            set { thoiGianDiToiThieu = value; }
        }
        private int soBenXeTrungGianToiDa;

        public int SoBenXeTrungGianToiDa
        {
            get { return soBenXeTrungGianToiDa; }
            set { soBenXeTrungGianToiDa = value; }
        }

        private int thoiGianDungToiThieu;

        public int ThoiGianDungToiThieu
        {
            get { return thoiGianDungToiThieu; }
            set { thoiGianDungToiThieu = value; }
        }

        private int thoiGianDungToiDa;

        public int ThoiGianDungToiDa
        {
            get { return thoiGianDungToiDa; }
            set { thoiGianDungToiDa = value; }
        }
        private int thoiGianDatVeChamNhat;

        public int ThoiGianDatVeChamNhat
        {
            get { return thoiGianDatVeChamNhat; }
            set { thoiGianDatVeChamNhat = value; }
        }

        private int thoiGianHuyDatVeChamNhat;

        public int ThoiGianHuyDatVeChamNhat
        {
            get { return thoiGianHuyDatVeChamNhat; }
            set { thoiGianHuyDatVeChamNhat = value; }
        }
        public ThamSo(int thoiGianDiToiThieu, int soBenXeTrungGianToiDa, int thoiGianDungToiThieu, int thoiGianDungToiDa)
        {
            this.thoiGianDiToiThieu = thoiGianDiToiThieu;
            this.soBenXeTrungGianToiDa = soBenXeTrungGianToiDa;
            this.thoiGianDungToiThieu = thoiGianDungToiThieu;
            this.thoiGianDungToiDa = thoiGianDungToiDa;
        }

        public ThamSo(int thoiGianDatVeChamNhat, int thoiGianHuyDatVeChamNhat)
        {
            this.thoiGianDatVeChamNhat = thoiGianDatVeChamNhat;
            this.thoiGianHuyDatVeChamNhat = thoiGianHuyDatVeChamNhat;
        }

        public ThamSo(int thoiGianDiToiThieu, int soBenXeTrungGianToiDa, int thoiGianDungToiThieu, int thoiGianDungToiDa, int thoiGianDatVeChamNhat, int thoiGianHuyDatVeChamNhat)
        {
            this.thoiGianDiToiThieu = thoiGianDiToiThieu;
            this.soBenXeTrungGianToiDa = soBenXeTrungGianToiDa;
            this.thoiGianDungToiThieu = thoiGianDungToiThieu;
            this.thoiGianDungToiDa = thoiGianDungToiDa;
            this.thoiGianDatVeChamNhat = thoiGianDatVeChamNhat;
            this.thoiGianHuyDatVeChamNhat = thoiGianHuyDatVeChamNhat;
        }

    }
}

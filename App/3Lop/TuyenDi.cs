

namespace _QuanLyBanVeXe
{
    public class TuyenDi
    {
        private string maTuyenDi;

        public string MaTuyenDi
        {
            get { return maTuyenDi; }
            set { maTuyenDi = value; }
        }
        private string benXeDi;

        public string BenXeDi
        {
            get { return benXeDi; }
            set { benXeDi = value; }
        }
        private string benXeDen;

        public string BenXeDen
        {
            get { return benXeDen; }
            set { benXeDen = value; }
        }

        public TuyenDi(string maTuyenDi, string benXeDi, string benXeDen)
        {
            this.maTuyenDi = maTuyenDi;
            this.benXeDi = benXeDi;
            this.benXeDen = benXeDen;
        }

    }
}



namespace _QuanLyBanVeXe
{
    public class BenXe
    {
        private string maBenXe;

        public string MaBenXe
        {
            get { return maBenXe; }
            set { maBenXe = value; }
        }
        private string tenBenXe;

        public string TenBenXe
        {
            get { return tenBenXe; }
            set { tenBenXe = value; }
        }

        public BenXe(string maBenXe, string tenBenXe)
        {
            this.maBenXe = maBenXe;
            this.tenBenXe = tenBenXe;
        }

    }
}

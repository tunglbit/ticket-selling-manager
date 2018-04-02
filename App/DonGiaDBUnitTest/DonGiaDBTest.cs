using Microsoft.VisualStudio.TestTools.UnitTesting;
using _QuanLyBanVeXe;

namespace DonGiaDBUnitTest
{
    [TestClass]
    public class DonGiaDBTest
    {
        TuyenDiDB tDManager = new TuyenDiDB();
        DonGiaDB manager = new DonGiaDB();

        [TestMethod]
        public void TestAddAndDelete()
        {
            TuyenDi td1 = new TuyenDi("BL-HCM", "BL", "HCM");
            tDManager.add(td1);

            DonGia t1 = new DonGia("DG07", "BL-HCM", 210000);

            Assert.AreEqual(true, manager.add(t1));
            Assert.AreEqual(false, manager.add(t1));
            Assert.AreEqual(true, manager.delete("DG07"));

            tDManager.delete("BL-HCM");
        }

        [TestMethod]
        public void TestUpdate()
        {
            TuyenDi td1 = new TuyenDi("BL-HCM", "BL", "HCM");
            tDManager.add(td1);

            DonGia t1 = new DonGia("DG07", "BL-HCM", 210000);
            manager.add(t1);

            DonGia t2 = new DonGia("DG07", "BL-HCM", 220000);

            Assert.AreEqual(true, manager.update(t2));
            Assert.AreEqual(true, manager.update(t1));
            Assert.AreEqual(true, manager.delete("DG07"));

            tDManager.delete("BL-HCM");
        }
    }
}

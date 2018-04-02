using Microsoft.VisualStudio.TestTools.UnitTesting;
using _QuanLyBanVeXe;

namespace ChiTietChuyenDiDBUnitTest
{
    [TestClass]
    public class ChiTietChuyenDiDBTest
    {
        ChiTietChuyenDiDB manager = new ChiTietChuyenDiDB();

        [TestMethod]
        public void TestAddAndDelete()
        {
            ChiTietChuyenDi t1 = new ChiTietChuyenDi("HN-HCM-001", "BH", 20, "Do xang xe");

            Assert.AreEqual(true, manager.add(t1));
            Assert.AreEqual(false, manager.add(t1));

            Assert.AreEqual(true, manager.delete("HN-HCM-001", "BH"));
        }

        [TestMethod]
        public void TestUpdate()
        {
            ChiTietChuyenDi t1 = new ChiTietChuyenDi("HN-HCM-001", "BH", 20, "Do xang xe");
            manager.add(t1);

            ChiTietChuyenDi t2 = new ChiTietChuyenDi("HN-HCM-001", "BH", 30, "Do xang xe va an uong");

            Assert.AreEqual(true, manager.update(t2));
            Assert.AreEqual(true, manager.update(t1));
            Assert.AreEqual(true, manager.delete("HN-HCM-001", "BH"));
        }
    }
}

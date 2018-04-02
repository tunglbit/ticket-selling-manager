using Microsoft.VisualStudio.TestTools.UnitTesting;
using _QuanLyBanVeXe;

namespace QuanLyTuyenDiUnitTest
{
    [TestClass]
    public class TuyenDiDBTest
    {
        TuyenDiDB manager = new TuyenDiDB();

        [TestMethod]
        public void TestAdd()
        {
            TuyenDi t1 = new TuyenDi("BL-HCM", "BL", "HCM");

            Assert.AreEqual(true, manager.add(t1));
            Assert.AreEqual(false, manager.add(t1));

            Assert.AreEqual(true, manager.delete("BL-HCM"));
        }

        [TestMethod]
        public void TestUpdate()
        {
            TuyenDi t1 = new TuyenDi("BL-HCM", "BL", "HCM");
            manager.add(t1);

            TuyenDi t2 = new TuyenDi("BL-HCM", "BH", "HCM");

            Assert.AreEqual(true, manager.update(t2));
            Assert.AreEqual(true, manager.update(t1));
            Assert.AreEqual(true, manager.delete("BL-HCM"));
        }
    }
}

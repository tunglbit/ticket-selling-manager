using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _QuanLyBanVeXe;

namespace ChuyenDiDBUnitTest
{
    [TestClass]
    public class ChuyenDiDBTest
    {
        ChuyenDiDB manager = new ChuyenDiDB();

        [TestMethod]
        public void TestAddAndDelete()
        {
            DateTime thoiGianDi = DateTime.Now;
            ChuyenDi t1 = new ChuyenDi("BL-BH-003", "BL-BH", thoiGianDi, 240, 40);

            Assert.AreEqual(true, manager.add(t1));
            Assert.AreEqual(false, manager.add(t1));

            Assert.AreEqual(true, manager.delete("BL-BH-003"));
        }

        [TestMethod]
        public void TestUpdate()
        {
            DateTime thoiGianDi = DateTime.Now;
            ChuyenDi t1 = new ChuyenDi("BL-BH-003", "BL-BH", thoiGianDi, 240, 40);
            manager.add(t1);

            ChuyenDi t2 = new ChuyenDi("BL-BH-003", "BL-BH", thoiGianDi, 240, 50);

            Assert.AreEqual(true, manager.update(t2));
            Assert.AreEqual(true, manager.update(t1));
            Assert.AreEqual(true, manager.delete("BL-BH-003"));
        }
    }
}

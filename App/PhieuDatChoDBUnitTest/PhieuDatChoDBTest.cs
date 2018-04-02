using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _QuanLyBanVeXe;

namespace PhieuDatChoDBUnitTest
{
    [TestClass]
    public class PhieuDatChoDBTest
    {
        PhieuDatChoDB manager = new PhieuDatChoDB();

        [TestMethod]
        public void TestAddAndDelete()
        {
            DateTime ngayDat = DateTime.Now;
            PhieuDatCho t1 = new PhieuDatCho("PDC05", "HCM-HN-001", "HK002", 750000, ngayDat);

            Assert.AreEqual(true, manager.add(t1));
            Assert.AreEqual(false, manager.add(t1));
            Assert.AreEqual(true, manager.delete("PDC05"));
        }

        [TestMethod]
        public void TestUpdate()
        {
            DateTime ngayDat = DateTime.Now;
            PhieuDatCho t1 = new PhieuDatCho("PDC05", "HCM-HN-001", "HK002", 750000, ngayDat);
            manager.add(t1);

            PhieuDatCho t2 = new PhieuDatCho("PDC05", "HN-HCM-001", "HK002", 750000, ngayDat);

            Assert.AreEqual(true, manager.update(t2));
            Assert.AreEqual(true, manager.update(t1));
            Assert.AreEqual(true, manager.delete("PDC05"));
        }
    }
}

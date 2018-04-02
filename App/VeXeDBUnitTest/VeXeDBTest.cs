using Microsoft.VisualStudio.TestTools.UnitTesting;
using _QuanLyBanVeXe;

namespace VeXeDBUnitTest
{
    [TestClass]
    public class VeXeDBTest
    {
        VeXeDB manager = new VeXeDB();

        [TestMethod]
        public void TestAddAndDelete()
        {
            VeXe t1 = new VeXe("VX005", "HCM-HN-001", "HK002", 750000);

            Assert.AreEqual(true, manager.add(t1));
            Assert.AreEqual(false, manager.add(t1));

            Assert.AreEqual(true, manager.delete("VX005"));
        }

        [TestMethod]
        public void TestUpdate()
        {
            VeXe t1 = new VeXe("VX005", "HCM-HN-001", "HK002", 750000);
            manager.add(t1);

            VeXe t2 = new VeXe("VX005", "HCM-HN-001", "HK004", 750000);

            Assert.AreEqual(true, manager.update(t2));
            Assert.AreEqual(true, manager.update(t1));
            Assert.AreEqual(true, manager.delete("VX005"));
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using _QuanLyBanVeXe;

namespace BenXeDBUnitTest
{
    [TestClass]
    public class BenXeDBTest
    {
        BenXeDB manager = new BenXeDB();

        [TestMethod]
        public void TestAddAndDelete()
        {
            BenXe t1 = new BenXe("DN", "Da Nang");

            Assert.AreEqual(true, manager.add(t1));
            Assert.AreEqual(false, manager.add(t1));

            Assert.AreEqual(true, manager.delete("DN"));
        }

        [TestMethod]
        public void TestUpdate()
        {
            BenXe t1 = new BenXe("DN", "Da Nang");
            manager.add(t1);

            BenXe t2 = new BenXe("DN", "Thanh Pho Da Nang");

            Assert.AreEqual(true, manager.update(t2));
            Assert.AreEqual(true, manager.update(t1));
            Assert.AreEqual(true, manager.delete("DN"));
        }
    }
}

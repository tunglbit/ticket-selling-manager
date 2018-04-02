using Microsoft.VisualStudio.TestTools.UnitTesting;
using _QuanLyBanVeXe;

namespace HanhKhachDBUnitTest
{
    [TestClass]
    public class HanhKhachDBTest
    {
        HanhKhachDB manager = new HanhKhachDB();

        [TestMethod]
        public void TestAddAndDelete()
        {
            HanhKhach t1 = new HanhKhach("HK005", "Hanh Khach 5", "55555555", "0123321123");

            Assert.AreEqual(true, manager.add(t1));
            Assert.AreEqual(false, manager.add(t1));
            Assert.AreEqual(true, manager.delete("HK005"));
        }

        [TestMethod]
        public void TestUpdate()
        {
            HanhKhach t1 = new HanhKhach("HK005", "Hanh Khach 5", "55555555", "0123321123");
            manager.add(t1);

            HanhKhach t2 = new HanhKhach("HK005", "Hanh Khach thu 5", "50505050", "0123455432");

            Assert.AreEqual(true, manager.update(t2));
            Assert.AreEqual(true, manager.update(t1));
            Assert.AreEqual(true, manager.delete("HK005"));
        }
    }
}

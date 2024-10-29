using Tyuiu.AkhtarievaNR.Sprint2.Task6.V2.Lib;

namespace Tyuiu.AkhtarievaNR.Sprint2.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthSeason()
        {
            DataService ds = new DataService();

            Assert.AreEqual("����", ds.FindMonthSeason(1));
            Assert.AreEqual("����", ds.FindMonthSeason(2));
            Assert.AreEqual("�����", ds.FindMonthSeason(3));
            Assert.AreEqual("�����", ds.FindMonthSeason(4));
            Assert.AreEqual("�����", ds.FindMonthSeason(5));
            Assert.AreEqual("����", ds.FindMonthSeason(6));
            Assert.AreEqual("����", ds.FindMonthSeason(7));
            Assert.AreEqual("����", ds.FindMonthSeason(8));
            Assert.AreEqual("�����", ds.FindMonthSeason(9));
            Assert.AreEqual("�����", ds.FindMonthSeason(10));
            Assert.AreEqual("�����", ds.FindMonthSeason(11));
            Assert.AreEqual("����", ds.FindMonthSeason(12));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonthSeason(-1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonthSeason(13);
            });


        }
    }
}
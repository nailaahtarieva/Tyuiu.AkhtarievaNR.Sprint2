using Tyuiu.AkhtarievaNR.Sprint2.Task4.V8.Lib;

namespace Tyuiu.AkhtarievaNR.Sprint2.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondotion1()
        {
            DataService ds = new DataService();
            double x = 6;
            double y = -4;
            double res = ds.Calculate(x, y);
            double wait = 15712.007;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondotion2()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 18.500;
            Assert.AreEqual(wait, res);
        }
    }
}
using Tyuiu.AkhtarievaNR.Sprint2.Task3.V9.Lib;

namespace Tyuiu.AkhtarievaNR.Sprint2.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 3;
            double res = ds.Calculate(x);
            double wait = -273.375;
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 1.000;
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -3;
            double res = ds.Calculate(x);
            double wait = 0.331;
        }
        
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -16;
            double res = ds.Calculate(x);
            double wait = -176.063;
        }
    }
}
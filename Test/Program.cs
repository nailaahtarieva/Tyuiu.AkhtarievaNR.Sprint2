namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 195;
            int b = 16;
            int c = 14;
            int d = 45;
            var res = (a >= b) ^ (c <= d);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}

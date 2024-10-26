using Tyuiu.AkhtarievaNR.Sprint2.Task2.V6.Lib;

namespace Tyuiu.AkhtarievaNR.Sprint2.Task2.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнила: Ахтариева Н. Р. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                               *");
            Console.WriteLine("* Задание: 2                                                              *");
            Console.WriteLine("* Вариант: 6                                                              *");
            Console.WriteLine("* Выполнила: Ахтариева Наиля Руслановна | ИИПб-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая которая запрашивает целые значения с        *");
            Console.WriteLine("* с клавиатуры и вычисляет находится ли точка с координатами X,Y          *");
            Console.WriteLine("* в заштрихованной области.                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            Console.WriteLine("Введите значение переменной X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (res)
            {
                Console.WriteLine("Тока находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Тока не находится в заштрихованной области");
            }
           

            Console.ReadKey();
        }
    }
}

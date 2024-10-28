using Tyuiu.AkhtarievaNR.Sprint2.Task5.V5.Lib;

namespace Tyuiu.AkhtarievaNR.Sprint2.Task5.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Ахтариева Н. Р. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                               *");
            Console.WriteLine("* Задание: 5                                                              *");
            Console.WriteLine("* Вариант: 5                                                              *");
            Console.WriteLine("* Выполнила: Ахтариева Наиля Руслановна | ИИПб-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя число и          *");
            Console.WriteLine("* выводит соответствующее достоинство игральной карты                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение карты: ");
            int numCard = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((numCard < 6) || (numCard > 14))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Достоинство карты: " + ds.FindCardValue(numCard);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
            
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GrigorevKU.Sprint1.Task4.V24.Lib;
namespace Tyuiu.GrigorevKU.Sprint1.Task4.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1| Выполнил: Григорьев К. Ю. | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил Григорьев К. Ю. | ИИПб-23-2                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на С#, запрашивает у пользователя исходные*");
            Console.WriteLine("* данные, вычисляет результат по формуле и печатает его на экране.        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x;
            double y;
            Console.WriteLine("Введите значение переменной x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение переменной y:");
            y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("ln(x*y)/x + sqrt(2*y**2) = " + ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}

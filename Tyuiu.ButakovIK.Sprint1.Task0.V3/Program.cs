using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ButakovIK.Sprint1.Task0.V3.Lib;



namespace Tyuiu.ButakovIK.Sprint1.Task0.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Бутаков И. К. | АСОиУб-23-1";
            Console.WriteLine("*************************************************************");
            Console.WriteLine("* Спринт #1                                                 *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                          *");
            Console.WriteLine("* Таск: #0                                                  *");
            Console.WriteLine("* Вариант: #3                                               *");
            Console.WriteLine("* Выполнил: Бутаков Игорь Константинович | АСОиУб-23-1      *");
            Console.WriteLine("*************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                  *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение (6/2*3)/9 *");
            Console.WriteLine("* и печатает результат на экране.                           *");
            Console.WriteLine("*************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                          *");
            Console.WriteLine("*************************************************************");
            Console.WriteLine("* ( 6 / 2 * 3 ) / 9                                         *");
            Console.WriteLine("*************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                *");
            Console.WriteLine("*************************************************************");

            Console.WriteLine(ds.Calculate());
            Console.ReadKey();
        }
    }
}

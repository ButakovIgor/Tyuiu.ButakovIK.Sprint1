using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ButakovIK.Sprint1.Task4.V13.Lib;

//Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат по формуле и печатает его на экране.
//Ответ округлите до 3 знаков после запятой.
//Формула:  cos(π/x)
//          --------
//          3e^(x+y)

namespace Tyuiu.ButakovIK.Sprint1.Task4.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Бутаков И. К. | АСОиУб-23-1";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                 *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                          *");
            Console.WriteLine("* Задание: #4                                                               *");
            Console.WriteLine("* Вариант: #13                                                              *");
            Console.WriteLine("* Выполнил: Бутаков Игорь Константинович | АСОиУб-23-1                      *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,   *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                  *");
            Console.WriteLine("* Формула: cos(Pi/x)                                                        *");
            Console.WriteLine("*          --------                                                         *");
            Console.WriteLine("*          3e^(x+y)                                                         *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");
           
            double x;
            Console.WriteLine("Введите значение X: ");
            x = Convert.ToDouble(Console.ReadLine());

            double y;
            Console.WriteLine("Введите значение Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            double res = ds.Calculate(x, y);
            Console.WriteLine(res);
            Console.ReadKey();


        }
    }
}

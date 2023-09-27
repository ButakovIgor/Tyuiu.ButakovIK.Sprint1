using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ButakovIK.Sprint1.Task5.V4.Lib;


//Написать программу, которая решает следующую задачу:
//Идет k-я секунда суток. Определить, сколько полных часов (h) прошло к этому моменту (например, h = 3, если k=13257).

namespace Tyuiu.ButakovIK.Sprint1.Task5.V4
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
            Console.WriteLine("* Задание: #5                                                               *");
            Console.WriteLine("* Вариант: #4                                                               *");
            Console.WriteLine("* Выполнил: Бутаков Игорь Константинович | АСОиУб-23-1                      *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                      *");
            Console.WriteLine("* Идет k-я секунда суток. Определить, сколько полных часов (h)              *");
            Console.WriteLine("* прошло к этому моменту (например, h = 3, если k=13257).                   *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            int time;
            Console.WriteLine("Введите кол-во секунд: ");
            time = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            int hs = ds.SecondsToHours(time);
            Console.Write("Кол - во полных часов: " + hs);
            Console.ReadKey();
        }
    }
}

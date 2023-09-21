using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ButakovIK.Sprint1.Task2.V25.Lib;

//Вариант 25
//Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты и печатает результат на экране.
//Формулировка задания: Известен угол в радианах. Перевести угол в градусы.
//Что пользователь вводит? Угол в радианах (целое число)
//Что программа печатает на экране? Угол в градусах (вещественное число)

namespace Tyuiu.ButakovIK.Sprint1.Task2.V25
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
            Console.WriteLine("* Задание: #2                                                               *");
            Console.WriteLine("* Вариант: #25                                                              *");
            Console.WriteLine("* Выполнил: Бутаков Игорь Константинович | АСОиУб-23-1                      *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,   *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.               *");
            Console.WriteLine("* Формулировка задания: Известен угол в радианах. Перевести угол в градусы. *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");
            
            int radians;
            Console.WriteLine("Введите значение Х:");
            radians = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Угол в градусах = " + ds.ConvertRadsToDegrees(radians));
            Console.ReadLine();
        }
    }
}

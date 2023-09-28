using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ButakovIK.Sprint1.Task6.V17.Lib;

// Написать программу: пользователь вводит текст. Проверить, что строка является перевертышем.

namespace Tyuiu.ButakovIK.Sprint1.Task6.V17
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
            Console.WriteLine("* Задание: #6                                                               *");
            Console.WriteLine("* Вариант: #17                                                              *");
            Console.WriteLine("* Выполнил: Бутаков Игорь Константинович | АСОиУб-23-1                      *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу: пользователь вводит текст.                            *");
            Console.WriteLine("* Проверить, что строка является перевертышем.                              *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Введите слово: ");
            string value = Console.ReadLine();

            Console.WriteLine(ds.CheckPalindrome(value));
            Console.ReadKey();

        }
    }
}

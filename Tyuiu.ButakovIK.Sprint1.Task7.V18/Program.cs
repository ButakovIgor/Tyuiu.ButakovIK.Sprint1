using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ButakovIK.Sprint1.Task7.V18.Lib;

//Написать программу, которая вычисляет математическое выражение по исходным
//значениям данных, вводимых пользователем. Ответ округлите до 3 знаков после запятой.
//                  2
//           1 + sin ( x + y )
// z = ------------------------- + x
//          |         2x       |
//      2 + | x - ------------ |
//          |          2 2     |
//          |     1 + x y      |






namespace Tyuiu.ButakovIK.Sprint1.Task7.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Бутаков И. К. | АСОиУб-23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #1                                                                  *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                    *");
            Console.WriteLine("* Задание: #7                                                                *");
            Console.WriteLine("* Вариант: #18                                                               *");
            Console.WriteLine("* Выполнил: Бутаков Игорь Константинович | АСОиУб-23-1                       *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по исходным *");
            Console.WriteLine("* значениям данных, вводимых пользователем.                                  *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                                 *");
            Console.WriteLine("*                  2                                                         *");
            Console.WriteLine("*           1 + sin ( x + y )                                                *");
            Console.WriteLine("* z = ------------------------- + x                                          *");
            Console.WriteLine("*          |         2x       |                                              *");
            Console.WriteLine("*      2 + | x - ------------ |                                              *");
            Console.WriteLine("*          |          2 2     |                                              *");
            Console.WriteLine("*          |     1 + x y      |                                              *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            double x;
            Console.WriteLine("Введите значение X: ");
            x = Convert.ToDouble(Console.ReadLine());

            double y;
            Console.WriteLine("Введите значение Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            double z = ds.Calculate(x, y);
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}

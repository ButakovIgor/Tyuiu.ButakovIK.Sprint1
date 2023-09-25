using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ButakovIK.Sprint1.Task3.V8.Lib;

//Написать программу вычисления величины дохода по вкладу.
//Процентная ставка (% годовых) и время хранения (дней) задаются во время работы программы.

namespace Tyuiu.ButakovIK.Sprint1.Task3.V8
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
            Console.WriteLine("* Задание: #3                                                               *");
            Console.WriteLine("* Вариант: #8                                                               *");
            Console.WriteLine("* Выполнил: Бутаков Игорь Константинович | АСОиУб-23-1                      *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу вычисления величины дохода по вкладу.                  *");
            Console.WriteLine("* Процентная ставка (% годовых) и время хранения (дней) задаются            *");
            Console.WriteLine("* во время работы программы.                                                *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            double startAmount;
            Console.WriteLine("Введите величину вклада (руб.): ");
            startAmount = Convert.ToDouble(Console.ReadLine());

            double timeDays;
            Console.WriteLine("Введите срок вклада: ");
            timeDays = Convert.ToDouble(Console.ReadLine());

            double percent;
            Console.WriteLine("Введите процентную ставку: ");
            percent = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            double profit = ds.IncomeAmount(startAmount, percent, timeDays);

            Console.WriteLine("Доход: " + profit);
            Console.ReadLine();
        }
    }
}

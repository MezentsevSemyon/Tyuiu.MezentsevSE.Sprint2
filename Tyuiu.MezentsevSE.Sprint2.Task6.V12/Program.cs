using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MezentsevSE.Sprint2.Task6.V12.Lib;

namespace Tyuiu.MezentsevSE.Sprint2.Task6.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1| Выполнил: Мезенцев С.Е. | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #12                                                              *");
            Console.WriteLine("* Выполнил Мезенцев Семён Евгеньевич| ИИПб-23-2                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу,которая использует сокращенную форму записи оператора switch*");
            Console.WriteLine("*вычисляет требуемое значение и возвращает результат.                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            
            int n, m, g;
            Console.WriteLine("Введите день");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год");
            g = Convert.ToInt32(Console.ReadLine());


            string res = ds.FindDateOfPreviousDay(g, m, n);






            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}

using Tyuiu.KulkoDA.Sprint2.Task1.V13.Lib;

namespace Tyuiu.KulkoDA.Sprint2.Task1.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Кулько Д. А. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнила: Кулько Дарья Андреевна | ИИПб-24-2                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=)         *");
            Console.WriteLine("* и логических операций (|, &, ||, &&, !, ^),                             *");
            Console.WriteLine("* а также арифметических выражений,которая вернет логическую              *");
            Console.WriteLine("* последовательность(массив): (True, True, True, True, True, False)       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* a = 145, b = 916, c = 164, d = 137                                      *");
            int a = 145;
            int b = 916;
            int c = 164;
            int d = 137;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a,b,c,d);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
            


        }
    }
}

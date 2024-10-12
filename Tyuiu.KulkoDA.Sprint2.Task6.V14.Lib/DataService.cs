using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KulkoDA.Sprint2.Task6.V14.Lib
{
    public class DataService : ISprint2Task6V14
    {
        public string FindDayName(int k, int d)
        {
            if (d == 1)
            {
                switch (k % 7)
                {
                    case 1: return "1";
                    case 2: return "2";
                    case 3: return "3";
                    case 4: return "4";
                    case 5: return "5";
                    case 6: return "6";
                    case 0: return "7";
                    default: throw new ArgumentException("Неправильно введен месяц");
                }
            }
            else if (d == 2)
            {
                switch (k % 7)
                {
                    case 1: return "2";
                    case 2: return "3";
                    case 3: return "4";
                    case 4: return "5";
                    case 5: return "6";
                    case 6: return "7";
                    case 0: return "1";
                    default: throw new ArgumentException("Неправильно введен месяц");
                }
            }
            else if (d == 3)
            {
                switch (k % 7)
                {
                    case 1: return "3";
                    case 2: return "4";
                    case 3: return "5";
                    case 4: return "6";
                    case 5: return "7";
                    case 6: return "1";
                    case 0: return "2";
                    default: throw new ArgumentException("Неправильно введен месяц");
                }
            }
            else if (d == 4)
            {
                switch (k % 7)
                {
                    case 1: return "4";
                    case 2: return "5";
                    case 3: return "6";
                    case 4: return "7";
                    case 5: return "1";
                    case 6: return "2";
                    case 0: return "3";
                    default: throw new ArgumentException("Неправильно введен месяц");
                }
            }
            else if (d == 5)
            {
                switch (k % 7)
                {
                    case 1: return "5";
                    case 2: return "6";
                    case 3: return "7";
                    case 4: return "1";
                    case 5: return "2";
                    case 6: return "3";
                    case 0: return "4";
                    default: throw new ArgumentException("Неправильно введен месяц");
                }
            }
            else if (d == 6)
            {
                switch (k % 7)
                {
                    case 1: return "6";
                    case 2: return "7";
                    case 3: return "1";
                    case 4: return "2";
                    case 5: return "3";
                    case 6: return "4";
                    case 0: return "5";
                    default: throw new ArgumentException("Неправильно введен месяц");
                }
            }
            else
            {
                switch (k % 7)
                {
                    case 1: return "7";
                    case 2: return "1";
                    case 3: return "2";
                    case 4: return "3";
                    case 5: return "4";
                    case 6: return "5";
                    case 0: return "6";
                    default: throw new ArgumentException("Неправильно введен месяц");
                }
            }
        }
    }
}

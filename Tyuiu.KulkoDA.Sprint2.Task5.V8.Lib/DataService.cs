using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KulkoDA.Sprint2.Task5.V8.Lib
{
    public class DataService : ISprint2Task5V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            string res;
            switch (m)
            {
                case 1:
                    if (n >= 2)
                        res =(n - 1) + "."+1;
                    else
                        res = 31+"."+01;
                    break;

                case 2:
                    if (n >= 2)
                        res = (n - 1) + "." + 2;
                    else
                        res = 31 + "." + 01;
                    break;
                case 3:
                    if (n >= 2)
                        res = (n - 1) + "." + 3;
                    else
                        res = 28 + "." + 02;
                    break;
                case 4:
                    if (n >= 2)
                        res = (n - 1) + "." + 4;
                    else
                        res = 31 + "." + 03;
                    break;
                case 5:
                    if (n >= 2)
                        res = (n - 1) + "." + 5;
                    else
                        res = 30 + "." + 04;
                    break;
                case 6:
                    if (n >= 2)
                        res = (n - 1) + "." + 6;
                    else
                        res = 31 + "." + 05;
                    break;
                case 7:
                    if (n >= 2)
                        res = (n - 1) + "." + 7;
                    else
                        res = 30 + "." + 06;
                    break;
                case 8:
                    if (n >= 2)
                        res = ((n - 1) + "." + 8);
                    else
                        res = 31 + "." + 07;
                    break;
                case 9:
                    if (n >= 2)
                        res = (n - 1) + "." + 9;
                    else
                        res = 31 + "." + 08;
                    break;
                case 10:
                    if (n >= 2)
                        res = (n - 1) + "." + 10;
                    else
                        res = 30 + "." + 09;
                    break;
                case 11:
                    if (n >= 2)
                        res = (n - 1) + "." + 11;
                    else
                       res = 31 + "." + 10;
                    break;
                case 12:
                    if (n >= 2)
                        res = ((n - 1) + "." + 12);
                    else
                        res = 30+"."+11;
                    break;
                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение{m}");
                    
                
            }
            return (res);
            
        }
    }
}

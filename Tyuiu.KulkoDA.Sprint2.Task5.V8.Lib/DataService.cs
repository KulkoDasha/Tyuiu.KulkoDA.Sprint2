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
                        res =(n - 1) + " Января";
                    else
                        res = "31 Декабря";
                    break;

                case 2:
                    if (n >= 2)
                        res = (n - 1) + " Февраля";
                    else
                        res = "31 Января";
                    break;
                case 3:
                    if (n >= 2)
                        res = (n - 1) + " Марта";
                    else
                        res = "28 Февраля";
                    break;
                case 4:
                    if (n >= 2)
                        res = (n - 1) + " Апреля";
                    else
                        res = "31 Марта";
                    break;
                case 5:
                    if (n >= 2)
                        res = (n - 1) + " Мая";
                    else
                        res = "30 Апреля";
                    break;
                case 6:
                    if (n >= 2)
                        res = (n - 1) + " Июня";
                    else
                        res = "31 Мая";
                    break;
                case 7:
                    if (n >= 2)
                        res = (n - 1) + " Июля";
                    else
                        res = "30 Июня";
                    break;
                case 8:
                    if (n >= 2)
                        res = ((n - 1) + "Августа");
                    else
                        res = ("31 Июля");
                    break;
                case 9:
                    if (n >= 2)
                        res = (n - 1) + " Сентября";
                    else
                        res = "31 Августа";
                    break;
                case 10:
                    if (n >= 2)
                        res = (n - 1) + " Октября";
                    else
                        res = "30 Сентября";
                    break;
                case 11:
                    if (n >= 2)
                        res = (n - 1) + " Ноября";
                    else
                       res = "31 Октября";
                    break;
                case 12:
                    if (n >= 2)
                        res = ((n - 1) + " Декабря");
                    else
                        res = ("30 Ноября");
                    break;
                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение{m}");
                    
                
            }
            return (res);
            
        }
    }
}

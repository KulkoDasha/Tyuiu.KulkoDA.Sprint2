using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KulkoDA.Sprint2.Task7.V3.Lib
{
    public class DataService : ISprint2Task7V3
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (((0 <= y || y <= 1) && (-1 <= x || x <= 1))&&((x*x+(y-1)*(y-1)<=1)&&(1-x*x>=y)))
                return true;
            else return false;

        }
    }
}

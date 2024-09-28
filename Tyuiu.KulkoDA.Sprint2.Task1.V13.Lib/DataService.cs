using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KulkoDA.Sprint2.Task1.V13.Lib
{
    public class DataService : ISprint2Task1V13
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a!=b)|(d==c);
            res[1] = (d+100>a)&(a<=b);
            res[2] = (b-900<c)||(a+b!=c);
            res[3] = (a*c>=100)&&(b-5>10);
            res[4] = !(a==c);
            res[5] = (c!=5)^(a-100>0);
            return res;
        }
    }
}

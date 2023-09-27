using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShpilevayaAS.Sprint1.Task5.V5.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint1.ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            double res = (x * 10) % 10;
            return (int)res;

        }
    }
}

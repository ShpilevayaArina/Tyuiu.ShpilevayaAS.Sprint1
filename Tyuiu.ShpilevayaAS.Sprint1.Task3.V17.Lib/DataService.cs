using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShpilevayaAS.Sprint1.Task3.V17.Lib
{
    public class DataService : ISprint1Task3V17
    {
        public bool ZeroCheck(double number)
        {
            int x = (int)(number * 1000);
            if (x % 10 == 0 || x / 10 % 10 == 0 || x / 100 % 10 == 0)
            {
                return true;
                 
            }
            else
            {
                return false;
            }
            
                


            
        }
    }
}

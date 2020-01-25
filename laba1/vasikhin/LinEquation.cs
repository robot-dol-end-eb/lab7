using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vasikhin
{
   
    class LinEquation
    {
        protected double x;
        
        public double calcLinEquation(double a, double b)
        {
            if (a == 0)//Определено, что такое уравнение не существует
            {
                throw new VasikhinException("Уравнение не существует");
            }
            MyLog.log("Определено, что это линейное уравнение"); 
            return x = -b / a;
        }
    }
}

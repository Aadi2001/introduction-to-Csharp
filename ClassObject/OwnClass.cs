using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    class OwnClass
    {
        public string Color = "Red";
        public string findEvenOdd(int num)
        {
            if (num % 2 == 0)
            {
                return "Even Number";
            }
            else
            {
                return "Odd Number";
            }
        }
    }
}

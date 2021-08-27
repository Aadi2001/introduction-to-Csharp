using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class MethodOverloading
    {
        static int PlusMethod(int x, int y)
        {
            return x + y;

        }
        static double PlusMethod(double x, double y)
        {
            return x + y;

        }
        static int PlusMethod(int x)
        {
            return x + x;

        }
        static void Main(string[] args)
        {
            int myNum1 = PlusMethod(8, 5);
            Console.WriteLine("Int: " + myNum1);
            double myNum2 = PlusMethod(4.5, 5.5);
            Console.WriteLine("Int: " + myNum2);
            int myNum3 = PlusMethod(8);
            Console.WriteLine("Int: " + myNum3);

        }
    }
}

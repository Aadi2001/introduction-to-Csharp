using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionalHandling
{
    class ThrowStatement
    {
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access Denied - You must be atleast 18 Years old.");
            }
            else
            {
                Console.WriteLine("Access Granted -  You are Old Enough");
            }
        }
        static void main(string[] args)
        {
            checkAge(20);
        }
    }

}

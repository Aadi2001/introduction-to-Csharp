using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class calc
    {
        public int x;
        public int y;
        
        public static void add(int x,int y)
        {
            int total = x + y;
            Console.WriteLine("Addition " + total);
        }
        public static void sub(int x, int y)
        {
            int total = x - y;
            Console.WriteLine("Subtraction " + total);
        }
        public static void mul(int x, int y)
        {
           int total = x * y;
            Console.WriteLine("Multiplication " + total);
        }
        public static void div(int x, int y)
        {
            int total = x / y;
            Console.WriteLine("Division " + total);
        }

        public static void main(string[] args)
        {
            Console.WriteLine("Enter 1 for Addition");
            Console.WriteLine("Enter 2 for Subtraction");
            Console.WriteLine("Enter 3 for Multiplication");
            Console.WriteLine("Enter 4 for Division");
            Console.WriteLine("Enter 5 for exit");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter First Number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int y = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                //Console.WriteLine("Enter First Number");
                //int x = int.Parse(Console.ReadLine());
                //Console.WriteLine("Enter Second Number");
                //int y = int.Parse(Console.ReadLine());
                add(x, y);
            }
            else if (num == 2)
            {
                //Console.WriteLine("Enter First Number");
                //int x = int.Parse(Console.ReadLine());
                //Console.WriteLine("Enter Second Number");
                //int y = int.Parse(Console.ReadLine());
                sub(x, y);
            }
            else if (num == 3)
            {
                //Console.WriteLine("Enter First Number");
                //int x = int.Parse(Console.ReadLine());
                //Console.WriteLine("Enter Second Number");
                //int y = int.Parse(Console.ReadLine());
                mul(x, y);
            }
            else if (num == 4)
            {
                //Console.WriteLine("Enter First Number");
                //int x = int.Parse(Console.ReadLine());
                //Console.WriteLine("Enter Second Number");
                //int y = int.Parse(Console.ReadLine());
                div(x, y);
                //    Console.WriteLine("Enter First Number");
            }
            else
            {
                Console.WriteLine("Restart The Program");
                System.Environment.Exit(1);
            }
            

        }
    }
}

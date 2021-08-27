using System;

namespace ClassObject
{
    class Program
    {
        string color = "red";
        static void main(string[] args)
        {
            Program myObj = new Program();
            Console.WriteLine(myObj.color);
            int a = 5;
            Console.WriteLine(a);
        }
    }
}

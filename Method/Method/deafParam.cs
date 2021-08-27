using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class deafParam
    {
        static void method(string fname = "Aditya", string fname2 = "Amit", string fname3 = "Omkar")
        {
            Console.WriteLine(fname + " " + fname2 + " " + fname3);
        }
        static void main(string[] args)
        {
            method();
            method("Adi", "Amu", "Omi");
            method(fname2: "Arush");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionalHandling
{
    class TryCatch
    {
        static void main(string[] args)
        {
            try
            {
                int[] myNumbers = { 1, 2, 3, 4, 5, 6 };
                Console.WriteLine("Numbers" + myNumbers[10]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
//Exception: Handles all the Exception
//I/O Exception : handles I/O exception
//
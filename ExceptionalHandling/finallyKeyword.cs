using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionalHandling
{
    class finallyKeyword
    {
        static void main(string[] args)
        {
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something Went Wrong");
            }
            finally
            {
                Console.WriteLine("The Try Catch is Finished");
            }
        }
    }
}

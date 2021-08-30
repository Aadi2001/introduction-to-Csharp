using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionalHandling
{
    class TempIsZeroException : Exception
    {
        public TempIsZeroException(string message) : base(message)
        {

        }
    }
    
    public class Temperature
    {
        int temperature = 85;
        public void showTemp()
        {
            if (temperature == 0)
            {
                throw (new TempIsZeroException("Zero Temp is found"));
            }
            else
            {
                Console.WriteLine("Temperature: {0}", temperature);
            }
        }
    }
    class CustomException
    {
        static void main(string[] args)
        {
            Temperature temp = new Temperature();
            try
            {
                temp.showTemp();

            }
            catch(TempIsZeroException e)
            {
                Console.WriteLine("TempIsZeroException: {0}", e.Message);
            }
        }
    }
}

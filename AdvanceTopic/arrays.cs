using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTopic
{
    class arrays
    {
        static void main(string[] args)
        {
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = i + 100;

            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Array[{0}]:{1}", i, arr[i]);
            }

        }
    }
}

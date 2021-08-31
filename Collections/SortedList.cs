using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class OwnSortedList
    {
        public static void main()
        {
            SortedList<int, string> numberNames = new SortedList<int, string>();
            numberNames.Add(3, "Three");
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(4, null);
            numberNames.Add(10, "Ten");
            numberNames.Add(5, "Five");
            //numberNames.Add(3, "Three");

            numberNames[2] = "TWO";
            numberNames[4] = "FOUR";

            Console.WriteLine("------Number Names--------");
            foreach (var kvp in numberNames)
                Console.WriteLine("Key:{0}, Value:{1}", kvp.Key, kvp.Value);


            SortedList<string, string> cities = new SortedList<string, string>()
            {
                {"London", "UK" },
                {"New York", "USA" },
                {"Mumbai", "India" },
                {"Miami", "Chicago" },

            };

            Console.WriteLine("-------CITIES---------");
            foreach (var kvp in cities)
                Console.WriteLine("Key: {0}, Value:{1}", kvp.Key, kvp.Value);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class HashTable
    {
        public static void Main()
        {
            Hashtable numberNames = new Hashtable();
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");
  //          numberNames.Add(4, "Four");


            foreach (DictionaryEntry kvp in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            var cities = new Hashtable()
            {
                {"UK","London, Manchester, Bhrimingam" },
                {"INDIA","Mumbai, NewDelhi, Chennai" },
                {"USA","Chicago, NewYork, Washington" },
//                {"UK","London, Manchester, Bhrimingam" },

            };
            Console.WriteLine("\n");
            Console.WriteLine(cities["UK"]);
            cities.Remove("UK");
            cities["INDIA"] = "Banglore";

            //cities.Add(INDIA, Banglore);

            Console.WriteLine("\n");
            foreach (DictionaryEntry kvp in cities)
                Console.WriteLine("Key:{0}, Value: {1}", kvp.Key, kvp.Value);
            
            Console.WriteLine("Lenght of Cities:" + cities.Count);

        }


    }
}

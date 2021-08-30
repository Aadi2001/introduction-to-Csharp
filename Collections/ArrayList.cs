using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Collections
{
    class OwnArrayList
    {
        public static void main()
        {
            ArrayList arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("Arjuna");
            arlist1.Add(false);
            arlist1.Add(5.4);
            arlist1.Add(null);
            arlist1.Remove(true);


            ArrayList arlist2 = new ArrayList()
            {
                2, "Bhima", true , 4.5, null
            };
            Console.WriteLine("Arraylist 1 Items");
            for (int i = 0; i < arlist1.Count; i++)
                Console.WriteLine(arlist1[i]);

            Console.WriteLine("ArrayList 2 Itemss");
            for (int i = 0; i < arlist2.Count; i++)
                Console.WriteLine(arlist2[i]);
            arlist1.Insert(3, "New York");
            arlist2.Remove(null);




            Console.WriteLine("Array list 1  Element");

            for (int i = 0; i < arlist1.Count; i++)
                Console.WriteLine(arlist1[i]);
        }
    }
}

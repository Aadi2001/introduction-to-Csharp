using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Collections
{
    class OwnStack
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push('A');
            st.Push('B');
            st.Push('C');
            //st.Push('D');

            Console.WriteLine("Current Stack: ");
            foreach (char c in st)
                Console.Write(c + " ");
            Console.WriteLine();

            st.Push('D');
            st.Push('E');

            Console.WriteLine("The Next Poppable value in stack: {0}", st.Peek());
            Console.WriteLine("\n Current Stack: ");
            foreach (char c in st)
                Console.Write(c + "");

            Console.WriteLine("\n Removing values....");
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());
            Console.WriteLine("\n Current Stack: ");
            foreach (char c in st)
                Console.Write(c + "");
            //Console.WriteLine();



            //st.Push('D');
            //st.Push('E');



        }
    }
}

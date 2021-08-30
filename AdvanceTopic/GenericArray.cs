using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTopic
{
    public class GenericArray<T>
    {
        private T[] array;
        public GenericArray(int size)
        {
            array = new T[size + 1];
        }
        public T getItem(int index)
        {
            return array[index];// = value;

        }
        public void setItem(int index,T value)
        {
            array[index] = value;
        }
    }
    class Tester
    {
        static void main(string[] args)
        {
            GenericArray<int> intArray = new GenericArray<int>(5);
            
            for (int i = 0; i < 5; i++)
            {
                intArray.setItem(i, i * 9);
            }
            //Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(intArray.getItem(i) + "");
            }
            Console.WriteLine();
            
            GenericArray<char> charArray = new GenericArray<char>(5);
            
            for (int i = 0; i < 5; i++)
            {
                charArray.setItem(i, (char)(i + 97));

            }
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(charArray.getItem(i)+ " ");
            }
            Console.WriteLine();
        }
    }
}

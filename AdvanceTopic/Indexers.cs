using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTopic
{
    class Indexers
    {
        static public int size = 10;
        private string[] names = new string[size];

        public Indexers()
        {
            for (int i = 0; i < size; i++)
            {
                names[i] = "NULL";
            }
        }
        public string this[int index]
        {
            get
            {
                string temp;

                if (index >= 0 && index <= size - 1)
                {
                    temp = names[index];
                }
                else
                {
                    temp = "";

                }
                return temp;
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                {
                    names[index] = value;

                }
            }
        }

        static void main(string[] args)
        {
            Indexers obj = new Indexers();
            obj[0] = "Aditya";
            obj[1] = "Amit";
            obj[2] = "Omkar";
            obj[3] = "Indresh";
            obj[4] = "santosh";
            obj[5] = "Shashank";
            for (int i = 0; i < Indexers.size; i++)
            {
                Console.WriteLine(obj[i]);
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AdvanceTopic
{
    class MultiThreading
    {
        public static void CallToChildThread()
        {
            while(true)
            {
                Console.WriteLine("Child Thread Started");
            }
            
            //int sleepfor = 5000;
            //Console.WriteLine("Child Thread Paused for {`.0} Seconds", sleepfor / 1000);
            //Thread.Sleep(sleepfor);
            //Console.WriteLine("Child Thread Resumes");
        }
        public static void CallToChildThread2()
        {
            while (true)
            {
                Console.WriteLine("Child Thread Started");
            }
            //Console.WriteLine("Child Thread Started");
            //int sleepfor = 5000;
            //Console.WriteLine("Child Thread Paused for {`.0} Seconds", sleepfor / 1000);
            //Thread.Sleep(sleepfor);
            //Console.WriteLine("Child Thread Resumes");
        }
        static void Main(String[] args)
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            ThreadStart childref2 = new ThreadStart(CallToChildThread2);
            Console.WriteLine("In Main: Creating  the child thread");
            Thread childThread = new Thread(childref);
            Thread childThread2 = new Thread(childref2);
            childThread.Start();
            childThread2.Start();
            //Console.WriteLine("Thread Stopped");
        }
    } 
}

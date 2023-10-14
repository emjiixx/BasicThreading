using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BasicThreading
{
    internal class MyThreadClass
    {
        public static void Thread1()
        {
            for (int i = 0; i <= 5; i++ )
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + i);

                Thread.Sleep(20);
            }
        }
        public static void Thread2()
        {
            for (int i = 0; i <= 5; i++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + i);

                Thread.Sleep(23);
            }
        }
    }
}

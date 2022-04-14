using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Programm
    {
        static void Main()
        {
            Queue gb = new();

            gb.Enqueue(64);
            gb.Enqueue(128);
            gb.Enqueue(256);
            gb.Enqueue(512);
            gb.Enqueue(1024);

            gb.Dequeue();
            gb.Dequeue();
            gb.Dequeue();

            Console.WriteLine(gb.Peek());
        }
    }
}
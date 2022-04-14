using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    internal class Queue : IQueue
    {
        public List<int> queue = new();

        public int Peek()
        {
            return queue.First();
        }
        public int Dequeue()
        {
            int temp = queue.First();

            queue.RemoveAt(0);

            return temp;
        }

        public void Enqueue(int item)
        {
            queue.Add(item);
        }

    }
}
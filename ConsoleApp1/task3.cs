using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RingQueue<T>
    {
        private T[] buffer;
        private int head;
        private int tail;

        public int Count { get; private set; } = 0;
        public int Capacity { get; private set; }

        public RingQueue(int capacity)
        {
            Capacity = capacity;
            buffer = new T[capacity];
            head = 0;
            tail = 0;
        }

        public void Enqueue(T item)
        {
            if (Count == Capacity)
            {
                throw new InvalidOperationException("Queue is full.");
            }

            buffer[tail] = item;
            tail = (tail + 1) % Capacity;
            Count++;
        }

        public T Dequeue()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            var item = buffer[head];
            buffer[head] = default(T);
            head = (head + 1) % Capacity;
            Count--;

            return item;
        }
    }
}

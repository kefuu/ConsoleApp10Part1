using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PriorityQueue<T>
    {
        private SortedDictionary<int, Queue<T>> queueDictionary = new SortedDictionary<int, Queue<T>>();

        public int Count { get; private set; } = 0;

        public void Enqueue(T item, int priority)
        {
            if (!queueDictionary.ContainsKey(priority))
            {
                queueDictionary[priority] = new Queue<T>();
            }

            queueDictionary[priority].Enqueue(item);
            Count++;
        }

        public T Dequeue()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            var highestPriority = queueDictionary.Keys.Max();
            var item = queueDictionary[highestPriority].Dequeue();
            Count--;

            if (queueDictionary[highestPriority].Count == 0)
            {
                queueDictionary.Remove(highestPriority);
            }

            return item;
        }

        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            var highestPriority = queueDictionary.Keys.Max();
            return queueDictionary[highestPriority].Peek();
        }
    }
}

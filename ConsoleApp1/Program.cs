namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task1
            int a = 5, b = 10;
            Console.WriteLine($"Перед обміном: a = {a}, b = {b}");

            Helper.Swap(ref a, ref b);

            Console.WriteLine($"Після обміну: a = {a}, b = {b}");

            string str1 = "Hello", str2 = "World";
            Console.WriteLine($"\nПеред обміном: str1 = {str1}, str2 = {str2}");

            Helper.Swap(ref str1, ref str2);

            Console.WriteLine($"Після обміну: str1 = {str1}, str2 = {str2}");

            Console.WriteLine();

            // task2
            var pq = new PriorityQueue<string>();

            pq.Enqueue("Item1", 1);
            pq.Enqueue("Item2", 2);
            pq.Enqueue("Item3", 1);

            Console.WriteLine("Загальна кількість елементів у черзі: " + pq.Count);
            Console.WriteLine("Погляньте на перший елемент у черзі: " + pq.Peek());

            Console.WriteLine("Елемент черги: " + pq.Dequeue());
            Console.WriteLine("Загальна кількість елементів у черзі після зняття черги: " + pq.Count);
            Console.WriteLine("Перегляд першого елемента в черзі після зняття черги: " + pq.Peek());

            Console.WriteLine("Елемент черги: " + pq.Dequeue());
            Console.WriteLine("Загальна кількість елементів у черзі після зняття черги: " + pq.Count);
            Console.WriteLine("Перегляд першого елемента в черзі після зняття черги: " + pq.Peek());

            Console.WriteLine("Елемент черги: " + pq.Dequeue());
            Console.WriteLine("Загальна кількість елементів у черзі після зняття черги: " + pq.Count);

            Console.WriteLine();

            // task3
            var rq = new RingQueue<string>(3);

            rq.Enqueue("Item1");
            rq.Enqueue("Item2");
            rq.Enqueue("Item3");

            Console.WriteLine("Загальна кількість елементів у черзі: " + rq.Count);

            Console.WriteLine("Елемент черги: " + rq.Dequeue());
            Console.WriteLine("Загальна кількість елементів у черзі після зняття черги: " + rq.Count);

            Console.WriteLine("Елемент черги: " + rq.Dequeue());
            Console.WriteLine("Загальна кількість елементів у черзі після зняття черги: " + rq.Count);

            Console.WriteLine("Елемент черги: " + rq.Dequeue());
            Console.WriteLine("Загальна кількість елементів у черзі після зняття черги: " + rq.Count);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. ArrayList
            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add(20);
            arrayList.Add(30);
            arrayList.Insert(1, 15);
            arrayList.Remove(20);
            Console.WriteLine("ArrayList:");
            foreach (var item in arrayList)
                Console.WriteLine(item);

            // 2. List<T>
            List<int> list = new List<int>();
            list.AddRange(new int[] { 1, 2, 3 });
            list.Add(4);
            list.Sort();
            list.RemoveAt(1);
            Console.WriteLine("\nList<T>:");
            foreach (var item in list)
                Console.WriteLine(item);

            // 3. Dictionary<TKey, TValue>
            Dictionary<int, string> dictionary = new Dictionary<int, string>
            {
                { 1, "erti" },
                { 2, "ori" },
                { 3, "sami" }
            };
            dictionary.Remove(2);
            Console.WriteLine("\nDictionary:");
            foreach (var key in dictionary.Keys)
                Console.WriteLine($"{key}: {dictionary[key]}");

            // 4. SortedList<TKey, TValue>
            SortedList<int, string> sortedList = new SortedList<int, string>
            {
                { 3, "sami" },
                { 1, "erti" },
                { 2, "ori" }
            };
            sortedList.RemoveAt(0);
            Console.WriteLine("\nSortedList:");
            foreach (var key in sortedList.Keys)
                Console.WriteLine($"{key}: {sortedList[key]}");

            // 5. Stack<T>
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine("\nStack:");
            Console.WriteLine($"Peek: {stack.Peek()}");
            stack.Pop();
            foreach (var item in stack)
                Console.WriteLine(item);

            // 6. Queue<T>
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine("\nQueue:");
            Console.WriteLine($"Peek: {queue.Peek()}");
            queue.Dequeue();
            foreach (var item in queue)
                Console.WriteLine(item);

            // 7. SortedDictionary<TKey, TValue>
            SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>
            {
                { 3, "sami" },
                { 1, "erti" },
                { 2, "ori" }
            };
            sortedDictionary.Remove(2);
            Console.WriteLine("\nSortedDictionary:");
            foreach (var key in sortedDictionary.Keys)
                Console.WriteLine($"{key}: {sortedDictionary[key]}");

            // 8. HashSet<T>
            HashSet<int> hashSet = new HashSet<int> { 1, 2, 3 };
            hashSet.Add(3);
            hashSet.Add(4);
            hashSet.UnionWith(new int[] { 5, 6, 7 });
            Console.WriteLine("\nHashSet:");
            foreach (var item in hashSet)
                Console.WriteLine(item);
        }
    }
}


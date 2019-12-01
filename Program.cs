using ListApp.LinkedList;
using System;

namespace ListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.Insert(0, 100);
            linkedList.Insert(1, 1001);
            linkedList.Insert(2, 1002);
            linkedList.Add(12);
            linkedList.Add(120);
            linkedList.Add(8);

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine(linkedList.Contains(100));
            Console.WriteLine(linkedList.Contains(8));

            linkedList.Insert(4, 100);
            linkedList.Contains(100);

            Console.WriteLine(linkedList.Contains(100));
            linkedList.RemoveAt(1);

            linkedList.RemoveAt(100);
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}

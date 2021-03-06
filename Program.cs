﻿using ListApp.LinkedList;
using System;

namespace ListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.Add(1001);
            linkedList.Add(50);
            linkedList.Add(100);


            linkedList.Insert(3, 20);
            linkedList.Insert(4, 40);

            linkedList.Insert(0, 120);

            // linkedList.Insert(1, 50);
            // linkedList.Insert(4, 90);
            //linkedList.Insert(4, 80);

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine(linkedList.Contains(100));
            Console.WriteLine(linkedList.Contains(8));

            linkedList.Contains(100);

            linkedList.RemoveAt(0);

            linkedList.RemoveAt(4);
            linkedList.Contains(120);

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}

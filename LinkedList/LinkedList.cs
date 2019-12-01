using ListApp.Item;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListApp.LinkedList
{
    public class LinkedList<T> : IEnumerable<T>
    {
        Item<T> head = null;
        Item<T> tail = null;

        int count = 0;

        public int Count { get { return count; } }
        public bool isEmpty { get { return count == 0; } }

        public bool Contains(T data)
        {
            Item<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return true;
                }
                current = current.Next;
            }

            return false;
        }
        public void Add(T data)
        {
            Item<T> item = new Item<T>(data);
            if (head == null)
            {
                head = item;
            }
            else
            {
                tail.Next = item;
            }

            tail = item;
            count++;
        }

        public void Insert(int index, T data)
        {
            // exception if index < 0
            if (index > count)
            {
               
                throw new ArgumentException();
                
            }

            else if (index == 0)
            {
                Add(data);
                return;
            }

            int currentIndex = 1;
            Item<T> currentData = head;
            while (currentData != null)
            {
                if (currentIndex == index)
                {
                    Add(data);
                }
                currentIndex++;
                currentData = currentData.Next;
            }

            return;
        }
        // -1 not find
        public int IndexOf(T data)
        {
            int currentIndex = 0;
            Item<T> currentData = head;
            while (currentData != null)
            {
                if (currentData.Data.Equals(data))
                {
                    return currentIndex;
                }
                currentIndex++;
                currentData = currentData.Next;
            }

            return -1;
        }
        public void RemoveAt(int index)
        {
            // Exception
            if (index > (count - 1))
            {
                throw new ArgumentException();
            }

            // Exception
            else if (index < 0)
            {
                throw new ArgumentException();
            }

            Item<T> current = head;
            int currentIndex = 0;
            while (current != null)
            {
                if (currentIndex == index)
                {
                    Remove(current.Data);
                }
                current = current.Next;
                currentIndex++;
            }
        }

        public bool Remove(T data)
        {
            Item<T> cur = head;
            Item<T> prev = null;
            while (cur != null)
            {
                if (cur.Data.Equals(data))
                {
                    count--;
                    if (prev != null)
                    {
                        prev.Next = cur.Next;
                        if (cur.Next == null)
                        {
                            tail = prev;
                        }
                    }
                    else
                    {
                        head = head.Next;
                        if (head == null)
                        {
                            tail = null;
                        }
                    }

                    return true;

                }
                prev = cur;
                cur = cur.Next;
            }

            return false;
        }
        // реализация интерфейса IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Item<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}

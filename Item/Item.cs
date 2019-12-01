using System;
using System.Collections.Generic;
using System.Text;

namespace ListApp.Item
{
    class Item<T> {
        public Item(T data)
        {
            Data = data;
        }

        public T Data { get; set; }
        public Item<T> Next { get; set; }

    }
}

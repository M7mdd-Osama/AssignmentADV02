using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class FixedSizeList<T>
    {
        public T[] items;
        public int count;

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("Capacity must be greater than zero");
            }
            items = new T[capacity];
            count = 0;
        }
        public void Add(T item)
        {
            if (count >= items.Length)
            {
                throw new InvalidOperationException("List is full and Cannot add more elements");
            }
            items[count] = item;
            count++;
        }
        public T Get(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException("index is out of range");
            }
            return items[index];
        }
        public int Count
        {
            get { return count; }
        }
        public int Capacity
        {
            get { return items.Length; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV01
{
    internal class FixedSizeList<T>
    {
        private T[] items;
        private int count;
        public FixedSizeList(int capicity)
        {
            Capicity = capicity;
            items = new T[capicity];
            count = 0;
        }

        public int Capicity { get; set; }

        public T Get(int index)
        {
            if (index < 0 || index > items.Length)
                throw new IndexOutOfRangeException("Invalid index. Please provide a valid index within the list range.");
            return items[index];
        }
        public void Add(T item)
        {
            if (count >= Capicity)
                throw new InvalidOperationException("Cannot add more elements. The list is full.");

            items[count++] = item;
        }

    }
}

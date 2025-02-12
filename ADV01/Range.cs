using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV01
{
    internal class Range<T> where T : IComparable<T>
    {
        public Range(T min, T max)
        {
            Min = min;
            Max = max;
        }
        public T Min { get; set; }
        public T Max { get; set; }
     

        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }

        public T Length()
        {
            dynamic min = Min;
            dynamic max = Max;
            return max - min;
        }
    }
}

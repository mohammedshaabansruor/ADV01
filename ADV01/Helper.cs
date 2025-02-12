using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV01
{
    internal static class Helper
    {
        public static void Reverse<T>(T[] array)
        {
           
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write($"{array[i]}, ");
            }


        }

        public static void GetOddNumbers(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.Write($"{array[i]}, ");
                }

            }
        }

        public static void FirstNonRepeatedCharacter(string stir)
        {
            if (string.IsNullOrEmpty(stir))
            {
                Console.WriteLine("Input string cannot be null or empty.");
                return;
            }
            Dictionary<char, int> chars = new Dictionary<char, int>();
            for (int i = 0; i < stir.Length; i++)
            {
                if (!chars.ContainsKey(stir[i])) chars.Add(stir[i], 1);
                else chars[stir[i]]++;
            }
            bool flage = false;
            foreach (char a in stir)
            {
                if (chars[a] == 1)
                {
                    Console.WriteLine($"the Character is {a}");
                    flage = true;
                    return;
                }
            }
            if (!flage)
                Console.WriteLine("No non-repeated character found");
        }
    }
}

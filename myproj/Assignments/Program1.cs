using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dummy
{
    class Program1
    {
        static void main()
        {
            Console.WriteLine("Enter string : ");
            String string1 = Console.ReadLine().ToLower().Trim();
            Dictionary<Char, int> letter_count_dict = new Dictionary<Char, int>();
            int max_freq = 0;
            List<char> max_freq_char = new List<char>();
            for (int i = 0; i < string1.Length; i++)
            {
                if (letter_count_dict.ContainsKey(string1[i]) == true)
                {
                    letter_count_dict[string1[i]] += 1;

                    if (letter_count_dict[string1[i]] > max_freq)
                    {
                        max_freq = letter_count_dict[string1[i]];
                    }
                }
                else
                {
                    letter_count_dict[string1[i]] = 1;
                }

            }

            foreach (var elem in letter_count_dict)
            {

                if (elem.Value == max_freq)
                {
                    max_freq_char.Add(elem.Key);
                }

            }


            foreach (char item in max_freq_char)
            {
                Console.Write("Positions of " + item + " : ");
                for (int j = 0; j < string1.Length; j++)
                {
                    if (string1[j] == item)
                    {
                        Console.Write(j + 1 + " ");
                    }
                }
                Console.WriteLine();
            }


        }
    }
}
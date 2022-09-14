using System;

namespace dot_net_mentoring_program
{
    internal class UniqueSymbolCount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a string:");
            string str = Console.ReadLine();
            Console.WriteLine("Lenth of substring with unique symbols " + longestUniqueSubstr(str));
        }
        static int longestUniqueSubstr(string str)
        {
            int n = str.Length;

            int res = 0;

            for (int i = 0; i < n; i++)
            {
                bool[] isExist = new bool[256];

                for (int j = i; j < n; j++)
                {
                    if (isExist[str[j]] == true)
                        break;
                    else
                    {
                        res = Math.Max(res, j - i + 1);
                        isExist[str[j]] = true;
                    }
                }
            }
            return res;
        }
    }
}

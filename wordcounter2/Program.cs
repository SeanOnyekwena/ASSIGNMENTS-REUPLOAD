using System;

namespace wordcounter2
{
    class Program
    {
        public static void Main()
        {
            string str;
            int i, wrd, l;

            
            Console.Write("Type a phrase or sentence or paragraph for words to be counted: ");
            str = Console.ReadLine();

            l = 0;
            wrd = 1;

            
            while (l <= str.Length - 1)
            {
                
                if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
                {
                    wrd++;
                }

                l++;
            }

            Console.Write("Word count: {0}\n", wrd);
        }
    }
}
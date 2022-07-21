using System;

namespace exo4bis
{
    class exo4bis
    {
        public static void Main(string[] args)  
        {
            string test;
            Console.WriteLine("Enter you sentence.");
            test = Console.ReadLine();
            string x = InvertCase(test);
            Console.WriteLine(x);
        }

        public static string InvertCase(string sentence)
        {
            char ch;
            int l;
            l = sentence.Length;
            for (int i=0; i<l; i++)
            {
                ch = sentence[i];
                if(char.IsLetter(ch))
                {
                    if (char.IsLower(ch))
                    {
                        Console.Write(char.ToUpper(ch));
                    }
                    else if (char.IsUpper(ch))
                    {
                        Console.Write(char.ToLower(ch));
                    }
                }
                else
                {
                    Console.Write(ch);
                }
            }
            return sentence;
        }
    }
}
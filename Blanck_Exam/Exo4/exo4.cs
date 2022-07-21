using System;

namespace exo4
{
    class exo4
    {
        public static void Main(string[] args)  
        {
            string s1;
            char ch;
            int l;
            Console.WriteLine("Enter you s1.");
            s1 = Console.ReadLine();
            l = s1.Length;
            for (int i=0; i<l; i++)
            {
                ch = s1[i];
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

        }
    }
}
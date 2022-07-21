using System;

namespace exo6
{
    class exo6
    {
       public static void Main(string[] args)  
        {
            for (int i = 10; i < 1000; i++)
            {
                HarsanMoran(i);
            }
        }

        public static bool IsPrime(int n)
        {
            int a = 0;
            for (int i = 1; i <= n; i++) 
            {
                if (n % i == 0) 
                {
                a++;
                }
            }
            if (a == 2) 
            {
                return true;
            } 
            else 
            {
                return false;
            }
            Console.ReadLine();
        }

        public static void HarsanMoran(int x)  
        {
            int number, r, sum;
            sum = 0;
            number = x;
            while(number>0)      
            {      
                r = number % 10;    
                sum = sum + r;
                number = number / 10;   
            }
            if(x % sum == 0 && IsPrime(sum) == false)
            {
                Console.WriteLine($"{x}, is an Harsad number");
            }
            else if (x % sum == 0 && IsPrime(sum) == true)
            {
                Console.WriteLine($"{x}, is an Moran number");
            }
            else
            {
                Console.WriteLine("Nothing");
            }
    }
    }
}
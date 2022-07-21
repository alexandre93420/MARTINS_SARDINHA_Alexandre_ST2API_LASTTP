using System;

namespace exo1
{
    class exo1
    {
    public static void Main(string[] args)  
    {
        int number, r, sum;
        for (int i = 100; i < 1000; i++)
        {
            sum = 0;
            number = i;
            while(number>0)      
            {      
                r=number%10;      
                sum=sum+(r*r*r);      
                number=number/10;      
            }
            if(i==sum)   
            Console.WriteLine($"{i}, is an armstrong number"); 
        }
    }
    }
}
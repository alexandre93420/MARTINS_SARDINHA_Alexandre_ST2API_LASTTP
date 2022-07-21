using System;
using System.Linq;

namespace Overpay
{
    class Program
    {
        static void Main(string[] args)
        {
            double h_rate = 10.2;
            double h_overrate = 20.5;
            double pay = 0.0;

            pay = OverpayCalculator(9.5,18,10,2.2);
            Console.WriteLine($"(Start,End,Rate,Overate) = {pay}");
            pay = OverpayCalculator(15,18,10,1.5);
            Console.WriteLine($"(Start,End,Rate,Overate) = {pay}");
            pay = OverpayCalculator(9,13.5,8.2,3);
            Console.WriteLine($"(Start,End,Rate,Overate) = {pay}");



            for (double i = 9.0;i<=20.0;i+=1.0) {
                for (double j = i; j<=20.0 ; j+=1.0) {
                    pay = OverpayCalculator(i,j,h_rate,h_overrate);
                    Console.WriteLine($"(Start,End,Rate,Overate) => OverpayCalculator({i};{j};{h_rate};{h_overrate}) = {pay}");
                }
            }         
        }

        public static double OverpayCalculator(
            double start, 
            double end, 
            double rate,
            double overrate
        )
        {
            double salary = 0.0 ;
            double newstart = 0.0 ;

            if (start > end) return -1;
            if ((9.0 > start) || (start >24.0)) return -2;
            if ((9.0 > end) || (end >24.0)) return -3;

            if (end > 12.5) {
                if (12.5 >= start)
                    salary += (12.5-start)*rate;
                if (end > 14.0) {
                    if (14.0 >= start)
                        newstart = 14.0;
                    else
                        newstart = start;
                    if (end > 17.0) {
                        if (17.0 >= newstart) {
                            salary += (17.0-newstart)*rate;
                            salary += (end-17.0)*overrate*rate;
                        } else
                            salary += (end-newstart)*overrate*rate;
                    } else {
                        salary += (end-newstart)*rate;
                    }
                } 
                /*else {
                    return salary;
                }*/
            } else {
                salary += (end-start)*rate;
            }

            return Math.Round(salary,0);
        }
    }

}
using System;

namespace exo7
{
    class exo7
    {
       public static void Main(string[] args)  
        {
            double tots = OverpayCalculator(15,18,10,1.5);

            Console.WriteLine(tots);
            
            
        }
        
        public static double OverpayCalculator(double start, double end, double rate, double multpilier)
        {
            double salary = 0;
            double morning, afternoon, afternoon1 = 0, overtime = 0;
            double hsupp = rate*multpilier;
            if(start > end)
            {
                return -1;
            }
            if(rate < 0 || multpilier < 0)
            {
                return -1;
            }
            if((9.0 >= start) && (start >= 24.0))
            { 
                return -1;
            }
            if((9.0 >= end) && (end >= 24.0))
            { 
                return -1;
            }
            // cas normal
            if((9.0 <= start) && (start <= 12.5) && (12.5 <= end) && (end <= 14))
            {
                morning = 12.5 - start;
                afternoon = end - 14;
                if (afternoon > 3)
                {
                    overtime = afternoon - 3;
                    afternoon1  = afternoon - overtime;
                }
                salary = ((morning*rate) + (afternoon1*rate)  + (overtime * hsupp));
            }
            //cas où il fini avant la pause dej
            if (end <= 12.5)
            {
                morning = end - start;
                salary = (morning*rate);
            }
            //cas où il fini pendant la pause dej
            if ((12.5 <= end) && (end <= 14))
            {
                morning = 12.5 - start;
                salary = (morning*rate);
            }
            // cas où il commence pendant la pause dej
            if ((12.5 <= start) && (start <= 14))
            {
                 afternoon = end - 14;
                 if (afternoon > 3)
                 {
                    overtime = afternoon - 3;
                    afternoon1  = afternoon - overtime;
                    salary = ((afternoon1*rate)  + (overtime * hsupp));
                 }
                 else
                 {
                    salary = (afternoon*rate);
                 }
            }
            //cas où il commence après la pause dej
            if(start >= 14)
            {
                afternoon = end - start;
                overtime = end - 17;
                afternoon1  = afternoon - overtime;
                salary = ((afternoon1*rate)  + (overtime * hsupp));
                
            }

            return salary;
        }
    }
}


// Heure de depart 9h30
//Pause a 12h30
//Fin de pause a 14h
//Heure de fin 17h
//heure supp 1h
//depart à midi = 3h
//fin de pause a 17h = 3h
//
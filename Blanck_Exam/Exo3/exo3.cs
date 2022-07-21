using System;

namespace exo3
{
    class exo3
    {
        public static void Main(string[] args)  
        {
            Random r = new Random(); 
            List<int> score = new List<int>();
            for (int i = 0; i < 5; i++)
                {
                    var roll = r.Next(1, 7);
                    Console.WriteLine($"{roll}");
                    if (roll == 4)
                    {
                        score.Add(roll);
                    }
                    if (roll == 2)
                    {
                        score.Add(roll);
                    }
                    if (roll == 1)
                    {
                        score.Add(roll);
                    }
                }
            Console.WriteLine(score);

        }
    }
}


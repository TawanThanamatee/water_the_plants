using System;

namespace water_the_plants
{
    class Program
    {
        static void Main(string[] args)
        {
            //There are five trees in one row.
            Console.Write("Tree_row : ");
            int tree = int.Parse(Console.ReadLine());
            Console.Write("Time : ");
            double time = double.Parse(Console.ReadLine());
            Console.Write("Rain : ");
            bool rain = bool.Parse(Console.ReadLine());

            if (time == 8.00 && rain != true || time == 16.00 && rain != true)
            {
                for (int water_the_plants_row = 0; water_the_plants_row < tree; water_the_plants_row++)
                {
                    for (int water_the_plants_collum = 0; water_the_plants_collum < 5; water_the_plants_collum++)
                    {
                        Console.Write(" ");
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else if(rain == true)
            {
                Console.WriteLine("it's raining.");
            }
            else if(time != 8.00 || time != 16.00)
            {
                Console.WriteLine("Not time.");
            } 
        }
    }
}

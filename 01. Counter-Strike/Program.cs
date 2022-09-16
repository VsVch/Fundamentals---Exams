using System;

namespace CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialEnergy = double.Parse(Console.ReadLine()); 
            int count = 0;

            string command = Console.ReadLine();

            while (command != "End of battle")
            {
                double distance = double.Parse(command);
                if (initialEnergy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {count} won battles and {initialEnergy} energy");
                    initialEnergy -= distance;
                    break;
                }
                initialEnergy -= distance;

                count++;

                if (count % 3 == 0)
                {initialEnergy += count;}

                command = Console.ReadLine();
            }

            if (initialEnergy >= 0) 
            {
                Console.WriteLine($"Won battles: {count}. Energy left: {initialEnergy}");
            }

        }
    }
}
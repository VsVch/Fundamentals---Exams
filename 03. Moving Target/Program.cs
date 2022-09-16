using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] command = input.Split();
                string action = command[0];
                int index = int.Parse(command[1]);
                int powerValueRadius = int.Parse(command[2]);

                if (action == "Shoot")
                {
                    

                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers[index] -= powerValueRadius;

                        if (numbers[index] <= 0)
                        {
                            numbers.RemoveAt(index);
                        }
                    }
                }
                else if (action == "Add")
                {
                   

                    if (index >= 0 && index < input.Length)
                    {
                        numbers.Insert(index, powerValueRadius);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (action == "Strike")
                {
                    

                    if (index - powerValueRadius >= 0 && index + powerValueRadius < numbers[numbers.Count - 1])
                    {
                        //Console.WriteLine(string.Join(" ", numbers));
                        //Console.WriteLine($"=====================================");
                        numbers.RemoveRange(index - powerValueRadius, powerValueRadius * 2 + 1);
                        //Console.WriteLine(string.Join(" ", numbers));
                        //Console.WriteLine($"=====================================");
                    }
                    else
                    {
                        Console.WriteLine($"Strike missed!");
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join("|", numbers));

        }
    }
}

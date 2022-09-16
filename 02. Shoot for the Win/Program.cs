using System;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int
                .Parse).ToArray();
            int count = 0;

            string input = Console.ReadLine();
            while (input != "End")
            {
                int indexes = int.Parse(input);
                if (indexes >= 0 & indexes < numbers.Length)
                {
                    
                    
                    int cur = numbers[indexes];
                    for (int i = 0; i < numbers.Length ; i++)
                    {
                        if (numbers[i] != -1 & i != indexes)
                        {
                            if ( cur >= numbers[i])
                            {
                                numbers[i] = numbers[i] + cur;
                            }
                            else if (cur < numbers[i])
                            {
                                numbers[i] = numbers[i] - cur;
                            }
                        }
                        
                    }
                    count++;
                    numbers[indexes] = -1;

                }

                input = Console.ReadLine();

            }

            Console.Write($"Shot targets {count} -> ");
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

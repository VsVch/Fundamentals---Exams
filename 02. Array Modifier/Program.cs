using System;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] command = input.Split();
                string action = command[0];
                if (action == "swap")
                {
                    int index1 = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);
                    int cur = numbers[index1];
                    numbers[index1] = numbers[index2];
                    numbers[index2] = cur;

                }
                if (action == "multiply")
                {
                    int index1 = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);
                    int multi = numbers[index1] * numbers[index2];
                    numbers[index1] = multi;
                }
                if (action == "decrease")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = numbers[i] - 1;
                    }

                }


                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ",numbers));

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> ansers = new List<int>();
            StringBuilder ans = new StringBuilder();

            double average = 0;


            if (numbers.Count <= 1)
            {
                Console.WriteLine("No");
                return;
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                average += numbers[i];
            }
            average = average / numbers.Count;

            int match = numbers.Where(x => x > average).ToArray().Count();
            if (match == 0)
            {
                Console.WriteLine("No");
            }
            else if (numbers.Count < 5)
            {
                Console.WriteLine($"Less than 5 numbers");
            }
            else
            {
                var result = numbers.OrderByDescending(x => x).Where(x => x > average).Take(5).ToArray();
                Console.WriteLine(string.Join(" ", result));

            }





            //Console.WriteLine(string.Join(" ", ansers));




        }
    }
}

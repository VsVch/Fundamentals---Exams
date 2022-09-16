using System;

namespace _01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeeEfficiency = int.Parse(Console.ReadLine());
            int secondEmployeeEfficiency = int.Parse(Console.ReadLine());
            int thirdEmployeeEfficiency = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int sumAllEfficiency = firstEmployeeEfficiency + secondEmployeeEfficiency + thirdEmployeeEfficiency;

            int hour = 0;
            while (studentsCount > 0)
            {
                studentsCount -= sumAllEfficiency;
                hour++;
                if (hour % 4 == 0)
                {
                    hour++;
                }




            }
            Console.WriteLine($"Time needed: {hour}h.");

        }
    }
}

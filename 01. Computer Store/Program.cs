using System;

namespace _01._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double currentPart = 0;
            double sum = 0;
            double vat = 0;
            double total = 0;

            while (input != "special" && input != "regular")
            {
                currentPart = double.Parse(input);
                if (currentPart < 0 )
                {
                    Console.WriteLine($"Invalid price!");
                    
                }
                else
                {
                    sum += currentPart;
                }
                input = Console.ReadLine();
                
            }
            if (sum == 0)
            {
                Console.WriteLine($"Invalid order!");
                return;
            }
            else
            {
                vat = 0.2 * sum;
                if (input == "special")
                {
                    total = sum + vat;
                    total = total * 0.9;

                }
                else if (input == "regular")
                {
                    total = sum + vat;
                }
            }

            Console.WriteLine($"Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {sum:f2}$");
            Console.WriteLine($"Taxes: {vat:f2}$");
            Console.WriteLine($"-----------");
            Console.WriteLine($"Total price: {total:f2}$");
            
        }
    }
}

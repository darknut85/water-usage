using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace water_usage
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            double b = 0;
            double c;
            double d;
            Console.WriteLine("Option 1 is 100 + 0,25 per m3.");
            Console.WriteLine("Option 2 is 75 + 0,38 per m3.");
            Console.WriteLine("Option 3 decides the cheaper of the 2 first options");
            while (a > 3 || a < 1)
            {
                try
                {
                    Console.WriteLine("Please choose the option 1 to 3. This decides the costs for water usage");
                    a = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid. Try again.");
                }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("What is your water usage?");
                    b = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid. Try again.");
                }
            }
            c = b * 0.25 + 100;
            d = b * 0.38 + 75;
            if (a == 1)
            {
                Console.WriteLine("The total costs is: " + c + " euro's.");
            }
            else if (a == 2)
            {
                Console.WriteLine("The total costs is: " + d + " euro's.");
            }
            else if (a == 3)
            {
                if (c > d)
                {
                    Console.WriteLine("The total costs is: " + d + " euro's.");
                }
                else
                {
                    Console.WriteLine("The total costs is: " + c + " euro's.");
                }
            }
        }
    }
}

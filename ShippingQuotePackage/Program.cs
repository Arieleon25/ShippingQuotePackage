using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuotePackage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");

            Console.WriteLine("Please enter the package weight");
            int Pkg_Weight = Convert.ToInt32(Console.ReadLine());

            if (Pkg_Weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the package width");
                int Pkg_Width = Convert.ToInt32(Console.ReadLine());    

                Console.WriteLine("Please enter the package height");
                int Pkg_Height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length");
                int Pkg_Lenght = Convert.ToInt32(Console.ReadLine());

                if (Pkg_Width > 50 || Pkg_Height > 50 || Pkg_Lenght > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                }
                else
                {
                    int finalOutcome = (Pkg_Height * Pkg_Width * Pkg_Lenght) * Pkg_Weight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + finalOutcome);
                }

            }

            Console.WriteLine("Thank you!");

            Console.ReadLine();
        }
    }
}

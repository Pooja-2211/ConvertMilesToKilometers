using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ConvertMilesToKilometers
{
    static void Main()
    {
        Console.WriteLine("Enter the number of miles:");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double miles))
        {
            double kilometers = ConvertToKilometers(miles);
            Console.WriteLine($"{miles} miles is equal to {kilometers} kilometers.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    static double ConvertToKilometers(double miles)
    {
        const double ConversionFactor = 1.60934;
        return miles * ConversionFactor;
    }
}


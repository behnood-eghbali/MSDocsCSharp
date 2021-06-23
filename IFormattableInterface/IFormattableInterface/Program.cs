﻿using System;
using System.Globalization;

namespace IFormattableInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use composite formatting with format string in the format item.
            Temperature temp1 = new Temperature(0);
            Console.WriteLine("{0:C} (Celsius) = {0:K} (Kelvin) = {0:F} (Fahrenheit)\n", temp1);

            // Use composite formatting with a format provider.
            temp1 = new Temperature(-40);
            Console.WriteLine(String.Format(CultureInfo.CurrentCulture, "{0:C} (Celsius) = {0:K} (Kelvin) = {0:F} (Fahrenheit)", temp1));
            Console.WriteLine(String.Format(new CultureInfo("fr-FR"), "{0:C} (Celsius) = {0:K} (Kelvin) = {0:F} (Fahrenheit)\n", temp1));

            // Call ToString method with format string.
            temp1 = new Temperature(32);
            Console.WriteLine("{0} (Celsius) = {1} (Kelvin) = {2} (Fahrenheit)\n",
                                temp1.ToString("C"), temp1.ToString("K"), temp1.ToString("F"));

            // Call ToString with format string and format provider
            temp1 = new Temperature(100);
            NumberFormatInfo current = NumberFormatInfo.CurrentInfo;
            CultureInfo nl = new CultureInfo("nl-NL");
            Console.WriteLine("{0} (Celsius) = {1} (Kelvin) = {2} (Fahrenheit)",
                                temp1.ToString("C", current), temp1.ToString("K", current), temp1.ToString("F", current));
            Console.WriteLine("{0} (Celsius) = {1} (Kelvin) = {2} (Fahrenheit)",
                                temp1.ToString("C", nl), temp1.ToString("K", nl), temp1.ToString("F", nl));
        }
    }
    // The example displays the following output:
    //    0.00 °C (Celsius) = 273.15 K (Kelvin) = 32.00 °F (Fahrenheit)
    //
    //    -40.00 °C (Celsius) = 233.15 K (Kelvin) = -40.00 °F (Fahrenheit)
    //    -40,00 °C (Celsius) = 233,15 K (Kelvin) = -40,00 °F (Fahrenheit)
    //
    //    32.00 °C (Celsius) = 305.15 K (Kelvin) = 89.60 °F (Fahrenheit)
    //
    //    100.00 °C (Celsius) = 373.15 K (Kelvin) = 212.00 °F (Fahrenheit)
    //    100,00 °C (Celsius) = 373,15 K (Kelvin) = 212,00 °F (Fahrenheit)
}

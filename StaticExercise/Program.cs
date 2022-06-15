using System;

namespace StaticExercise
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Converting Farenheit to Celsius");
            double FTemp = Convert.ToDouble(Console.ReadLine());
            double convertToCelsius = TempConverter.FarenheitToCelsius(FTemp);
            Console.WriteLine($"{FTemp} Farenheit is {convertToCelsius} Celsius");
            Console.WriteLine($"Converting Celsius to Farenheit");
            double CTemp = Convert.ToDouble(Console.ReadLine());
            double convertToFarenheit = TempConverter.CelsiusToFarenheit(CTemp);
            Console.WriteLine($"{CTemp} Celsius is {convertToFarenheit} Farenheit");
          

        }
    }
}

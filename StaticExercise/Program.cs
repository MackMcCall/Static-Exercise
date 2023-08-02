using System.Diagnostics;

namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to temp converter!\nPress 1 for F to C\nPress 2 for C to F");
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid Input, Try Again");
            }
            Console.WriteLine("What number are you converting?");
            if (!double.TryParse(Console.ReadLine(), out double temp))
            {
                Console.WriteLine("Invalid Input, Try Again");
            }
            switch (choice)
            {
                case 1:
                    Console.WriteLine(TempConverter.FahrenheitToCelsius(temp));
                    break;
                case 2:
                    Console.WriteLine(TempConverter.CelsiusToFahrenheit(temp));
                    break;
                default:
                    Console.WriteLine("Please choose 1 or 2 to convert F to C, or C to F.");
                    return;
            }
            //switch (input)
            //{
            //    case 1:
            //        if (!double.TryParse(Console.ReadLine(), out double fTemp))
            //        {
            //            Console.WriteLine("Invalid Input, Try Again");
            //        }
            //        fTemp = TempConverter.FahrenheitToCelsius(fTemp);
            //        Console.WriteLine(fTemp);
            //        break;
            //    case 2:
            //        if (!double.TryParse(Console.ReadLine(), out double cTemp))
            //        {
            //            Console.WriteLine("Invalid Input, Try Again");
            //        }
            //        cTemp = TempConverter.CelsiusToFahrenheit(cTemp);
            //        Console.WriteLine(cTemp);
            //        break;
            //    default:
            //        return;
        }
    }
}

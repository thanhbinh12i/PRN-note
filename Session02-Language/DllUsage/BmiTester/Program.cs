using Bmi;

namespace BmiTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Bình!");
            Console.WriteLine($"Bmi: {BmiCalculator.GetBmi(62, 1.67)}"); 
        }
    }
}

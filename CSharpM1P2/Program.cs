using System;

namespace CSharpM1P2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number between 1-255: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter a number between 1-255: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }
    }
}

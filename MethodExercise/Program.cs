using System;

namespace MyApp // Methods Excercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string userColor = Console.ReadLine();

            Console.WriteLine("What is your favorite type of animal?");
            string userAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite kind of music?");
            string userMusic = Console.ReadLine();

            Console.WriteLine($"There was a man named (userName), He loved the color (userColor).");
            Console.WriteLine($"His favorite animal was a (userAnimal).");
            Console.WriteLine($"Him and his (userAnimal) listened to (userMusic) together.");

            Console.WriteLine("give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"the sum is: (sum)");

            Console.WriteLine("give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("give me a number to multiply to the first one");
            num2 = int.Parse(Console.ReadLine());

            int product = Sum(num1, num2);
            Console.WriteLine($"the sum is: (sum));

            Console.WriteLine("give me number");
            int num1 = int.Parse(Console.ReadLine());












        { }
        public static int Sum(int num1, int num2)
        {
            //int sum = num1 + num2;
            //return sum;
            return num1 + num2;
         public    
        }
    }


}
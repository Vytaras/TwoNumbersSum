using System;


namespace TwoNmubersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input data:");

            var line = Console.ReadLine();
            var numbersTemp = line.Split(' ');
            var numbers = Array.ConvertAll(numbersTemp, int.Parse);

            Console.WriteLine("answer: \r\n" + (numbers[0] + numbers[1]));
        }
    }
}

using System;
using ProblemOne.Classes;

namespace ProblemOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Answer is: {0}", NaturalNumbers.NaturalNumbersSum(NaturalNumbers.GenerateNaturalNumbers(1000)));
            Console.ReadLine();
        }
    }
}

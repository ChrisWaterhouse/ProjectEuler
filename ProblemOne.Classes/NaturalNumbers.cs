using System;
using System.Collections.Generic;

namespace ProblemOne.Classes
{
    public class NaturalNumbers
    {
        public static List<int> GenerateNaturalNumbers(int limiter)
        {
            List<int> numberList = new List<int>();

            for (int i = 0; i < limiter; i += 3)
            {
                if (i % 5 == 0) continue;
                else numberList.Add(i);
            }

            for (int i = 0; i < limiter; i += 5) numberList.Add(i);

            return numberList;
        }

        public static int NaturalNumbersSum(List<int> values)
        {
            int sum = 0;

            foreach (int value in values) sum += value;

            return sum;
        }
    }
}

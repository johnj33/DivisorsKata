using System;
using System.Collections.Generic;


namespace DivisorsKata
{
    public class DivisorCalculator
    {
        public int[] Calculate(int inputNumber)
        {
            List<int> divisor = new List<int>();
  
            for (int x = 1; x <= inputNumber; x++)
            {
                if (inputNumber%x == 0)
                {
                    divisor.Add(inputNumber);
                }
              
            }
            return divisor.ToArray();
        }
    }
}


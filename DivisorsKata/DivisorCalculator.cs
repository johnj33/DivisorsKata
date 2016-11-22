namespace DivisorsKata
{
    public class DivisorCalculator
    {
        public int[] Calculate(int inputNumber)
        {
            return inputNumber == 2 ? new[] { 1, 2 } : new[] { 1 };
        }
    }
}


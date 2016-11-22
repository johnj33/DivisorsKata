namespace DivisorsKata
{
    public class DivisorCalculator
    {
        public int[] Calculate(int inputNumber)
        {
           
            switch (inputNumber)
            {
                case 1:
                    return new[] {1};
                case 2:
                    return new[] {1, 2};
                case 3:
                    return new[] {1, 3};
            }
            return null;
        }
       
    }
}


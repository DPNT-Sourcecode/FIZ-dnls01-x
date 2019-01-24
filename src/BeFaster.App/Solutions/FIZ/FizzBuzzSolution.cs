using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            if ((number % 3 == 0) && (number % 5 == 0))
            {
                return "fizz buzz";
            }
            else if (number % 3 == 0)
            {
                return "fizz";
            }
            else if (number % 5 == 0)
            {
                return "buzz";
            }
            else
            {
                return number.ToString();
            }
        }
    }
}


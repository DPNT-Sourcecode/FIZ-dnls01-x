using BeFaster.Runner.Exceptions;
using System;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
           
            if (number >= 1 && number <= 9999)
            {
                string numberAsString = Convert.ToString(number);
                if ((number % 3 == 0 || numberAsString.Contains("3")) && (number % 5 == 0 || numberAsString.Contains("5")))
                {
                    return "fizz buzz";
                }
                else if ((number % 3 == 0) && (number % 5 == 0))
                {

                    return "fizz buzz";
                }
                
                else if (number % 3 == 0 || numberAsString.Contains("3"))
                {
                    return "fizz";
                }
               
                else if (number % 5 == 0 || numberAsString.Contains("5"))
                {
                    return "buzz";
                }
                else
                {
                    return number.ToString();
                }
            }
            return number.ToString();
        }
    }
}

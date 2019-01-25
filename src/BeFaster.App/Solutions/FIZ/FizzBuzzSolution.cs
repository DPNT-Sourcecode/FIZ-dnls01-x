using System;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            string output = string.Empty;
            string numberAsString = Convert.ToString(number);
            if (number % 3 == 0 || numberAsString.Contains("3"))
            {
                if (output.Length != 0)
                {
                    output = output + " " + "fizz";
                }
                else
                {
                    output = "fizz";
                }
            }

            if (number % 5 == 0 || numberAsString.Contains("5"))
            {
                if (output.Length != 0)
                {
                    output = output + " " + "buzz";
                }
                else
                {
                    output = "buzz";
                }
            }

            if ((number % 3 == 0 && numberAsString.Contains("3")) || ((number % 5 == 0 && numberAsString.Contains("5"))))
            {
                if (number % 2 != 0)
                {
                    if (output.Length != 0)
                    {
                        output = output + " " + "fake deluxe";
                    }
                    else
                    {
                        output = output + " " + "fake deluxe";
                    }
                }
                else
                {
                    if (output.Length != 0)
                    {
                        output = output + " " + "deluxe";
                    }
                    else
                    {
                        output = "deluxe";
                    }
                }
                return output;
            }
            else
            {

                return numberAsString;
            }
        }
    }
}

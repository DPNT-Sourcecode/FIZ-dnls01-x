using BeFaster.Runner.Exceptions;
using System;
using System.Linq;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            string numberAsString = Convert.ToString(number);
            string output = string.Empty;

            if (number >= 10 && number <= 9999)
            {

                if (FizzBuzzSolution.AllCharactersAreSame(numberAsString))
                {
                    if (number % 3 == 0 && numberAsString.Contains("3") || (number % 5 == 0 && numberAsString.Contains("5")))
                    {
                        if (number % 2 != 0)
                        {
                            if (!string.IsNullOrEmpty(output))
                                output = output + "fake deluxe";
                            else
                                output = "fake deluxe";
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(output))
                                output = output + "deluxe";
                            else
                                output = "deluxe";

                        }
                    }
                }

                else if ((number % 3 == 0 || numberAsString.Contains("3")) && (number % 5 == 0 || numberAsString.Contains("5")))
                {
                    output = "fizz buzz";
                    output = OutPutDeluxe(number, numberAsString, output);

                }
                else if ((number % 3 == 0) && (number % 5 == 0))
                {

                    output = "fizz buzz";
                    output = OutPutDeluxe(number, numberAsString, output);
                }

                else if (number % 3 == 0 || numberAsString.Contains("3"))
                {
                    output = "fizz";
                    output = OutPutDeluxe(number, numberAsString, output);
                }

                else if (number % 5 == 0 || numberAsString.Contains("5"))
                {
                    output = "buzz";
                    output = OutPutDeluxe(number, numberAsString, output);
                }
                else
                {
                    return number.ToString();
                }

                if (!string.IsNullOrEmpty(output))
                    return output;
                return number.ToString();
            }
            return number.ToString();
        }

        private static string OutPutDeluxe(int number, string numberAsString, string output)
        {
            if (number >= 10 && number <= 9999)
            {

                if (FizzBuzzSolution.AllCharactersAreSame(numberAsString))
                {

                    if (number % 3 == 0 && numberAsString.Contains("3") || (number % 5 == 0 && numberAsString.Contains("5")))
                    {
                        if (number % 2 != 0)
                        {
                            if (!string.IsNullOrEmpty(output))
                                output = output + " " + "fake deluxe";
                            else
                                output = "fake deluxe";
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(output))
                                output = output + " " + "deluxe";
                            else
                                output = "deluxe";

                        }
                    }
                }
            }

            return output;
        }

        public static bool AllCharactersAreSame(string numberinStringFormat)
        {
            return numberinStringFormat.Length == 0 || numberinStringFormat.All(charactres => charactres == numberinStringFormat[0]);
        }
    }
}




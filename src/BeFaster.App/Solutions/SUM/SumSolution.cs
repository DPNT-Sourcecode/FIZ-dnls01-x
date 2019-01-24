using BeFaster.Runner.Exceptions;
using System;

namespace BeFaster.App.Solutions.SUM
{
    public static class SumSolution
    {
        public static int Sum(int x, int y)
        {
            bool IsfirsNumberValid = ValidNumber(x);
            bool IsSecondNumberValid = ValidNumber(y);
            if (IsfirsNumberValid && IsSecondNumberValid)
                return (x + y);
            throw new NotSupportedException();
        }

        private static bool ValidNumber(int num)
        {
            if (num >= 0 && num <= 100)
                return true;
            return false;
        }
    }
}


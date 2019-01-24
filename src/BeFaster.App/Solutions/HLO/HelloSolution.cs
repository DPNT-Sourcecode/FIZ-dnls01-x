using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.HLO
{
    public static class HelloSolution
    {
        public static string Hello(string friendName)
        {
            if (!string.IsNullOrWhiteSpace(friendName))
                return $"Hello, {friendName}";
            return string.Empty;
        }
    }
}





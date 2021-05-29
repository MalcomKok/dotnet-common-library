using System.Collections.Generic;
using System.Linq;

namespace DotnetCommonLibrary.Extensions
{
    public static class InterviewCodeChallengeExtensions
    {
        public static void FizzBuzz(this List<int> intList, int firstMultiple, int secondMultiple) => intList.Select(x => FizzBuzz(x, firstMultiple, secondMultiple));

        public static string FizzBuzz(this int intValue, int firstMultiple, int secondMultiple)
        {
            var isFirstMultipleValid = intValue % firstMultiple == 0;
            var isSecondMultipleValid = intValue % secondMultiple == 0;

            if (isFirstMultipleValid && isSecondMultipleValid)
                return "FIZZBUZZ";
            else if (isFirstMultipleValid)
                return "FIZZ";
            else if (isSecondMultipleValid)
                return "BUZZ";
            else
                return $"{intValue}";
        }
    }
}

using System;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        public static int GetFactorial(int n) {
            int result = 1;

            // loop and multiply from top position to 2nd bottom position,
            // input 4 = 1*4*3*2 = output 24
            for (int i = n; i > 1; i--)
            {
                result *= i;
            }

            return result;
        }

        public static string FormatSeparators(params string[] items)
        {
            var result = string.Empty;
            var index = 0;
            
            // input "a", "b", "c" becomes output "a, b and c"
            // generate output format string
            foreach(var item in items)
            {
                result += "{" + index++ + "}, ";
            }
            // trim trailing comma and spaces
            result = result.Substring(0, result.Length - 2);
            // add ' and ' for the last 2 numbers
            if (items.Length > 1)
            {
                result = result.Replace(", {" + (items.Length - 1).ToString() + "}", " and " + items[items.Length - 1]);
            }
            // replace input values in the expected locations
            result = String.Format(result, items);

            return result;
        }
    }
}
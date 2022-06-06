// https://www.codewars.com/kata/556deca17c58da83c00002db

namespace Codewars.Exercises.Exercises
{
    public static class TribonacciSequence
    {
        public static double[] Tribonacci(Span<double> signature, int n)
        {
            Span<double> result = stackalloc double[n + 3];
            signature.CopyTo(result);
            for (int i = 3; i < n; i++)
            {
                result[i] = result[i - 1] + result[i - 2] + result[i - 3];
            }
            return result.Slice(0, n).ToArray();
        }
    }
}

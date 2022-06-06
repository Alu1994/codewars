// https://www.codewars.com/kata/54da5a58ea159efa38000836

namespace Codewars.Exercises.Exercises
{
    public static class FindTheOddInt
    {
        public static int find_it(int[] seq)
        {
            var result = seq.GroupBy(x => new { number = x }).FirstOrDefault(x => x.Count() % 2 != 0);
            if (result is not null) return result.Key.number;
            return 0;
        }
    }
}

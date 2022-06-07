// https://www.codewars.com/kata/52bc74d4ac05d0945d00054e

using System.Linq;

namespace Codewars.Exercises.Exercises
{
    public static class FirstNonRepeatingCharacter
    {
        public static string Solution(string word)
        {
            var item = word
                .GroupBy(char.ToUpperInvariant)
                .FirstOrDefault(x => x.Count() is 1);
            return item is null ? string.Empty : item.First().ToString();
        }

        public static string Solution2(string word)
        {
            return word
                .GroupBy(char.ToUpper)
                .FirstOrDefault(x => x.Count() is 1)
                ?.First().ToString() ?? string.Empty;
        }

        public static string Solution3(string s)
        {
            return s.GroupBy(char.ToLower)
                    .Where(gr => gr.Count() is 1)
                    .Select(x => x.First().ToString())
                    .DefaultIfEmpty("")
                    .First();
        }
    }
}

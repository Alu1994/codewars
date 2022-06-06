// https://www.codewars.com/kata/55c45be3b2079eccff00010f

namespace Codewars.Exercises.Exercises
{
    public static class YourOrderPlease
    {
        public static string Order(string words)
        {
            if (string.IsNullOrWhiteSpace(words)) return string.Empty;
            return string.Join(" ", words.Split(" ")
                .Select(word => new
                {
                    Index = string.IsNullOrWhiteSpace(words) ? 0 : word.Select(x => char.IsNumber(x) ? (int)(x - '0') : 0).First(x => x > 0),
                    Word = word
                })
                .OrderBy(x => x.Index)
                .Select(x => x.Word));
        }

        // Better Solution
        public static string OrderSingle(string words)
        {
            return string.Join(" ", words.Split().OrderBy(w => w.SingleOrDefault(char.IsNumber)));
        }
    }
}

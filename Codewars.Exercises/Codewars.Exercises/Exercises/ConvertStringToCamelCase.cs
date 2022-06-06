// https://www.codewars.com/kata/517abf86da9663f1d2000003

namespace Codewars.Exercises.Exercises
{
    public static class ConvertStringToCamelCase
    {
        public static string ToCamelCase(ReadOnlySpan<char> str)
        {
            Span<char> result = new char[str.Length];
            bool isNextWordUpper = false;
            for (int oldSpanIndex = 0, newSpanIndex = 0; oldSpanIndex < str.Length; oldSpanIndex++, newSpanIndex++)
            {
                if (oldSpanIndex is 0)
                {
                    str.Slice(oldSpanIndex, 1).CopyTo(result.Slice(newSpanIndex));
                    continue;
                }

                isNextWordUpper = str.Slice(oldSpanIndex, 1).StartsWith("-") || str.Slice(oldSpanIndex, 1).StartsWith("_");
                if (isNextWordUpper)
                {
                    str.Slice(++oldSpanIndex, 1).ToUpper(result.Slice(newSpanIndex), System.Globalization.CultureInfo.InvariantCulture);
                    continue;
                }
                str.Slice(oldSpanIndex, 1).ToLower(result.Slice(newSpanIndex), System.Globalization.CultureInfo.InvariantCulture);
                continue;
            }
            return result.TrimEnd('\0').ToString();
        }
    }
}

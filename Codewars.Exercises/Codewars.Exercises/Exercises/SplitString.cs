// https://www.codewars.com/kata/515de9ae9dcfc28eb6000001

using System;
using System.Collections.Generic;
using System.Linq;

namespace Codewars.Exercises.Exercises
{
    //* 'abc' =>  ['ab', 'c_']
    //* 'abcdef' => ['ab', 'cd', 'ef']

    public static class SplitString
    {
        public static string[] Solution(string str)
        {
            if (str.Length % 2 == 1)
                str += "_";

            return SolutionInternal(str).ToArray();
            
            IEnumerable<string> SolutionInternal(string str)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    yield return $"{str[i]}{str[++i]}";
                }
            }
        }

        // Other Solution
        public static string[] SolutionOther(string str)
        {
            if (str.Length % 2 != 0)
                str += "_";
            return Enumerable.Range(0, str.Length)
              .Where(x => x % 2 == 0)
              .Select(x => str.Substring(x, 2))
              .ToArray();
        }
    }
}

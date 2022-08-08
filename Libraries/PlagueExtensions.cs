using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;

namespace Libraries
{
    internal static class PlagueExtensions
    {
        internal static List<T> GetFromTo<T>(this List<T> list, int from, int to)
        {
            var NewList = new List<T>();

            // Start At Value Of From, Enum To Value Of To
            for (var i = from; i < to; i++)
            {
                if ((list.Count - 1) < i) // When From Hits Max Index
                {
                    break;
                }

                NewList.Add(list[i]);
            }

            return NewList;
        }

        internal static string MakeAlphaNumeric(this string input, params char[] exceptions)
        {
            var charArray = input.ToCharArray();

            var alphaNumeric = Array.FindAll<char>(charArray, c => char.IsLetterOrDigit(c) || exceptions?.Contains(c) == true);

            return new string(alphaNumeric);
        }

        internal static bool MultilineContainsExactTextToLower(this string multilineinput, string containsthis)
        {
            if (multilineinput == null)
            {
                return false;
            }

            if (multilineinput.Length < 2)
            {
                return false;
            }

            if (!multilineinput.Contains("\n"))
            {
                return false;
            }

            var list = multilineinput.Split('\n').Distinct().ToList();

            for (int i = 0; i < list.Count; i++)
            {
                string String = list[i];
                if (string.Equals(String, containsthis, StringComparison.CurrentCultureIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        internal static int ToRgb(this Color color)
        {
            return int.Parse(ColorTranslator.ToHtml(System.Drawing.Color.FromArgb(color.ToArgb())).Replace("#", ""),
                NumberStyles.HexNumber);
        }

        //Use This To Check If A World Is Fully Defined When Some Letter Vary
        internal static bool IsTermFullyDefined(this string text, string term, int expectedLength, string[] disallowedText)
        {
            string result = text.Substring(text.IndexOf(term), expectedLength);

            foreach (string disallowed in disallowedText)
            {
                if (result.Contains(disallowed))
                {
                    return false;
                }
            }

            return true;
        }
        
        //A Safe Replace Method
        internal static string ReplaceAtIndex(this string Source, string oldChar, string newChar, int indexJustBeforeoldChar)
        {
            if (indexJustBeforeoldChar == -1)
            {
                return Source;
            }

            string result = Source.Remove(indexJustBeforeoldChar, oldChar.Length).Insert(indexJustBeforeoldChar, newChar);

            return result;
        }

        internal static string ReplaceLast(this string Source, string oldChar, string newChar)
        {
            int place = Source.LastIndexOf(oldChar);

            if (place == -1)
            {
                return Source;
            }

            string result = Source.Remove(place, oldChar.Length).Insert(place, newChar);

            return result;
        }

        internal static string GetTextAfter(this string sourceString, string getTextAfterThis, int lengthOfWhatToGetAfterPrevString = 90000)
        {
            if (lengthOfWhatToGetAfterPrevString == 90000)
            {
                return sourceString.Substring(sourceString.IndexOf(getTextAfterThis) + getTextAfterThis.Length);
            }

            if (lengthOfWhatToGetAfterPrevString < sourceString.Length)
            {
                return sourceString.Substring(sourceString.IndexOf(getTextAfterThis) + getTextAfterThis.Length, lengthOfWhatToGetAfterPrevString);
            }

            return null;
        }

        internal static string GetToEndOfLine(this string sourceString)
        {
            return sourceString.Substring(0, sourceString.IndexOf("\n")).Replace("\r", "");
        }

        internal static bool ContainsAllOf(this string input, string[] terms)
        {
            if (terms.All(o => input.ToLower().Contains(o.ToLower())))
            {
                return true;
            }

            return false;
        }
        
        internal static bool FastestCaseSensitiveContains(this IEnumerable<string> input, string text)
        {
            if (input.Any(o => string.CompareOrdinal(o, text) == 0))
            {
                return true;
            }

            return false;
        }
        
        internal static bool FastestCaseInsensitiveContains(this IEnumerable<string> input, string text)
        {
            if (input.Any(o => o.Equals(text)))
            {
                return true;
            }

            return false;
        }

        internal static string ConvertToString(this byte[] array)
        {
            if (array != null && array.Length > 0)
            {
                return System.Text.Encoding.UTF8.GetString(array);
            }

            return "";
        }
    }
}

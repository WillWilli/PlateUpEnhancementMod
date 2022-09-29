using System;

namespace Willi.PlateUpEnhancementMod.Extensions
{
    internal static class StringExtensions
    {
        public static bool Contains(this string str, string substring, StringComparison comp)
        {
            if (substring == null)
                throw new ArgumentNullException("substring",
                                             "substring cannot be null.");
            else if (!Enum.IsDefined(typeof(StringComparison), comp))
                throw new ArgumentException("comp is not a member of StringComparison",
                                         "comp");

            return str.IndexOf(substring, comp) >= 0;
        }
    }
}

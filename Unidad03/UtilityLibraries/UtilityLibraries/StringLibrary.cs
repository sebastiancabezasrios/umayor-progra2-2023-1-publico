using System;
namespace UtilityLibraries
{
    public static class StringLibrary
    {
        public static bool StartsWithUpper(this string? _str)
        {
            if (string.IsNullOrWhiteSpace(_str))
            {
                return false;
            }

            char ch = _str[0];
            return char.IsUpper(ch);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MusicPlayer.Extensions
{
    public static class StringExtensions
    {
        // This is for convenience only

        public static bool IsNumber(this string value)
        {
            if (value == null)
                return false;

            var regex = new Regex("^[0-9]+$");
            if (regex.IsMatch(value))
                return true;
            return false;
        }

    }
}

using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ShoppingCart.Domain.Utilities
{
    public static class StringUtilities
    {   
        private static readonly char[] illegalCharacters = { '!', '@', '#' };


    private static readonly char[] toTrimCharacter = { ' ', '\n', '\t' };
        public static bool IsNullOrEmptyOrWhiteSpace(this string? input)
        {
            return string.IsNullOrWhiteSpace(input);
        }
        public static bool NotNullOrEmptyOrWhiteSpace(this string? input)
        {
            return !string.IsNullOrWhiteSpace(input) is false;
        }
        public static bool ContainsIllegalCharacters(this string input)
        {
            return input.Any(x => illegalCharacters.Contains(x));
        }
        public static bool ContainsToTrimCharacters(this string input)
        {
            return input.Any(x => toTrimCharacter.Contains(x));
        }
        public static bool ContainsDigit(this string input)
        {
            return input.Any(x => char.IsDigit(x));
        }
    }

}

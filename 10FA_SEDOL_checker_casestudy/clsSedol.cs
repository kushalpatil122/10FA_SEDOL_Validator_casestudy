using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10FA_SEDOL_Validator_casestudy
{
    public class clsSedol
    {
        private readonly string _value;
        private readonly List<int> _weights;
        private const int CHECK_DIGIT_IDX = 6;
        private const int SEDOL_LENGTH = 7;
        private const int USER_DEFINED_IDX = 0;
        private const char USER_DEFINED_CHAR = '9';

        /// <summary>
        /// Representation of a sedol.  No need to actually expose the input string so it is kept private
        /// character/index Weights are 1,3,1,7,3,9
        /// </summary>
        /// <param name="value">SEDOL Value</param>
        public clsSedol(string value)
        {
            // Could potentially inject weights
            _weights = new List<int> { 1, 3, 1, 7, 3, 9 };
            _value = value;
        }

        /// <summary>
        /// Returns the Sedol character index for the supplied Character.  Alphabet position + 11
        /// Implemented as Upper ASCII code - 55 (for letters)
        /// ASCII Code - 48 (for numbers)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int Code(char input)
        {
            if (char.IsLetter(input))
            {
                return char.ToUpper(input) - 55;
            }
            else
            {
                return input - 48;
            }
        }

        /// <summary>
        /// Returns the Sedol check digit for a the Sedol.
        /// Calculation is ((10 - (weightedSum Mod 10)) Mod 10)
        /// </summary>
        /// <returns></returns>
        public char CheckDigit
        {
            get
            {
                List<int> codes = _value.Take(SEDOL_LENGTH - 1).Select(Code).ToList();
                int weightedSum = _weights.Zip(codes, (w, c) => w * c).Sum();
                return Convert.ToChar(((10 - (weightedSum % 10)) % 10).ToString(CultureInfo.InvariantCulture));
            }
        }

        /// <summary>
        /// Returns true if the input string not contains any invalid characters
        /// </summary>
        /// <returns></returns>
        public bool IsInvalidChar => Regex.IsMatch(_value, "^[a-zA-Z0-9]*$");

        /// <summary>
        /// Returns true if the input string is the correct length for a Sedol (i.e 7 char)
        /// </summary>
        /// <returns>Retrun True if it has Correct Valid Length</returns>
        public bool IsValidLength => !string.IsNullOrEmpty(_value) && _value.Length == SEDOL_LENGTH;

        /// <summary>
        /// Returns true if the character at the specified index is the current "User Defined" char
        /// The IsValidLength should be before this check. As if it's less than the CHECK_DIGIT_IDX it will throw an
        /// IndexOutOfRangeException.
        /// </summary>
        /// <returns></returns>
        public bool IsUserDefined => _value[USER_DEFINED_IDX] == USER_DEFINED_CHAR;

        /// <summary>
        /// Returns true if the existing check digit on a sedol matches the calculated check digit.
        /// The IsValidLength should be before this check. As if it's less than the CHECK_DIGIT_IDX it will throw an
        /// IndexOutOfRangeException.
        /// </summary>
        /// <returns>Retrun True if it has Valid Check Digit</returns>
        public bool HasValidCheckDigit
        {
            get
            {
                if (_value[CHECK_DIGIT_IDX] == CheckDigit)
                {
                    return true;
                }
                else { return false; }
            }
        }

     
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SedolValidatorInterfaces;

namespace _10FA_SEDOL_Validator_casestudy
{
    /// <summary>
    /// A Sedol Validator
    /// </summary>
    public class SedolValidator : ISedolValidator
    {
        public const string INPUT_STRING_NOT_VALID_LENGTH = "Input string was not 7-characters long";
        public const string INPUT_STRING_CONTAINS_INVALID_CHAR = "SEDOL contains invalid characters";
        public const string CHECKSUM_DIGIT_NOT_VALID_WITH_REST_OF_INPUT = "Checksum digit does not agree with the rest of the input";

        /// <summary>
        /// Accepts an input string and returns an appropriate ISedolValidationResult
        /// </summary>
        /// <param name="input">Pass SEDOL Value</param>
        /// <returns>Return Result In ISedolValidationResult </returns>
        public ISedolValidationResult ValidateSedol(string input)
        {            
            clsSedol sedol = new clsSedol(input);

            SedolValidationResult result = new SedolValidationResult
            {
                InputString = input,
                IsValidSedol = false,
                IsUserDefined = false,
                ValidationDetails = null
            };

            //Check Length Of the Passed SEDOL
            if (!sedol.IsValidLength)
            {
                result.ValidationDetails = INPUT_STRING_NOT_VALID_LENGTH;
                return result;
            }

            //Check If any Invalid Char is there or Not in Input
            if (!sedol.IsInvalidChar)
            {
                result.ValidationDetails = INPUT_STRING_CONTAINS_INVALID_CHAR;
                return result;
            }

            //Check if its User Defined 
            if (sedol.IsUserDefined)
            {
                result.IsUserDefined = true;
                if (sedol.HasValidCheckDigit)
                {
                    result.IsValidSedol = true;
                    return result;
                }
                result.ValidationDetails = CHECKSUM_DIGIT_NOT_VALID_WITH_REST_OF_INPUT;
                return result;
            }

            if (sedol.HasValidCheckDigit)
            {
                result.IsValidSedol = true;
            }
            else
            {
                result.ValidationDetails = CHECKSUM_DIGIT_NOT_VALID_WITH_REST_OF_INPUT;
            }

            return result;
        }
    }
}

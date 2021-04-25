using SedolValidatorInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10FA_SEDOL_Validator_casestudy
{
    public class SedolValidationResult : ISedolValidationResult
    {
        public string InputString { get; set; }
        public bool IsValidSedol { get; set; }
        public bool IsUserDefined { get; set; }
        public string ValidationDetails { get; set; }

        public SedolValidationResult()
        {
        }
        public SedolValidationResult(
            string inputString,
            bool isValidSedol,
            bool isUserDefined,
            string validationDetails)
        {
            InputString = inputString;
            IsValidSedol = isValidSedol;
            IsUserDefined = isUserDefined;
            ValidationDetails = validationDetails;
        }

    }
}

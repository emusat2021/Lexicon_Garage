using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Garage.app.Helpers
{
    public class InsufficentLengthError : UserError
    {
        private const int minLength = 2;
        private const int maxLength = 10;
        public override string UEMessage()
        {
            return $"Input string must have at least {minLength} and cannot exceed {maxLength} characters";
        }
    }
}

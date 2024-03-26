using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Garage.app.Helpers
{
    public class NegativInputNumberError : UserError
    {
        public override string UEMessage()
        {
            return "Negative input not allowed!";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Garage.app.Helpers
{
    public class SyntaxInputError : UserError
    {
        public override string UEMessage()
        {
            return "Syntax Error: The input provided does not follow the expected syntax < characters only > . This fired an error!";
        }
    }
}

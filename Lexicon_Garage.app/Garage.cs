using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Garage.app
{
    internal class Garage <T> where T : IVehicle
    {
        private T[] vehicle;
    }
}

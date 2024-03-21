using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Garage.app
{
    internal class Handler : IHandler
    {
        private int _capacity;
        public int Capacity { get; set; }

        public Garage<T> CreateGarage<T>() where T : IVehicle
        {
            return new Garage<T>(Capacity);
        }
    }
}

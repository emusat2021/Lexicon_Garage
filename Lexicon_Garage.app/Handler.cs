using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Garage.app
{
    internal class Handler : IHandler
    {
        public int Capacity { get; set; }

        public Handler(int capacity)
        {
            Capacity = capacity;
        }

        public Garage<T> CreateGarage<T>() where T : IVehicle
        {
            return new Garage<T>(Capacity);
        }
    }
}

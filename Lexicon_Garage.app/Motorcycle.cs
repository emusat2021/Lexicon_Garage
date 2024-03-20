using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Garage.app
{
    internal class Motorcycle : Vehicle
    {
        public Motorcycle(int numberOfWheels, string registrationNumber, string color, int numberOfSets, string fueltype) : base(numberOfWheels, registrationNumber, color, numberOfSets, fueltype)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Garage.app.Vehicles
{
    internal class Boat : Vehicle
    {
        public Boat(string model, string registrationNumber, string color, string fueltype, int numberOfSets, int numberOfWheels) : base(model, registrationNumber, color, fueltype, numberOfSets, numberOfWheels)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Garage.app.Vehicles
{
    internal class Airplane : Vehicle
    {
        public Airplane(string model, string registrationNumber, string color, string fueltype, uint numberOfSets, uint numberOfWheels) : base(model, registrationNumber, color, fueltype, numberOfSets, numberOfWheels)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Garage.app
{
    public interface IVehicle
    {

        string RegistrationNumber { get; set; }
        string Color { get; set; }
        int NumberOfWheels { get; set; }
        int NumberOfSets { get; set; }
        string Fueltype { get; set; }
        
    }
}

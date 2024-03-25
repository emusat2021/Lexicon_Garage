using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Garage.app.Utilities
{
    public class GarageHandler<T> : IGarageHandler<T> where T : IVehicle
    {
        private readonly IGarage<T> _garage;


        public GarageHandler(IGarage<T> garage)
        {
            _garage = garage;
        }

        public (bool, string) AddVehicleToGarage(T vehicle)
        {
            return _garage.AddVehicle(vehicle);
        }
        public (bool, string) RemoveVehicleFromGarage(T vehicle)
        {
            return _garage.RemoveVehicle(vehicle);
        }
        public string ListVehicleFromGarage()
        {
            return _garage.ListVehicles();
        }
    }
}

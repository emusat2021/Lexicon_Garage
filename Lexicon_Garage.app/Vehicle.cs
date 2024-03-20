using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Garage.app
{
    internal class Vehicle
    {
        private readonly string _registrationNumber;
        private string _color;
        private int _numberOfWheels;
        private int _numberOfSets;
        private string _fueltype;

        public Vehicle()
        {
        }

        public Vehicle(int numberOfWheels, string registrationNumber, string color, int numberOfSets, string fueltype)
        {
            this._numberOfWheels = numberOfWheels;
            this._registrationNumber = registrationNumber;
            this._color = color;
            this._numberOfSets = numberOfSets;
            this._fueltype = fueltype;
        }




    }
}

﻿using Lexicon_Garage.app;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("Lexicon_Garage.tests")]
namespace Lexicon_Garage.app.Vehicles
{
    internal class Motorcycle : Vehicle
    {
        public Motorcycle(string model, string registrationNumber, string color, string fueltype, uint numberOfSeats, uint numberOfWheels) :
            base(model, registrationNumber, color, fueltype, numberOfSeats, numberOfWheels)
        {
        }
    }
}

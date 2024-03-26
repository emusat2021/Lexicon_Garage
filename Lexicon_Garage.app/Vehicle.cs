using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lexicon_Garage.app
{
    public class Vehicle : IVehicle
    {
        public string Model { get; set; }
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }
        public uint NumberOfWheels { get; set; }
        public uint NumberOfSeats { get; set; }
        public string Fueltype { get; set; }

        public Vehicle() { }
        public Vehicle(string model, string registrationNumber, string color, string fueltype, uint numberOfSeats, uint numberOfWheels )
        {
            Model = model;
            RegistrationNumber = registrationNumber;
            Color = color;
            Fueltype = fueltype;
            NumberOfSeats = numberOfSeats;
            NumberOfWheels = numberOfWheels;

        }

        public string Stats()
        {
            return $"Model: {Model}\nRegistrationNumber: {RegistrationNumber}\n" +
                $"Color: {Color}\n" +
                $"Fueltype: {Fueltype}\n" +
                $"NumberOfSeats: {NumberOfSeats}\n" +
                $"NumberOfWheels: {NumberOfWheels}";
        }


    }
}
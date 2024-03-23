using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Lexicon_Garage.app.UserInterface;

namespace Lexicon_Garage.app
{
    public class Garage<T> : IGarage1<T> where T : IVehicle, IEnumerable<T>
    {
        private T[] vehicles;
        private int count;

        public Garage(int capacity)
        {
            vehicles = new T[capacity];
            count = 0;
        }

        public (bool, string) AddVehicle(T vehicle)
        {
            if (count < vehicles.Length)
            {
                vehicles[count++] = vehicle;
                return (true, "Vehicle added succesfully");
            }
            else
            {
                return (false, "There is no place in the Garage");
            }
        }

        public (bool, string) RemoveVehicle(T vehicleToBeRemoved)
        {
            int index = Array.IndexOf(vehicles, vehicleToBeRemoved);
            if (index != -1)
            {
                vehicles = vehicles.Where((val, idx) => idx != index).ToArray();
                count--;
                return (true, $"{vehicleToBeRemoved} removed");
            }
            else
            {
                return (false, $"{nameof(vehicleToBeRemoved)} no found in Garage");
            }
        }

        public string ListVehicles()
        {
            Console.WriteLine("Vehicles in the garage:");
            foreach (T vehicle in vehicles)
            {
                return $"{vehicle.GetType().Name}:\n {vehicle.Stats()}";
            }
            return "No vehicles in the Garage";
        }


    }
}

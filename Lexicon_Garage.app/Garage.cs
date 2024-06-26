﻿using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Lexicon_Garage.app.UserInterface;
using System.Collections;

namespace Lexicon_Garage.app
{
    public class Garage<T> : IEnumerable<T>, IGarage<T> where T : IVehicle
    {
        private T[] vehicles;
        private int count;

        public Garage()
        {

        }
        public Garage(int capacity)
        {
            vehicles = new T[capacity];
            count = 0;
        }

        public (bool, string) AddVehicle(T vehicle)
        {
            if (vehicles.Any(v => v != null && v.RegistrationNumber == vehicle.RegistrationNumber))
            {
                return (false, "Vehicle with the same registration number already exists in the Garage");
            }
            try
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
            catch(InvalidOperationException e)
            {
                return (false, e.Message);
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
                return (false, "Vehicle not found in Garage");
            }
        }

        public string ListVehicles()
        {
            if(count > 0)
            {
                string result = "Vehicles in the garage:\n";
                foreach (T vehicle in vehicles)
                {
                    if (vehicle != null)
                    {
                        result += $"{vehicle.GetType().Name}:\n {vehicle.Stats()}";
                    }
                }
                return result;
            }
            else
            {
                return "There are no vehicles in the garage";
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            for(int i = 0;  i < count; i++) 
            {
                yield return vehicles[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();


    }
}

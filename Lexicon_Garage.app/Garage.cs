using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_Garage.app
{
    internal class Garage <T> where T : IVehicle
    {
        private T[] vehicles;
        private int count;

        public Garage(int capacity)
        {
            vehicles = new T[capacity];
            count = 0;
        }

        public void AddVehicle(T vehicle)
        {
            if(count < vehicles.Length)
            {
                vehicles[count++] = vehicle;
            }
            else
            {
                Console.WriteLine("The is no place in the Garage");
            }
        }


    }
}

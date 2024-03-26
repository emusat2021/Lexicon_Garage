using Lexicon_Garage.app.UserInterface;
using Lexicon_Garage.app.Utilities;
using Lexicon_Garage.app.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lexicon_Garage.app
{
    internal class Manager
    {
        private Dictionary<ConsoleKey, Action> actionMenu = null!;
        private IUI ui = null!;
        private IGarageHandler<IVehicle> garageHandler = null!;

        public Manager(IUI ui, IGarageHandler<IVehicle> garageHandler)
        {
            this.ui = ui;
            this.garageHandler = garageHandler;
        }

        public void GarageManager()
        {

            while (true)
            {
                ui.Print("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. List of Vehicles in the Garage"
                    //+ "\n1. List of Vehicles types and the number of every type in the Garage"
                    + "\n2. Add a vehicle in the garage"
                    //+ "\n3. Remove vehicle in the garage"
                    + "\n4. Search vehicle in the garage after Registration Number"
                    //+ "\n5. Multiple Searchs vehicle in the garage after color, number of wheels"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = ui.GetInput()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    ui.Clean();
                    ui.Print("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ListVehicles();
                        break;
                    case '2':
                        //AddVehicle();
                        break;
                    case '3':
                        //RemoveVehicle();
                        break;
                    case '4':
                       SearchRegistrationNumber();
                        break;
                    case '5':
                        // MultipleSearchMenu();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        ui.Print("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }
        public void ListVehicles()
        {
            garageHandler.ListVehicleFromGarage();
        }
        private void SearchRegistrationNumber()
        {
            throw new NotImplementedException();
        }


    }

}


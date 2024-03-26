using Lexicon_Garage.app.Helpers;
using Lexicon_Garage.app.UserInterface;
using Lexicon_Garage.app.Utilities;
using Lexicon_Garage.app.Helpers;

using Lexicon_Garage.app.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.Marshalling;
using Microsoft.VisualBasic.FileIO;
using System.Drawing;
using System.Reflection;


namespace Lexicon_Garage.app
{
    internal class Manager
    {
        private IUI ui;
        private IVehicle vehicle = new Vehicle();

        private IGarageHandler<IVehicle> garageHandler;
        public Manager(IUI ui, IGarageHandler<IVehicle> garageHandler)
        {
            this.ui = ui;
            this.garageHandler = garageHandler;
        }

        public void GarageManager()
        {

            while (true)
            {
                ui.Print("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 5, 0) of your choice"
                    + "\n1. List of Vehicles in the Garage"
                    + "\n2. List of Vehicles types and the number of every type in the Garage  - not implemented yet"
                    + "\n3. Add a vehicle in the garage"
                    + "\n4. Remove vehicle in the garage - not implemented yet" 
                    + "\n5. Search vehicle in the garage after Registration Number - not implemented yet"
                    + "\n6. Multiple Searchs vehicle in the garage after color, number of wheels - not implemented yet"
                    + "\n7. Hardcode vehicles_test"
                    + "\n0. Exit the application");
                try
                {
                    var input = ui.GetInput()![0]; //Tries to set input to the first char in an input line
                    switch (input)
                    {
                        case '1':
                            ListVehicles();
                            break;
                        case '2':
                            ListVehiclesTypes();
                            break;
                        case '3':
                            AddVehicle();
                            break;
                        case '4':
                            RemoveVehicle();
                            break;
                        case '5':
                            SearchRegistrationNumber();
                            break;
                        case '6':
                            MultipleSearchMenu();
                            break;
                        case '7':
                            AddVehiclesForTest();
                            break;
                        case '0':
                            Environment.Exit(0);
                            break;
                        default:
                            ui.Print("Please enter some valid input (0, 1, 2, 3, 4)");
                            break;
                    }
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    ui.Clean();
                    ui.Print("Please enter some input!");
                }
                
            }
        }




        public void AddVehicle()
        {
            string vehicleType = string.Empty;
            bool notToMainMenu = true;
            while (notToMainMenu)
            {
                Console.ForegroundColor = ConsoleColor.White;

                ui.Print("Add vehicle in Garage by inputting the number \n(1, 2, 3 ,4, 5, 6, 0) of your choice"
                    + "\n11. Choose vehicle type: (Airplane, Boat, Bus, Car, Motorcycle)"
                    + "\n1. Add vehicle's registration number (example: ABC123)"
                    + "\n2. Add vehicle's model in Garage (example: Kia)"
                    + "\n3. Add vehicle's color (example: White)"
                    + "\n4. Add vehicle's Fuel Type (example: Diesel)"
                    + "\n5. Add vehicle's Number Of Seats (example: 4)"
                    + "\n6. Add vehicle's Number Of Wheels (example: 4)"
                    + "\n0. Go back to Main Menu");


                string input = ui.GetInput();
                string answer = string.Empty;
                switch (input)
                {
                    case "11":
                        answer = GetStringValue("Vehicle Type");
                        answer.ToLower();
                        vehicleType = answer;
                        PrintFeedback("Vehicle Type", answer);
                        continue;
                    case "1":
                        answer = GetStringValue("Registration Number");
                        answer.ToLower();
                        vehicle.RegistrationNumber = answer;
                        PrintFeedback("Registration Number", answer);
                        continue;
                    case "2":
                        answer = GetStringValue("Model");
                        answer.ToLower();
                        vehicle.Model = answer;
                        PrintFeedback("Model", answer);
                        continue;

                    case "3":
                        answer = GetStringValue("Color");
                        answer.ToLower();
                        vehicle.Color = answer;
                        PrintFeedback("Color", answer);
                        continue;
                    case "4":
                        answer = GetStringValue("Fuel Type");
                        answer.ToLower();
                        vehicle.Fueltype = answer;
                        PrintFeedback("Fuel Type", answer);
                        continue;
                    case "5":
                        answer = GetStringValue("Number Of Seats");
                        answer.ToLower();
                        vehicle.NumberOfSeats = Convert.ToUInt32(answer);
                        PrintFeedback("Number Of Seats", answer);
                        continue;
                    case "6":
                        answer = GetStringValue("Number Of Wheels");
                        answer.ToLower();
                        vehicle.NumberOfWheels = Convert.ToUInt32(answer);
                        PrintFeedback("Number Of Wheels", answer);
                        continue;
                    case "0":
                        notToMainMenu = false;
                        break;
                    default:
                        ui.Print("Please enter some valid input (1, 2, 3, 4, 5, 6)");
                        continue;
                }
            }
            IVehicle car = new Car(vehicle.Model, vehicle.RegistrationNumber, vehicle.Color, vehicle.Fueltype, vehicle.NumberOfSeats, vehicle.NumberOfWheels);
            IVehicle bus = new Bus(vehicle.Model, vehicle.RegistrationNumber, vehicle.Color, vehicle.Fueltype, vehicle.NumberOfSeats, vehicle.NumberOfWheels);
            IVehicle boat = new Boat(vehicle.Model, vehicle.RegistrationNumber, vehicle.Color, vehicle.Fueltype, vehicle.NumberOfSeats, vehicle.NumberOfWheels);
            IVehicle airplane = new Airplane(vehicle.Model, vehicle.RegistrationNumber, vehicle.Color, vehicle.Fueltype, vehicle.NumberOfSeats, vehicle.NumberOfWheels);
            IVehicle motorcycle = new Motorcycle(vehicle.Model, vehicle.RegistrationNumber, vehicle.Color, vehicle.Fueltype, vehicle.NumberOfSeats, vehicle.NumberOfWheels);


            switch (vehicleType)
            {
                case "bus":
                    garageHandler.AddVehicleToGarage(bus);
                    break;
                case "car":
                    garageHandler.AddVehicleToGarage(car);
                    break;
                case "boat":
                    garageHandler.AddVehicleToGarage(boat);
                    break;
                case "airplane":
                    garageHandler.AddVehicleToGarage(airplane);
                    break;
                case "motorcycle":
                    garageHandler.AddVehicleToGarage(motorcycle);
                    break;
            };

        }

        private void ListVehicles()
        {
            var result = garageHandler.ListVehicleFromGarage();
            ui.Print($"Here is the list: {result}");
        }

        private void SearchRegistrationNumber()
        {
            throw new NotImplementedException();
        }


        private void MultipleSearchMenu()
        {
            throw new NotImplementedException();
        }

        private void RemoveVehicle()
        {
            throw new NotImplementedException("Not implemented yet");
        }
        private void ListVehiclesTypes()
        {
            throw new NotImplementedException("Not implemented yet");
        }
        private void AddVehiclesForTest()
        {
            IVehicle motorcycle = new Motorcycle("Fiat", "15ABC", "black", "Disel", 2, 2);
            IVehicle car = new Car("BMV", "16ABC", "black", "Disel", 2, 2);
            garageHandler.AddVehicleToGarage(car);
            garageHandler.AddVehicleToGarage(motorcycle);
        }

        public string GetStringValue(string displayText)
        {
            ui.Print($"Enter value for {displayText}");
            string answer = ui.GetInput();
            return answer;
        }
        public void PrintFeedback(string choice, string displayText)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            ui.Print($" You have entered {choice}= {displayText}");
            Console.ResetColor();
        }

    }





}




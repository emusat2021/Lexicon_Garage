namespace Lexicon_Garage.app
{
    public interface IVehicle
    {
        string Model { get; set; }
        string Color { get; set; }
        string Fueltype { get; set; }
        int NumberOfSets { get; set; }
        int NumberOfWheels { get; set; }
        string RegistrationNumber { get; set; }

        string Stats();
    }
}
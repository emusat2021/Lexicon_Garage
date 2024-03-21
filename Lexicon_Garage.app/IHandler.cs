namespace Lexicon_Garage.app
{
    internal interface IHandler
    {
        int Capacity { get; set; }

        Garage<T> CreateGarage<T>() where T : IVehicle;
    }
}
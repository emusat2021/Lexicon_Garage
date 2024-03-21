namespace Lexicon_Garage.app
{
    internal interface IGarage<T> where T : IVehicle
    {
        void AddVehicle(T vehicle);
        void ListVehicles();
        void RemoveVehicle(T vehicleToBeRemoved);
    }
}
namespace Lexicon_Garage.app
{
    public interface IGarage1<T> where T : IVehicle, IEnumerable<T>
    {
        (bool, string) AddVehicle(T vehicle);
        string ListVehicles();
        (bool, string) RemoveVehicle(T vehicleToBeRemoved);
    }
}
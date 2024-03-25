namespace Lexicon_Garage.app
{
    public interface IGarage<T> where T : IVehicle
    {
        (bool, string) AddVehicle(T vehicle);
        string ListVehicles();
        (bool, string) RemoveVehicle(T vehicleToBeRemoved);
        IEnumerator<T> GetEnumerator();
    }
}
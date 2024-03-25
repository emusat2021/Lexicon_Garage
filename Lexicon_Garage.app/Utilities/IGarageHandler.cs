
namespace Lexicon_Garage.app.Utilities
{
    public interface IGarageHandler<T> where T : IVehicle
    {
        (bool, string) AddVehicleToGarage(T vehicle);
        string ListVehicleFromGarage();
        (bool, string) RemoveVehicleFromGarage(T vehicle);

    }
}
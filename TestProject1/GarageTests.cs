using Lexicon_Garage.app;
using Lexicon_Garage.app.Vehicles;

namespace Lexicon_Garage.tests
{
    public class GarageTests
    {
        [Fact]
        public void AddVehicle_WhenCapacityAvailable_ShouldReturnSuccess_Item2TupleAsAString()
        {
            var expected = "Vehicle added succesfully";

            var garage = new Garage<IVehicle>(2);
            IVehicle motorcycle = new Motorcycle("Fiat", "15ABC", "black", "Disel", 2, 2);

            var actual = garage.AddVehicle(motorcycle);

            Assert.Equal(expected, actual.Item2);
        }

        [Fact]
        public void AddVehicle_WhenNOCapacityAvailable_ShouldReturnNOSuccess_Item2TupleAsAString()
        {
            var expected = "There is no place in the Garage";

            var garage = new Garage<IVehicle>(1);
            IVehicle motorcycle = new Motorcycle("Fiat", "15ABC", "black", "Disel", 2, 2);
            IVehicle car = new Car("BMV", "16ABC", "black", "Disel", 2, 2);

            garage.AddVehicle(motorcycle);
            var actual = garage.AddVehicle(car);


            Assert.Equal(expected, actual.Item2);
        }
    }
}
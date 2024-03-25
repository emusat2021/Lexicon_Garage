using Lexicon_Garage.app;
using Lexicon_Garage.app.Vehicles;
using Lexicon_Garage.app.Utilities;
using Moq;

namespace Lexicon_Garage.tests
{
    public class GarageHandlerTests
    {
        [Fact]
        public void AddVehicleToGarage_WhenCapacityAvailable_ShouldReturnSuccess_Item2TupleAsAString()
        {
            var expected = "Vehicle added succesfully";
            var garageMock = new Mock<IGarage<IVehicle>>();
            garageMock.Setup(g => g.AddVehicle(It.IsAny<IVehicle>())).Returns((true, "Vehicle added succesfully"));
            var garageHandler = new GarageHandler<IVehicle>(garageMock.Object);
            IVehicle motorcycle = new Motorcycle("Fiat", "15ABC", "black", "Disel", 2, 2);

            var actual = garageHandler.AddVehicleToGarage(motorcycle);

            Assert.Equal(expected, actual.Item2);
        }

    }



}
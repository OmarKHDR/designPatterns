using Xunit;

public class VehicleFactoryTests
{
	[Fact]
	public void CreateBike_ShouldReturnBikeInstance()
	{
		// Arrange
		var factory = new VehicleFactory("Bike");

		// Assert
		Assert.IsType<Bike>(factory._MyVehivle);
	}

	[Fact] 
	public void CreateCar_ShouldReturnCarInstance()
	{
		// Arrange
		var factory = new VehicleFactory("Car");

		// Assert
		Assert.IsType<Car>(factory._MyVehivle);
	}

	[Fact]
	public void CreateInvalidType_ShouldThrowException()
	{
		// Arrange & Act & Assert
		Assert.Throws<Exception>(() => new VehicleFactory("Invalid"));
	}

	[Theory]
	[InlineData("Car")]
	[InlineData("Bike")]
	public void CreateValidVehicles_ShouldNotBeNull(string vehicleType)
	{
		// Arrange
		var factory = new VehicleFactory(vehicleType);

		// Assert
		Assert.NotNull(factory._MyVehivle);
	}
}
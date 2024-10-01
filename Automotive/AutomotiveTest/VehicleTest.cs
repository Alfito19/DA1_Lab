namespace AutomotiveTest;

[TestClass]
public class VehicleTest
{
    private double Depreciation;
    private float PricePerDoor;

    [TestInitialize]
    public void InitializeAttributes()
    {
        this.Depreciation = 0.1;
        this.PricePerDoor = 10;
    }
    
    [TestMethod]
    public void DoorQuantitySet_ValidDoors()
    {
        //arrange
        Vehicle v;
        //act
        v = new Vehicle(5, "red");
        //assert
        Assert.AreEqual(5, v.DoorQuantity);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void DoorQuantitySet_InvalidLessThan0Doors()
    {
        //arrange
        Vehicle v;
        //act
        v = new Vehicle(-4, "red");
    }

    [TestMethod]
    public void DoorQuantitySet_Info()
    {
        Vehicle v;
        v = new Vehicle(5, "red");
        Assert.AreEqual("Color red, Door 5", v.Info);
    }

    [TestMethod]
    public void CalculatePrice_Successfully()
    {
        //arrange
        Vehicle v = new Vehicle(5, "blue");
        //act
        var price = v.CalculatePrice(PricePerDoor,Depreciation);
        //assert
        Assert.AreEqual(50, price);
    }

    [TestMethod]
    public void CalculatePrice_Base_Price()
    {
        //arrange
        Vehicle v = new Vehicle(5, "blue",1980);
        //act
        var price = v.CalculatePrice(PricePerDoor,Depreciation);
        //assert
        Assert.AreEqual(5, price);
    }

}
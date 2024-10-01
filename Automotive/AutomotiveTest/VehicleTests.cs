namespace AutomotiveTest;

[TestClass]
public class VehicleTests
{
    private double Deprecation;
    private float PricePerDoor;

    [TestInitialize]
    public void Initialize()
    {
        this.Deprecation = 1.0;
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
        Vehicle v;
        v = new Vehicle(-1, "red");
    }

    [TestMethod]
    public void DoorQuantitySet_Info()
    {
        Vehicle v;
        v= new Vehicle(5, "red");
        Assert.AreEqual("Color red, Door 5",v.Info);
    }

    [TestMethod]
    public void CalculatePrice_Successfully()
    {
        Vehicle v;
        v= new Vehicle(5, "red");
        var price =v.CalculatePrice(PricePerDoor, Deprecation);
        
        Assert.AreEqual(50,price);

    }

    [TestMethod]
    public void CalculatePrice_Base_Price()
    {
        Vehicle v;
        v=new Vehicle(5, "red",1980);
        var price = v.CalculatePrice(PricePerDoor, Deprecation);
        Assert.AreEqual(5,price);
    }
}
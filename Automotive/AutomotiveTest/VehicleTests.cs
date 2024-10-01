namespace AutomotiveTest;

[TestClass]
public class VehicleTests
{
    [TestMethod]
    public void DoorQuantitySet_ValidDoors()
    {
        //arrange
        Vehicle v;
        //act
        v = new Vehicle(11, "red");
        //assert
        Assert.AreEqual(11, v.DoorQuantity);
    }
}
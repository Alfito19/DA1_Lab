namespace AutomotiveTest;

[TestClass]
public class VehicleTest
{
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
}
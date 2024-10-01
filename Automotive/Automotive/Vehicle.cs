namespace Automotive;

public class Vehicle
{
    private int _doorQuantity;
    public int Year;
    public int DoorQuantity { get=>_doorQuantity;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("DoorQuantity cannot be less or equal to 0.");
            }
            _doorQuantity = value;
        }
    }
    public string Color { get; set; }

    public string Info
    {
        get => $"Color {Color}, Door {DoorQuantity}";
    }

    public Vehicle(int doorQuantity, string color,int year=2024)
    {
        DoorQuantity = doorQuantity;
        Color = color;
        Year = year;
    }

    public virtual void TurnOn()
    {
        Console.WriteLine("Remember to override this method to print the correct information");
    }
    
    public double CalculatePrice(float pricePerDoor, double depreciation)
    {
        var total = _doorQuantity * pricePerDoor;
        var yearNow = DateTime.Now.Year;
        var discount = (yearNow - Year) * depreciation*total;

        if (total - discount <= 0)
        {
            return total * 0.1;
        }
        return total-discount;
    }
}
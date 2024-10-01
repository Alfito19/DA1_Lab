namespace Automotive;

public class Vehicle
{
    private int _doorQuantity;
    public int DoorQuantity { get=>_doorQuantity;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("DoorQuantity cannot be less or equal to 0.");
            }
            _doorQuantity = value;
        } }
    public string Color { get; set; }

    public string Info
    {
        get => $"Color {Color}, Door {DoorQuantity}";
    }

    public Vehicle(int doorQuantity, string color)
    {
        DoorQuantity = doorQuantity;
        Color = color;
    }

    public virtual void TurnOn()
    {
        Console.WriteLine("Remember to override this method to print the correct information");
    }
}
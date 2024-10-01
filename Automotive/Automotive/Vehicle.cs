namespace Automotive;

public class Vehicle
{
    public int DoorQuantity { get=>DoorQuantity;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("DoorQuantity cannot be less or equal to 0.");
            }
            DoorQuantity = value;
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
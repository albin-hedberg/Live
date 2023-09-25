namespace Live._2023_09_25.@interface;

public class Truck : Car, IBaggageCarrier
{
    public void MakeSound()
    {
        Console.WriteLine("La cocaracha!");
    }

    public void Move()
    {
        Console.WriteLine("BROOOOOOOOOH!");
    }

    public double Capacity { get; set; }
}

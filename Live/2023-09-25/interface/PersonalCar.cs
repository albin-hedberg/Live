namespace Live._2023_09_25.@interface;

public class PersonalCar : Car, IMakeSound, IMove
{
    public void MakeSound()
    {
        Console.WriteLine("Honk Honk!");
    }

    public void Move()
    {
        Console.WriteLine("Vem kan stoppa mig när jag bara rullar fram?!");
    }
}

namespace Live._2023_09_25.@interface;

public class Boat : Vehicle, IMakeSound, IMove
{
    public void MakeSound()
    {
        Console.WriteLine("Skvalp skvalp!");
    }

    public void Move()
    {
        Console.WriteLine("Propellerljud under vatten!");
    }
}

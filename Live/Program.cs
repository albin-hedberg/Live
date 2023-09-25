using Live._2023_09_25;

// Live kodning - [date]
// Ctrl+Space = intelisense
#region 11_Sep
//-------------------- Live kodning - Mån 11 Sep, 2023 --------------------
//Pokemon pkm1 = new Pokemon("Charmander", PokeTypes.Electric);
//Pokemon pkm2 = new Pokemon("Bulbaqwerty", (PokeTypes)3);

////Pokemon pkm3 = new Pokemon();
////pkm3.Name = "Pikapika";
////pkm3.Type = "Electric";

//pkm1.PrintInfo();
//pkm2.PrintInfo();

//pkm1.Attack(pkm2);
////pkm2.Attack(pkm1);
//Console.WriteLine(pkm1.Name + " HP: " + pkm1.HealthPoints);
//Console.WriteLine(pkm2.Name + " HP: " + pkm2.HealthPoints);
////Pokemon.AttackStatic();
////Trainer.Greeting();

////pkm3.Type = "Tjohoo";

//// Övningsuppgifter 1-18  (Programmering 1)
//// Övningsuppgifter 18-40 (Programmering 2)
//----------------------------------------------------------//
#endregion

#region 13_Sep
//-------------------- Live kodning - Ons 13 Sep, 2023 --------------------
//CounterClass counterClass = new CounterClass();
//CounterClass counterClass2 = new CounterClass();


////counterClass2.CountUp();

////// Jämför referensen, 2 olika instanser = 2 olika referenser
//////if(counterClass == counterClass2)

////if(counterClass.Equals(counterClass2))
////{
////    Console.WriteLine("Dom är samma!");
////}
////else
////{
////    Console.WriteLine("Dom är inte samma!");
////}

////Console.WriteLine(counterClass.ToString());
////Console.WriteLine(counterClass2.ToString());

//CounterRecord counterRecord = new CounterRecord();
//CounterRecord counterRecord2 = new CounterRecord();

////if(counterRecord == counterRecord2)
//////if (counterRecord.Equals(counterRecord2))
////{
////    Console.WriteLine("Dom är samma!");
////}
////else
////{
////    Console.WriteLine("Dom är inte samma!");
////}

//////counterRecord.CountUp();

////Console.WriteLine(counterRecord);
////Console.WriteLine(counterRecord2);

//CounterStruct counterStruct = new CounterStruct();
//CounterStruct counterStruct2 = new CounterStruct();
//// Struct är en värdetyp, inte referenstyp
////if (counterStruct == counterStruct2)  // Går inte med struct
////if (counterStruct.Equals(counterStruct2))
////{
////    Console.WriteLine("Dom är samma!");
////}
////else
////{
////    Console.WriteLine("Dom är inte samma!");
////}

////Console.WriteLine(counterStruct);

//Console.WriteLine(counterClass.Counter);
//Console.WriteLine(counterRecord.Counter);
//Console.WriteLine(counterStruct.Counter);

//for (int i = 0; i < 10; i++)
//{
//    Test.CounterClassDemo(counterClass);
//    Test.CounterRecordDemo(counterRecord);
//    Test.CounterStructDemo(ref counterStruct);  // Pass by value || Pass by reference
//}

//Console.WriteLine("---------------------------------");

//Console.WriteLine(counterClass.Counter);
//Console.WriteLine(counterRecord.Counter);
//Console.WriteLine(counterStruct.Counter);
//----------------------------------------------------------//
//Pokemon pkm1 = new Pokemon("Charmander", PokeTypes.Electric);
//Pokemon pkm2 = new Pokemon("Bulbaqwerty", (PokeTypes)3);

////pkm1.PrintInfo();
////pkm2.PrintInfo();

////pkm1.Attack(pkm2);
////pkm2.Attack(pkm1);
////Console.WriteLine(pkm1.Name + " HP: " + pkm1.HealthPoints);
////Console.WriteLine(pkm2.Name + " HP: " + pkm2.HealthPoints);

//List<int> numbers  = new List<int>();

//numbers.Add(1);
//numbers.Add(2);

//Console.WriteLine(numbers[0]);
//Console.WriteLine(numbers[1]);
//Console.WriteLine(numbers.Capacity);
//----------------------------------------------------------//
//-------------------- Live kodning - Ons 13 Sep, 2023 --------------------
//// Properties, Metoder & Klasser PascalCase
//// Läs & gör övningarna: https://csharpskolan.se/article/uml/
//// Övning 1
//public class Particle
//{
//    public Vector2 Position;
//    public Vector2 Speed;
//    public int ImageOffsetX;
//    public int ImageOffsetY;
//}

//// Övning 2
//public class GameObject
//{
//    public bool IsDead;
//    public Vector2 Position;
//    public float Radius;
//    public Vector2 Speed;
//    public float Rotation;

//    public bool CollidesWith(GameObject other)
//    {
//    }
//}

//public class Meteor : GameObject
//{
//    public MeteorType Type;
//    public float ExplosionScale;

//    public Meter(MeteorType type)
//    {
//    }

//    public Update(GameTime gameTime)
//    {
//    }

//    public static IEnumerable<Meteor> BreakMeteor(Meteor meteor)
//    {
//    }
//}
#endregion

#region 25_Sep
//-------------------- Live kodning - Mån 25 Sep, 2023 --------------------
// Interface

//Car myCar = new Car();
//myCar.Content = "Jag";
//myCar.MakeSound();
//myCar.Move();
//Console.WriteLine(myCar.Content);

//Truck myTruck = new Truck();
//myTruck.Content = "1.000L Coca-Cola";
//myTruck.Capacity = 200_000;
//myTruck.MakeSound();
//myTruck.Move();
//Console.WriteLine(myTruck.Content);
//Console.WriteLine(myTruck.Capacity);

//RaceCar myRaceCar = new RaceCar();
//myRaceCar.Content = "1 st Coca-Cola";
//myRaceCar.MakeSound();
//myRaceCar.Move();
//Console.WriteLine(myRaceCar.Content);

//--------------------------------------------
// Personbil, Båt
// Move & MakeSound till interface

//PersonalCar myCar = new PersonalCar();
//myCar.Content = "Jag";
//myCar.MakeSound();
//myCar.Move();
//Console.WriteLine(myCar.Content);

//Console.WriteLine("----------");

//Boat myBoat = new Boat();
//myBoat.Content = "6-pack folköl";
//myBoat.MakeSound();
//myBoat.Move();
//Console.WriteLine(myBoat.Content);

//Console.WriteLine("----------");

//--------------------------------------------

//List<string> minLista = new List<string>();
//SortedList<string, int> minSLista = new SortedList<string, int>();

// Komposition
// När du loggar in har du ett objekt som du sätter en property på nånstans

MovieCreator movieCreator = new MovieCreator();

foreach (var genre in movieCreator.AllGenres)
{
    Console.WriteLine(genre.Name);
}

foreach (var director in movieCreator.Directors)
{
    Console.WriteLine(director.Name);
}

Console.WriteLine("-----------------");

Movie jurrasicPark = movieCreator.BuildMovie("Jurrasic Park", "RAWR!", new[]{0,1}, 2);

Console.WriteLine();

#endregion

#region DATUM
//-------------------- Live kodning - Ons 27 Sep, 2023 --------------------

#endregion

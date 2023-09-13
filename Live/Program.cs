using Live;
// Live kodning - [date]
// Ctrl+Space = intelisense
//-------------------- Mån 11 Sep, 2023 --------------------
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
//----------------------------------------------------------

//-------------------- Ons 13 Sep, 2023 --------------------
CounterClass counterClass = new CounterClass();
CounterClass counterClass2 = new CounterClass();

counterClass2.CountUp();

// Jämför referensen, 2 olika instanser = 2 olika referenser
//if(counterClass == counterClass2)

if(counterClass.Equals(counterClass2))
{
    Console.WriteLine("Dom är samma!");
}
else
{
    Console.WriteLine("Dom är inte samma!");
}

Console.WriteLine(counterClass.ToString());
Console.WriteLine(counterClass2.ToString());
//----------------------------------------------------------

using LiveKodPokemonTrainer;
using LiveKodPokemon;

//-------------------- Mån, 11 Sep, 2023 --------------------
Pokemon pkm1 = new Pokemon("Charmander", "Fire");
Pokemon pkm2 = new Pokemon("Bulbaqwerty", "Grass");

//Pokemon pkm3 = new Pokemon();
//pkm3.Name = "Pikapika";
//pkm3.Type = "Electric";

pkm1.PrintInfo();
pkm2.PrintInfo();

pkm1.Attack(pkm2);
pkm2.Attack(pkm1);
Console.WriteLine(pkm1.Name + " HP: " + pkm1.HealthPoints);
Console.WriteLine(pkm2.Name + " HP: " + pkm2.HealthPoints);
//Pokemon.AttackStatic();
//Trainer.Greeting();

//pkm3.Type = "Tjohoo";

// Övningsuppgifter 1-18  (Programmering 1)
// Övningsuppgifter 18-40 (Programmering 2)
//-----------------------------------------------------------

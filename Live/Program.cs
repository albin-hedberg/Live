using LiveKodPokemon;

Pokemon pkm1 = new Pokemon("Charmander", "Fire");
Pokemon pkm2 = new Pokemon("Bulbaqwerty", "Grass");

Pokemon pkm3 = new Pokemon();
pkm3.Name = "Pikapika";
pkm3._type = "Electric";

pkm1.PrintInfo();
pkm2.PrintInfo();

Console.WriteLine(pkm3.Name);
Console.WriteLine(pkm3._type);

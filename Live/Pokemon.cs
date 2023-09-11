using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveKodPokemon
{
    internal class Pokemon
    {
        private int _healthPoint = 100;

        public int HealthPoints
        {
            get { return _healthPoint; }
            set { _healthPoint = value; }
        }

        private string _name; // Properties (get/set funktioner)
        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _type;
        public string Type  // Properties (get/set funktioner)
        {
            get { return _name; }
            set
            {
                if (value == "Tjohoo")
                {
                    Console.WriteLine("Tjohoo är inte en giltlig typ!");
                    return;
                }
                _name = value;
            }
        }

        // ----------- prop -----------
        //public int MyProperty { get; set; }

        // ----------- propfull -----------
        //private int myVar;
        //
        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}
        // ---------------------------------

        public void PrintInfo()
        {
            Console.WriteLine(_name);
            Console.WriteLine(_type);
            Console.WriteLine();
        }

        public Pokemon()
        {
            ;
        }

        public Pokemon(string name, string type)
        {
            _name = name;
            _type = type;
        }

        public void Attack(Pokemon target)
        {
            target.HealthPoints -= 10;
            Console.WriteLine(_name + " attacks " + target.Name);
        }

        public static void AttackStatic()
        {
            Console.WriteLine("Static Attack");
        }
    }
}

// variabler med '_' = field/fält
// ctor - konstruktor ac
// static - körs på typen, inte instansen
// prop = property ac (när vi inte ska göra nåt i get/set)
// propfull = property med allt
// static properties - typen får en property, inte instansen (alla pokemon istället för en)
// Pascalcase = visar att det är en property
// CamelCase = visar att det är en variabel...?
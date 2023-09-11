using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveKodPokemon
{
    internal class Pokemon
    {
        private string _name;
        public string Name { get { return _name; } set { _name = value; } } // Properties (get/set funktioner)

        public string _type;

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
    }
}

// variabler med '_' = field/fält
// ctor - konstruktor ac
// static - körs på typen, inte instansen
// 
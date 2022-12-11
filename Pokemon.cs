using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatalhaPokemon
{
    public class Pokemon
    {
        public string NomePokemon { get; set; }
        public string Tipo { get; set; }
        public int Vida { get; private set; } = 100;
        public int Forca { get; set; }


        public Pokemon(string NomePokemon, string Tipo, int Forca)
        {
            this.NomePokemon = NomePokemon;
            this.Tipo = Tipo;
            this.Forca = Forca;
        }
    }
}

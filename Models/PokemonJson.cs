using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatalhaPokemon.Models
{
    internal class PokemonJson
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int Vida { get; private set; }
        public int Forca { get; set; }
        public int Cura { get; set; }
    }
}

using BatalhaPokemon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatalhaPokemon.Models
{
    internal class PokemonContra : IPokemon
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int Vida { get; set; }
        public int Forca { get; set; }
        public int Cura { get; set; }
        public bool EstaVivo { get; set; }
    }
}

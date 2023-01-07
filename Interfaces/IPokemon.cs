using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatalhaPokemon.Interfaces
{
    internal interface IPokemon
    {
        int Id { get; set; }
        string Nome { get; set; }
        string Tipo { get; set; }
        int Vida { get; set; }
        int Forca { get; set; }
        int Cura { get; set; }
        bool EstaVivo { get; set; }
    }
}

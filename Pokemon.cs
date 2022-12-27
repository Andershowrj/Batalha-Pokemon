﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatalhaPokemon
{
    public class Pokemon
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int Vida { get; private set; } = 100;
        public int Forca { get; set; }
        public int Cura { get; set; } = 20;

        /// <summary>
        /// Cria o Pokémons com nome, tipo e força de ataque
        /// </summary>
        /// <param name="NomePokemon">Nome do Pokémon</param>
        /// <param name="Tipo">Tipo do Pokémon</param>
        /// <param name="Forca">Força de ataque do Pokémon</param>
        public Pokemon(string NomePokemon, string Tipo, int Forca)
        {
            this.Nome = NomePokemon;
            this.Tipo = Tipo;
            this.Forca = Forca;
        }
        public void usarCura()
        {
            if (Vida <= 80 && Vida > 0)
            {
                Vida += 20;
                Console.WriteLine("Cura usada");

            }
            else if (Vida > 80 )
            {
                Vida = 100;
                Console.WriteLine("Cura usada");
            }

        }
    }
}

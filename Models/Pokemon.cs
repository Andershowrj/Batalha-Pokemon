using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatalhaPokemon.Interfaces;
using BatalhaPokemon.Models;

namespace BatalhaPokemon
{
    public class Pokemon : IPokemon
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int Vida { get; private set; } = 100;
        public int Forca { get; set; }
        public int Cura { get; set; } = 20;
        public bool EstaVivo { get { return Vida > 0; } }

        int IPokemon.Vida { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        bool IPokemon.EstaVivo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// Cria o Pokémons com nome, tipo e força de ataque
        /// </summary>
        /// <param name="Nome">Nome do Pokémon</param>
        /// <param name="Tipo">Tipo do Pokémon</param>
        /// <param name="Forca">Força de ataque do Pokémon</param>
        /// 
        public override string ToString()
        {
            return Nome;
        }
        public Pokemon(string nome, string tipo, int forca)
        {
            Nome = nome;
            Tipo = tipo;
            Forca = forca;
        }
        public void usarCura()
        {
            if (Vida < 80 && Vida > 0)
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
        public void danoRecebido(int dano)
        {
            //Reduz a vida garantindo que ela nunca fique negativa (minimo zero)
            Vida = Math.Max(0, Vida - dano);
        }
        public void cura(int valor)
        {
            Vida = Math.Min(100, Vida + valor);
        }
    }
}

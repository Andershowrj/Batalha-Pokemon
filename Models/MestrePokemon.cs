using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatalhaPokemon
{
    public class MestrePokemon
    {

        public string Player { get; set; }

        public MestrePokemon(string player)
        {
            while (string.IsNullOrEmpty(player))
            {
                Console.Write("Digite um nome: ");
                player = Console.ReadLine();
            }
            Player = player;
        }
    }
}

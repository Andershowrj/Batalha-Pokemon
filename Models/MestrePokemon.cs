using System;

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
        public override string ToString()
        {
            return Player;
        }
    }
}

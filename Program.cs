using System;
using System.Collections.Generic;
using System.Threading;
using Newtonsoft.Json;
using System.IO;
using BatalhaPokemon.Models;

namespace BatalhaPokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bem vindo à batalha de mestres pokémon\n");
            Console.Write("Diga seu nome: ");


            string _player = Console.ReadLine();
            //Criando o objeto "p1" pela classe "MestrePokemon
            MestrePokemon p1 = new MestrePokemon(_player);
            

            Console.Clear();
            Console.WriteLine($"Ok {p1}! Agora escolha o seu Pokémon\n");

            Pokemon escolhido = menu();
            Pokemon ePoke = enemyPokemon();

            Console.WriteLine("\nPrecione qualquer tecla para começar");
            Console.ReadKey();
            
            start();
            batalha(p1, escolhido, ePoke);
        }
        public static Pokemon menu()
        {
            List<Pokemon> pokemons = new List<Pokemon>()
            {
                new Pokemon("Cyndaquil", "Fogo", 12),
                new Pokemon("Totodile", "Água", 15),
                new Pokemon("Chikorita", "Planta", 10)
            };
            while (true)
            {
                int i = 1;
                foreach (Pokemon poke in pokemons)
                {
                    Console.WriteLine(i + " - " + poke);
                    i++;
                }

                Console.WriteLine("\n" + i + " - Acessar POKEDEX");
                //++ na frente da variavel para ser acrescentado o valor antes da saída
                Console.WriteLine(++i + " - Sair");

                //Receber a escolha do jogador
                int opcao = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine();

                switch (opcao)
                {
                    case 1:
                    case 2:
                    case 3:
                        Pokemon pokemonEscolhido = pokemons[Convert.ToInt16(opcao) - 1];
                        Console.WriteLine(pokemonEscolhido + " foi selecionado");
                        Console.WriteLine("Tipo: " + pokemonEscolhido.Tipo);
                        Console.WriteLine("Força: " + pokemonEscolhido.Forca);
                        Console.WriteLine();
                        return pokemonEscolhido;
                    case 4:
                        listarPokemonsJson();
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Número inválido.Escolha 1, 2 ou 3.");
                        break;

                }
            }
        }
        public static Pokemon enemyPokemon()
        {
            List<Pokemon> listaEnemyPokemons = new List<Pokemon>()
            {
                new Pokemon("Charmander", "fogo", 10),
                new Pokemon("Squirtle", "água", 10),
                new Pokemon("Bulbasaur", "planta", 10)
            };
            //Escolhe aleatoriamente um pokemon adversário
            Random rand = new Random();
            int enemy = rand.Next(1, listaEnemyPokemons.Count - 1);
            Console.WriteLine("O seu adversário será:");
            switch (enemy)
            {
                case 1:
                case 2:
                case 3:
                    Pokemon ePoke = listaEnemyPokemons[Convert.ToInt16(enemy)];
                    Console.WriteLine(ePoke);
                    Console.WriteLine("Tipo: " + ePoke.Tipo);
                    Console.WriteLine("Força: " + ePoke.Forca);
                    Console.WriteLine();
                    return ePoke;
                default:
                    return listaEnemyPokemons[0];
            }
        }
        public static void serializarPokemons()
        {
            //Falta implementar o Id
            Console.WriteLine();
            List<Pokemon> listaPokemon = new List<Pokemon>();
            listaPokemon.Add(new Pokemon("Cyndaquil", "fogo", 10));
            listaPokemon.Add(new Pokemon("Totodile", "água", 10));
            listaPokemon.Add(new Pokemon("Chikorita", "planta", 10));
            listaPokemon.Add(new Pokemon("Charmander", "fogo", 10));
            listaPokemon.Add(new Pokemon("Bulbasaur", "planta", 10));
            listaPokemon.Add(new Pokemon("Squirtle", "água", 10));

            //Serializa a lista listaPokemon em um arquivo externo no formato json
            string serializado = JsonConvert.SerializeObject(listaPokemon, Formatting.Indented);
            File.WriteAllText(@"C:\Users\Anderson\Documents\Visual Studio 2022\Projetos\" +
                @"BatalhaPokemon\Arquivos\pokemonsLista.json", serializado);

            Console.WriteLine("\n\nPrecione qualque tecla para continuar");
            Console.ReadKey();
        }
        public static void start()
        {
            //Função completa
            Console.Clear();
            Console.WriteLine();
            Console.Write("Iniciando batalha pokémon.");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine();
            Console.Write("Iniciando batalha pokémon..");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine();
            Console.Write("Iniciando batalha pokémon...");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine();
            Console.Write("Iniciando batalha pokémon.");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine();
            Console.Write("Iniciando batalha pokémon..");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine();
            Console.Write("Iniciando batalha pokémon...");
            Thread.Sleep(500);
            Console.Clear();


        }
        public static List<PokemonJson> listarPokemonsJson()
        {
            string conteudoJson = File.ReadAllText(@"C:\Users\Anderson\Documents\Visual Studio 2022\Projetos\" +
                @"BatalhaPokemon\Arquivos\pokemonsLista.json");
            List<PokemonJson> listaPokemon = JsonConvert.DeserializeObject<List<PokemonJson>>(conteudoJson);

            //Mostra a quantidade total de pokemons cadastrados no jogo
            Console.WriteLine($"A sua pokedex tem {listaPokemon.Count} pokemons cadastrados");

            //Lista todos os pokemons cadastrados
            foreach (PokemonJson dadosPokemons in listaPokemon)
            {
                Console.WriteLine($"{dadosPokemons.Nome}, tipo {dadosPokemons.Tipo}, ataque {dadosPokemons.Forca}");
            }

            Console.WriteLine("\n\nPrecione qualque tecla para continuar");
            Console.ReadKey();
            Console.WriteLine("\n\n");
            Console.WriteLine("Escolha seu Pokemon:");

            return listaPokemon;
        }
        public static void batalha(MestrePokemon nomeMestre, Pokemon meuPoke, Pokemon enemyPoke)
        {
            Console.Clear();
            Console.WriteLine("Vai começar a batalha pokemon!");
            Console.WriteLine($"{nomeMestre} com o pokemon {meuPoke} contra o pokemon {enemyPoke}\n");

            int acao, round = 1;

            while (meuPoke.EstaVivo && enemyPoke.EstaVivo)
            {
                Console.WriteLine($"Round {round}");
                round++;

                Console.WriteLine($"{nomeMestre} escolha a sua ação");
                Console.WriteLine("1 - Atacar\n2 - Curar");
                
                acao = int.Parse(Console.ReadLine());

                switch (acao)
                {
                    case 1:
                        enemyPoke.danoRecebido(meuPoke.Forca);
                        Console.WriteLine($"{meuPoke} causou {meuPoke.Forca} de dano.\n");
                        break;
                    case 2:
                        meuPoke.usarCura();
                        Console.WriteLine($"{meuPoke} foi curado\n");
                        break;
                    default:
                        Console.WriteLine("Escolha uma opção válida");
                        break;
                }
                Random rand = new Random();
                int enemyAtaque = rand.Next(1, 4);

                switch (enemyAtaque)
                {
                    case 1:
                    case 2:
                        meuPoke.danoRecebido(enemyPoke.Forca);
                        Console.WriteLine($"{enemyPoke} irá atacar");
                        Console.WriteLine($"{enemyPoke} atacou e causou {enemyPoke.Forca} de dano\n");
                        break;
                    case 3:
                        Console.WriteLine($"{enemyPoke} irá se curar");
                        enemyPoke.usarCura();
                        Console.WriteLine($"{enemyPoke} foi curado\n");
                        break;
                }
                string placar = $"{meuPoke}       {enemyPoke}\nHp:{meuPoke.Vida}          Hp:{enemyPoke.Vida}\n";
                Console.WriteLine(placar);

            }
            Console.WriteLine("A batalha terminou. Precione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Fim da batalha pokemon!\n");
            if (enemyPoke.EstaVivo == false)
                Console.WriteLine($"Parabéns {nomeMestre}! \nVocê venceu com seu pokemon, {meuPoke}");
            else
                Console.WriteLine($"Você perdeu!\nO pokemon {enemyPoke} foi o vencedor");
        }

    }

}

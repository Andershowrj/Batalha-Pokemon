using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //---------ÁREA DE TESTES-------------




            //serializarPokemons();
            //listarPokemonsJson();




            //---------ÁREA DE TESTES-------------

            Console.WriteLine("Bem vindo à batalha de mestres pokémon\n");
            Console.Write("Diga seu nome: ");


            string _player = Console.ReadLine();
            //Criando o objeto "p1" pela classe "MestrePokemon
            MestrePokemon p1 = new MestrePokemon(_player);
            

            Console.Clear();
            Console.WriteLine($"Ok {p1.Player}! Agora escolha o seu Pokémon\n");

            Pokemon escolhido = menu();
            enemyPokemon();
            

            Console.WriteLine("\nPrecione qualquer tecla para começar");
            Console.ReadKey();
            
            start();


            //Console.ReadKey();
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
                    Console.WriteLine(i + " - " + poke.Nome);
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
                        Console.WriteLine(pokemonEscolhido.Nome + " foi selecionado");
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
        public static void enemyPokemon()
        {
            //Escolhe aleatoriamente um pokemon adversário
            Random rand = new Random();
            int enemy = rand.Next(1, 4);
            string escolhido = "";
            Console.WriteLine("O seu adversário será:");
            switch (enemy)
            {
                case 1:
                    Pokemon poke4 = new Pokemon("Charmander", "fogo", 10);
                    Console.WriteLine(poke4.Nome);
                    Console.WriteLine("Tipo: " + poke4.Tipo);
                    Console.WriteLine("Força: " + poke4.Forca);
                    escolhido = poke4.Nome;
                    break;
                case 2:
                    Pokemon poke5 = new Pokemon("Bulbasaur", "planta", 10);
                    Console.WriteLine(poke5.Nome);
                    Console.WriteLine("Tipo: " + poke5.Tipo);
                    Console.WriteLine("Força: " + poke5.Forca);
                    escolhido = poke5.Nome;
                    break;
                case 3:
                    Pokemon poke6 = new Pokemon("Squirtle", "água", 10);
                    Console.WriteLine(poke6.Nome);
                    Console.WriteLine("Tipo: " + poke6.Tipo);
                    Console.WriteLine("Força: " + poke6.Forca);
                    escolhido = poke6.Nome;
                    break;
                default:
                    break;
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
        public static void listarPokemonsJson()
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

        }

    }

}

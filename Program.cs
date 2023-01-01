using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BatalhaPokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------ÁREA DE TESTES-------------

            //listaDePokemons();

            //---------ÁREA DE TESTES-------------

            Console.WriteLine("Bem vindo à batalha de mestres pokémon\n");
            Console.Write("Diga seu nome: ");


            string _player = Console.ReadLine();
            //Criando o objeto "p1" pela classe "MestrePokemon
            MestrePokemon p1 = new MestrePokemon(_player);
            

            Console.Clear();
            Console.WriteLine($"Ok {p1.Player}! Agora escolha o seu Pokémon\n");

            //ATÉ AQUI TUDO CERTO -----------

            //Pokemon poke = criarPokemon();

            menu();

            //Console.WriteLine(tupla + " foi selecionado");
            //Console.WriteLine("Tipo: " + poke2.Tipo);
            //Console.WriteLine("Força: " + poke2.Forca);
            //Console.WriteLine();

            enemyPokemon();

            Console.WriteLine();
            Console.WriteLine("Precione qualquer tecla para começar");
            Console.ReadKey();
            
            start();


            //Console.ReadKey();
        }
        
        public static void menu()
        {
            bool exibirMenu = true;

            while(exibirMenu == true)
            {

                //Console.WriteLine("Escolha seu Pokémon:");
                Console.WriteLine("1 - Cyndaquil");
                Console.WriteLine("2 - Totodile");
                Console.WriteLine("3 - Chikorita");
                Console.WriteLine("4 - Acessar POKEDEX");
                Console.WriteLine("\n5 - Sair");

                string opcao = Console.ReadLine();
                Console.Clear();
                Console.WriteLine();

                switch (opcao)
                {
                    case "1":
                        //(string, string, int) tupla = ("Cyndaquil", "Fogo", 12);
                        Pokemon poke1 = new Pokemon("Cyndaquil", "Fogo", 12);
                        Console.WriteLine(poke1.Nome + " foi selecionado");
                        Console.WriteLine("Tipo: " + poke1.Tipo);
                        Console.WriteLine("Força: " + poke1.Forca);
                        Console.WriteLine();
                        opcao = poke1.Nome;
                        exibirMenu = false;
                        break;
                    
                    case "2":
                        //(string, string, int) tupla = ("Totodile", "Água", 15);
                        Pokemon poke2 = new Pokemon("Totodile", "Água", 15);
                        Console.WriteLine(poke2.Nome + " foi selecionado");
                        Console.WriteLine("Tipo: " + poke2.Tipo);
                        Console.WriteLine("Força: " + poke2.Forca);
                        Console.WriteLine();
                        opcao = poke2.Nome;
                        exibirMenu = false;
                    break;
                    
                    case "3":
                        Pokemon poke3 = new Pokemon("Chikorita", "Planta", 10);
                        Console.WriteLine(poke3.Nome + " foi selecionado");
                        Console.WriteLine("Tipo: " + poke3.Tipo);
                        Console.WriteLine("Força: " + poke3.Forca);
                        Console.WriteLine();
                        opcao = poke3.Nome;
                        exibirMenu = false;
                        break;

                    case "4":
                        listaDePokemons();
                        break;

                    case "5":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Número inválido.Escolha 1, 2 ou 3.");
                        break;
                }
            }
        }
        static Pokemon criarPokemon(string nome, string tipo, int forca)
        {
            Pokemon poke = new Pokemon(nome, tipo, forca);
            return poke;
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
        public static void listaDePokemons()
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

            //Mostra a quantidade total de pokemons cadastrados no jogo
            Console.WriteLine($"A sua pokedex tem {listaPokemon.Count} pokemons cadastrados");

            //Lista todos os pokemons cadastrados
            foreach (Pokemon pokemon in listaPokemon)
            {
                Console.WriteLine($"{pokemon.Nome}, tipo {pokemon.Tipo}, ataque {pokemon.Forca}");
            }
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

    }

}

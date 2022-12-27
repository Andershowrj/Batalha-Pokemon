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
            Console.WriteLine("Bem vindo à batalha de mestres pokémon\n");
            Console.Write("Diga seu nome: ");

            string _player = Console.ReadLine();
            //Criando o objeto "p1" pela classe "MestrePokemon
            MestrePokemon p1 = new MestrePokemon(_player);


            Console.Clear();
            Console.WriteLine($"Ok {p1.Player}! Agora escolha o seu Pokémon\n");

            menu();
            enemyPokemon();
            Console.WriteLine();

            //var poke4 = new Pokemon("Arbok", "Veneno", 10);

            //Console.WriteLine();
            //Console.WriteLine("Seu adversário é: {0}", poke4.Nome);
            //Console.WriteLine("Tipo: " + poke4.Tipo);
            //Console.WriteLine("Força: " + poke4.Forca);

            Console.WriteLine();
            Console.WriteLine("Precione qualquer tecla para começar");
            Console.ReadKey();
            
            start();








            //Console.ReadKey();
        }
        public static void start()
        {
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
        public static void menu()
        {
            bool exibirMenu = true;

            while(exibirMenu == true)
            {

                //Console.WriteLine("Escolha seu Pokémon:");
                Console.WriteLine("1 - Cyndaquil");
                Console.WriteLine("2 - Totodile");
                Console.WriteLine("3 - Chikorita");
                Console.WriteLine("\n4 - Sair");

                string opcao = Console.ReadLine();

                switch(opcao)
                {
                    case "1":
                    Pokemon poke1 = new Pokemon("Cyndaquil", "Fogo", 12);
                    Console.WriteLine(poke1.Nome + " foi selecionado");
                    Console.WriteLine("Tipo: " + poke1.Tipo);
                    Console.WriteLine("Força: " + poke1.Forca);
                    opcao = poke1.Nome;
                    exibirMenu = false;
                    break;
                    
                    case "2":
                    Pokemon poke2 = new Pokemon("Totodile", "Água", 15);
                    Console.WriteLine(poke2.Nome + " foi selecionado");
                    Console.WriteLine("Tipo: " + poke2.Tipo);
                    Console.WriteLine("Força: " + poke2.Forca);
                    opcao = poke2.Nome;
                    exibirMenu = false;
                    break;
                    
                    case "3":
                    Pokemon poke3 = new Pokemon("Chikorita", "Planta", 10);
                    Console.WriteLine(poke3.Nome + " foi selecionado");
                    Console.WriteLine("Tipo: " + poke3.Tipo);
                    Console.WriteLine("Força: " + poke3.Forca);
                    opcao = poke3.Nome;
                    exibirMenu = false;
                    break;

                    case "4":
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

            switch (enemy)
            {
                case 1:
                    Pokemon poke4 = new Pokemon("Charmander", "fogo", 10);
                    Console.WriteLine(poke4.Nome + " foi selecionado");
                    Console.WriteLine("Tipo: " + poke4.Tipo);
                    Console.WriteLine("Força: " + poke4.Forca);
                    escolhido = poke4.Nome;
                    break;
                case 2:
                    Pokemon poke5 = new Pokemon("Bulbasaur", "planta", 10);
                    Console.WriteLine(poke5.Nome + " foi selecionado");
                    Console.WriteLine("Tipo: " + poke5.Tipo);
                    Console.WriteLine("Força: " + poke5.Forca);
                    escolhido = poke5.Nome;
                    break;
                case 3:
                    Pokemon poke6 = new Pokemon("Squirtle", "planta", 10);
                    Console.WriteLine(poke6.Nome + " foi selecionado");
                    Console.WriteLine("Tipo: " + poke6.Tipo);
                    Console.WriteLine("Força: " + poke6.Forca);
                    escolhido = poke6.Nome;
                    break;
                default:
                    break;
            }
        }
    }
}

﻿using System;
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
            int escolha;
            string pokeUsado;


            Console.WriteLine("Bem vindo à batalha de mestres pokémon\n");
            Console.Write("Diga seu nick: ");

            //Criando o objeto "nick" pela classe "MestrePokemon
            MestrePokemon nick = new MestrePokemon();
            do
            {
                nick.NomeMestre = Console.ReadLine();
                if (nick.NomeMestre == "")
                    Console.Write("Digite um nick: ");
            }
            while (nick.NomeMestre == "");


            Console.WriteLine();
            Console.WriteLine($"Ok {nick.NomeMestre}! Agora escolha o seu Pokémon\n");

            menu();

            //var poke1 = new Pokemon("Cyndaquil", "Fogo", 12);

            //var poke2 = new Pokemon("Totodile", "Água", 15);

            //var poke3 = new Pokemon("Chikorita", "Planta", 10);

            //do
            //{
            //    Console.WriteLine("1 - " + poke1.NomePokemon);
            //    Console.WriteLine("2 - " + poke2.NomePokemon);
            //    Console.WriteLine("3 - " + poke3.NomePokemon);
            //    Console.Write("Pokémon número: ");
            //    escolha = int.Parse(Console.ReadLine());

            //    if (escolha != 1 && escolha != 2 && escolha != 3)
            //        Console.WriteLine("Número inválido. Escolha 1,2 ou 3.");
            //}
            //while (escolha != 1 && escolha != 2 && escolha != 3);
            
            //if (escolha == 1)
            //{
            //    pokeUsado = poke1.NomePokemon;
            //    Console.WriteLine();
            //    Console.WriteLine(pokeUsado + " foi selecionado");
            //    Console.WriteLine("Tipo: " + poke1.Tipo);
            //    Console.WriteLine("Força: " + poke1.Forca);
            //}
            //else if (escolha == 2)
            //{
            //    pokeUsado = poke2.NomePokemon;
            //    Console.WriteLine();
            //    Console.WriteLine(pokeUsado + " foi selecionado");
            //    Console.WriteLine("Tipo: " + poke2.Tipo);
            //    Console.WriteLine("Força: " + poke2.Forca);
            //}
            //else if (escolha == 3)
            //{
            //    pokeUsado = poke3.NomePokemon;
            //    Console.WriteLine();
            //    Console.WriteLine(pokeUsado + " foi selecionado");
            //    Console.WriteLine("Tipo: " + poke3.Tipo);
            //    Console.WriteLine("Força: " + poke3.Forca);
            //}

            var arboc = new Pokemon("Arbok", "Veneno", 10);

            Console.WriteLine();
            Console.WriteLine("Seu adversário é: {0}", arboc.NomePokemon);
            Console.WriteLine("Tipo: " + arboc.Tipo);
            Console.WriteLine("Força: " + arboc.Forca);

            Console.WriteLine();
            Console.WriteLine("Precione qualquer tecla para começar");
            Console.ReadKey();
            
            start();








            Console.ReadKey();
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
                    Console.WriteLine(poke1.NomePokemon + " foi selecionado");
                    Console.WriteLine("Tipo: " + poke1.Tipo);
                    Console.WriteLine("Força: " + poke1.Forca);
                    exibirMenu = false;
                    break;
                    
                    case "2":
                    Pokemon poke2 = new Pokemon("Totodile", "Água", 15);
                    Console.WriteLine(poke2.NomePokemon + " foi selecionado");
                    Console.WriteLine("Tipo: " + poke2.Tipo);
                    Console.WriteLine("Força: " + poke2.Forca);
                    exibirMenu = false;
                    break;
                    
                    case "3":
                    Pokemon poke3 = new Pokemon("Chikorita", "Planta", 10);
                    Console.WriteLine(poke3.NomePokemon + " foi selecionado");
                    Console.WriteLine("Tipo: " + poke3.Tipo);
                    Console.WriteLine("Força: " + poke3.Forca);
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
    }
}
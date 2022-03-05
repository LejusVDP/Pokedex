﻿using Pokedex.Enums;
using Pokedex.Models;
using Pokedex.Models.Pokemons;
using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using Pokedex.Models.Moves;

namespace Pokedex
{
    class Program
    {
        public static Random Random = new Random();
        static void Main()
        {
            int lineIndex = 0;
            List<string> inputLines = new List<string>();
            foreach (string line in File.ReadLines("Data\\Input.txt")) inputLines.Add(line);


            Console.Write("Choose you gender (F, M or O) : ");

            Console.WriteLine(inputLines[lineIndex]);
            string g = inputLines[lineIndex++];
            Gender gender = (Gender)Enum.Parse(typeof(Gender), g);


            Console.Write("Choose your Trainer name : ");
            
            Console.WriteLine(inputLines[lineIndex]);
            Player Player1 = new(inputLines[lineIndex++], gender);


            Console.WriteLine("What Pokemon do you want to start with ?\n" +
                                "\t- Bulbasaur\n" +
                                "\t- Charmander\n" +
                                "\t- Squirtle\n");

            Console.WriteLine(inputLines[lineIndex]);
            switch (
                new CultureInfo("en")
                .TextInfo
                .ToTitleCase(
                    inputLines[lineIndex++]
                    .ToLower()
                ))
            {
                case "Bulbasaur" :
                {
                    Player1.AddPokemon(new Bulbasaur( 100 ));
                    break;
                }

                case "Charmander" :
                {
                    Player1.AddPokemon(new Charmander( 100 ));
                    break;
                }

                case "Squirtle" :
                {
                    Player1.AddPokemon(new Squirtle( 100 ));
                    Move avalanche = new MoveAvalanche();
                    Player1.Pokemons[0].AddMove(avalanche);
                    Console.WriteLine(avalanche.FullStatus);
                    break;
                }
            }


            Console.Write("\n" +
                "How should it be called ? ");
            
            Console.WriteLine(inputLines[lineIndex]);
            Player1.Pokemons[0].Nickname = inputLines[lineIndex++];


            foreach (Pokemon poke in Player1.Pokemons)
            {
                Console.WriteLine(poke.ToString() + poke.FullStatus);
            }

            //Console.WriteLine(Wiki.Instance.ToString());
            
            Battle battle = new Battle(
                Player1,
                AIPlayer.Instance
            );

            Move moveTackle = new MoveTackle();
            Console.WriteLine(moveTackle.FullStatus);

            //Console.WriteLine("hp: " + Player1.Pokemons[0].IV.Get("hp"));
            //Console.WriteLine("attack: " + Player1.Pokemons[0].IV.Get("attack"));
            //Console.WriteLine("defense: " + Player1.Pokemons[0].IV.Get("defense"));
            //Console.WriteLine("sp_attack: " + Player1.Pokemons[0].IV.Get("sp_attack"));
            //Console.WriteLine("sp_defense: " + Player1.Pokemons[0].IV.Get("sp_defense"));
            //Console.WriteLine("speed: " + Player1.Pokemons[0].IV.Get("speed"));
            //Console.WriteLine(Player1.Pokemons[0].StatsString);
        }
    }
}
using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Play Play1 = new Play();
            Play Play2 = new Play();

            Player Player1 = new Player();
            Player Player2 = new Player();

            Referee Referee = new Referee();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("----------------");
                Console.WriteLine($"Game {i + 1}");
                Console.WriteLine("----------------");
                Console.WriteLine("Player 1: ");
                
                Player1.play(Play1);
                Player1.toString();
                Console.WriteLine("Player 2: ");
                Player2.play(Play2);
                Player2.toString();
                Console.WriteLine("Result: ");
                Referee.decideWinner(Player1, Player2);
                Console.WriteLine(" ");

            }
        }
    }
    class Play
    {
        private List<string> elements;
        public Play()
        {
            this.elements = new List<string> { "rock", "paper", "scissors" };
        }
        static Random rnd = new Random();
        public string generatePlay()
        {
            int randomNumber = rnd.Next(this.elements.Count);
            return elements[randomNumber];
        }
    }

    class Player
    {
        private string gun;
        public void play(Play jugada)
        {
            jugada.generatePlay();
            this.gun= jugada.generatePlay();
        }
        public string checkPlay()
        {
            return this.gun;
        }
        public void toString()
        {
            Console.WriteLine($"   { this.gun}");
        }
        
    }
    class Referee
    {
        public void decideWinner(Player Player1 ,Player Player2)
        {
            if (Player1.checkPlay() == Player2.checkPlay())
            {
                Console.WriteLine("   tie");
            }
            else if (Player1.checkPlay() == "rock")
            {
                if (Player2.checkPlay() == "paper") Console.WriteLine("   Player 2 win");
                else Console.WriteLine("   Player 1 win");
            }
            else if (Player1.checkPlay() == "paper")
            {
                if (Player2.checkPlay() == "rock") Console.WriteLine("   Player 1 win");
                else Console.WriteLine("   Player 2 win");
            }
            else
            {
                if (Player2.checkPlay() == "rock") Console.WriteLine("   Player 2 win");
                else Console.WriteLine("   Player 1 win");
            }

        }

    }
}

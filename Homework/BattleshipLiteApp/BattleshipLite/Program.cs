using BattleshipLiteLibrary;
using BattleshipLiteLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BattleshipLite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();
            PlayerInfoModel activePlayer = CreatePlayer("Player 1");
            PlayerInfoModel opponent = CreatePlayer("Player 2");

            PlayerInfoModel winner = null;
            do
            {
                // Display grid from activePlayer on where they fire
                DisplayShotGrid(activePlayer);

                // Ask activePlayer for a shot
                // Determine if it is a valid shot
                // Determine shot results
                RecordPlayerShot(activePlayer, opponent);

                // Determine if the game should continue
                bool doesGameContinue = GameLogic.PlayerStillActive(opponent);

                // If over, set player1 as winner

                // Else, swap positions (activePlayer to opponent)
                if (doesGameContinue == true)
                {
                    // swap using a temp variable
                    //PlayerInfoModel temp = opponent;
                    //opponent = activePlayer;
                    //activePlayer = temp;

                    // swap using tuplet
                    (opponent, activePlayer) = (activePlayer, opponent);
                    
                }
                else
                {
                    winner = activePlayer;
                }
            } while (winner == null);

            IdentifyWinner(winner);

            Console.ReadLine();
            Console.ReadLine();
        }

        private static void IdentifyWinner(PlayerInfoModel winner)
        {
            Console.WriteLine($"Congratulation to {winner.Username} for winning!");
            Console.WriteLine($"{winner.Username} took {GameLogic.GetShootCount(winner)} shoots.");
        }

        private static void RecordPlayerShot(PlayerInfoModel activePlayer, PlayerInfoModel opponent)
        {
            bool isValidShot = false;
            string row = "";
            int column = 0;

            do
            {
                // Asks for a shot (do we ask for "B2")
                string shot = AskForUserShot(activePlayer);

                try
                {
                    // Determine what row and column that is - split
                    (row, column) = GameLogic.SplitShotIntoRowAndColumn(shot);

                    // Determine if that is a valid shot
                    isValidShot = GameLogic.ValidateShot(activePlayer, row, column);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    isValidShot=false;
                }

                if (isValidShot == false)
                {
                    Console.WriteLine("Invalid shot location. Please try again.");
                }

                // Go back to beginning if not a valid shot
            } while (isValidShot == false);

            // Determine shot results
            bool isAHit = GameLogic.IdentifyShotResult(opponent, row, column);

            GameLogic.MarkShotResult(activePlayer, row, column, isAHit);

            DisplayShotResults(row, column, isAHit);

        }

        private static void DisplayShotResults(string row, int column, bool isAHit)
        {

            if (isAHit)
            {
                Console.WriteLine($"{row}{column} is a Hit!");
            }
            else
            {
                Console.WriteLine($"{row}{column} is a miss!");
            }
            Console.WriteLine();
        }

        private static string AskForUserShot(PlayerInfoModel player)
        {
            Console.WriteLine($"{player.Username}, Please enter your shot selection: ");
            string output = Console.ReadLine();
            return output;
        }

        private static void DisplayShotGrid(PlayerInfoModel activePlayer)
        {
            string currentRow = activePlayer.ShotGrid[0].SpotLetter;
            foreach (var gridSpot in activePlayer.ShotGrid)
            {
                // if it's on the same row ignore this, else print a line
                if (gridSpot.SpotLetter != currentRow)
                {
                    Console.WriteLine();
                    currentRow = gridSpot.SpotLetter;
                }

                if (gridSpot.Status == GridSpotStatus.Empty)
                {
                    Console.Write($" {gridSpot.SpotLetter}{gridSpot.SpotNumber} ");
                }
                else if (gridSpot.Status == GridSpotStatus.Hit)
                {
                    Console.Write(" X  ");
                }
                else if (gridSpot.Status == GridSpotStatus.Miss)
                {
                    Console.Write(" O  ");
                }
                else
                {
                    Console.Write(" ?  ");
                }
            };
            Console.WriteLine();
            Console.WriteLine();
        }
        private static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Battleship lite");
            Console.WriteLine("created by Andrew");
            Console.WriteLine("-----------------------------------------------");
        }
        private static PlayerInfoModel CreatePlayer(string playerTitle)
        {
            PlayerInfoModel output = new PlayerInfoModel();

            Console.WriteLine($"Player information for {playerTitle}");

            // Ask user for their name
            output.Username = AskForUserName();

            // Load up the shot grid
            GameLogic.InitializeGrid(output);

            // Ask the user for their 5 ship placement
            PlaceShips(output);

            // Clear the screen
            Console.Clear();

            return output;
        }
        private static string AskForUserName()
        {
            Console.Write("Enter your username: ");
            string output = Console.ReadLine();

            return output;
        }
        private static void PlaceShips(PlayerInfoModel model)
        {
            do
            {
                Console.Write($"Where do you want to place your ship number {model.ShipLocations.Count + 1}: ");
                string location = Console.ReadLine();

                bool isValidLocation = false;

                try
                {
                    isValidLocation = GameLogic.PlaceShip(model, location);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                if (isValidLocation == false)
                {
                    Console.WriteLine("That was not a valid location. Please try again.");
                }
            } while (model.ShipLocations.Count < 5);
        }
    }
}

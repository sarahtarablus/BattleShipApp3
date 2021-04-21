using System;
using System.Text.RegularExpressions;
namespace BattleShipApp3
{
    public class PlayGame
    {
        public int correctCount = 0;
        public int[] guessesCount = new int[8] { 0, 1, 2, 3, 4, 5, 6, 7 };
        public int counter { get; set; }
        public int correctGuesses { get; set; }






        public static bool betweenRange(int x, int y, int num)
        {
            return (x <= num && num <= y);
        }







        public string enterCoordinate()
        {

            Regex r = new Regex(@"[a-jA-J]+");
            Regex w = new Regex(@"[0-9][a-zA-Z]");
            Console.WriteLine("Type a number between 0 and 9");
            string numberString = Console.ReadLine();

            for (int x = 0; x < numberString.Length; x++)
            {
                while (char.IsLetter(numberString[x]) || numberString.Length > 1)
                {
                    Console.WriteLine("Make sure to type only a number between 0 and 9.");
                    numberString = Console.ReadLine();
                }
            }

            int number = Convert.ToInt32(numberString);

            Console.WriteLine("Type a letter between 'a' and 'j'");
            string letter = Console.ReadLine();

            for(int i = 0; i < letter.Length; i++)
            {
                while (!char.IsLetter(letter[i]) || letter.Length > 1 || !r.IsMatch(letter))
                {
                    Console.WriteLine("Make sure to type only a letter between 'a' and 'j'.");
                    letter = Console.ReadLine();
                }
            }


            //while (!r.IsMatch(letter))
            //{
            //    Console.WriteLine("Make sure to type only a letter between 'a' and 'j'.");
            //    letter = Console.ReadLine();
            //}

            string coordinate = number.ToString() + letter;

            return coordinate;
        }





        public int checkCoordinate(string[] ship, string message, int num)
        {
            string coord = enterCoordinate();
            if (Array.IndexOf(ship, coord) != -1)
            {
                correctCount++; counter++;
                Console.WriteLine(message);
            }
            else
            {
                counter++;
                Console.WriteLine($"No match. You have {num} more tries. ");
            }
            return correctCount;
        }





        public void resetGame(string message)
        {
            Console.WriteLine(message);
            char keyPressed = Console.ReadKey(true).KeyChar;
            if (keyPressed == 'q' || keyPressed == 'Q')
            {
                correctCount = 0;
                counter = 0;
                play();
            }
            else return;
        }





        public void play()
        {
            ComputerShip ship = new ComputerShip();
            ship.generateShipPosition();

            GameGrid grid = new GameGrid();
            grid.displayGrid();
            string[] shipPosition = ship.positions;

            for (int i = guessesCount.Length - 1; i >= 0; i--)
            {
                if (correctCount < 4)
                {

                    checkCoordinate(shipPosition, $"Correct! You have {guessesCount[i]} more tries", guessesCount[i]);
                }
                else if (correctCount == 4)
                {
                    checkCoordinate(shipPosition, "", guessesCount[i]);
                    if (correctCount == 5) resetGame("You won! The ship has sunk. To play again press Q. To exit press anyother key");
                }
            }
            resetGame("Game over! To play again press Q. To exit press anyother key");
        }

    }
}




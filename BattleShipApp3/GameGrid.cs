using System;
namespace BattleShipApp3
{
    public class GameGrid
    {
        int[] numbers = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        char[] letters = new char[10] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };
        string column1;
        string column2;
        string column3;
        string column4;
        string column5;
        string column6;
        string column7;
        string column8;
        string column9;
        string column10;

        public void displayGrid()
        {
            foreach (int number in numbers)
            {
                column1 = number.ToString() + " " + letters[0].ToString() + "  ";
                column2 = number.ToString() + " " + letters[1].ToString() + "  ";
                column3 = number.ToString() + " " + letters[2].ToString() + "  ";
                column4 = number.ToString() + " " + letters[3].ToString() + "  ";
                column5 = number.ToString() + " " + letters[4].ToString() + "  ";
                column6 = number.ToString() + " " + letters[5].ToString() + "  ";
                column7 = number.ToString() + " " + letters[6].ToString() + "  ";
                column8 = number.ToString() + " " + letters[7].ToString() + "  ";
                column9 = number.ToString() + " " + letters[8].ToString() + "  ";
                column10 = number.ToString() + " " + letters[9].ToString() + "  ";

                Console.WriteLine(column1 + column2 + column3 + column4 + column5 + column6 + column7 + column8 + column9 + column10);


            }
        }
    }
}




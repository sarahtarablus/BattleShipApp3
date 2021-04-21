using System;
namespace BattleShipApp3
{
    public class ComputerShip
    {
        static Random random = new Random();
        bool direction = random.Next(0, 2) > 0;
        int direction2 = random.Next(1, 3);
        int direction3 = random.Next(1, 4);
        int number = random.Next(0, 9);
        char letter = (char)random.Next('a', 'j');
        public string[] positions = new string[5];
        string letterPosition;



        public string numberToString(int number)
        {

            if (number == 0) return letterPosition = "a";
            if (number == 1) return letterPosition = "b";
            if (number == 2) return letterPosition = "c";
            if (number == 3) return letterPosition = "d";
            if (number == 4) return letterPosition = "e";
            if (number == 5) return letterPosition = "f";
            if (number == 6) return letterPosition = "g";
            if (number == 7) return letterPosition = "h";
            if (number == 8) return letterPosition = "i";
            return letterPosition = "j";
        }



        public void rightDirection(int letterPos)
        {
            positions.SetValue(number.ToString() + numberToString(letterPos + 1), 1);
            positions.SetValue(number.ToString() + numberToString(letterPos + 2), 2);
            positions.SetValue(number.ToString() + numberToString(letterPos + 3), 3);
            positions.SetValue(number.ToString() + numberToString(letterPos + 4), 4);
        }



        public void leftDirection(int letterPos)
        {
            positions.SetValue(number.ToString() + numberToString(letterPos - 1), 1);
            positions.SetValue(number.ToString() + numberToString(letterPos - 2), 2);
            positions.SetValue(number.ToString() + numberToString(letterPos - 3), 3);
            positions.SetValue(number.ToString() + numberToString(letterPos - 4), 4);
        }


        public void downDirection()
        {

            positions.SetValue((number + 1).ToString() + letter, 1);
            positions.SetValue((number + 2).ToString() + letter, 2);
            positions.SetValue((number + 3).ToString() + letter, 3);
            positions.SetValue((number + 4).ToString() + letter, 4);
        }



        public void upDirection()
        {

            positions.SetValue((number - 1).ToString() + letter, 1);
            positions.SetValue((number - 2).ToString() + letter, 2);
            positions.SetValue((number - 3).ToString() + letter, 3);
            positions.SetValue((number - 4).ToString() + letter, 4);
        }



        public void generateShipPosition()
        {
            string position = number.ToString() + letter.ToString();
            int letterToNumber = (int)letter % 32 - 1;
            positions.SetValue(position, 0);

            if (number < 4 && letterToNumber < 4)
            {
                if (direction) downDirection();
                else rightDirection(letterToNumber);
            }
            else if (number < 4 && letterToNumber > 5)
            {
                if (direction) downDirection();
                else leftDirection(letterToNumber);
            }
            else if (number > 5 && letterToNumber < 4)
            {
                if (direction) upDirection();
                else rightDirection(letterToNumber);
            }
            else if (number > 5 && letterToNumber > 5)
            {
                if (direction) upDirection();
                else leftDirection(letterToNumber);
            }
            else if (number == 4 || number == 5 && letterToNumber < 4)
            {
                if (direction2 == 1) upDirection();
                if (direction2 == 2) downDirection();
                if (direction2 == 3) rightDirection(letterToNumber);
            }
            else if (number == 4 || number == 5 && letterToNumber > 5)
            {
                if (direction2 == 1) upDirection();
                if (direction2 == 2) downDirection();
                if (direction2 == 3) leftDirection(letterToNumber);
            }
            else if (letterToNumber == 4 || letterToNumber == 5 && number < 4)
            {
                if (direction2 == 1) rightDirection(letterToNumber);
                if (direction2 == 2) downDirection();
                if (direction2 == 3) leftDirection(letterToNumber);
            }
            else if (letterToNumber == 4 || letterToNumber == 5 && number > 5)
            {
                if (direction2 == 1) rightDirection(letterToNumber);
                if (direction2 == 2) upDirection();
                if (direction2 == 3) leftDirection(letterToNumber);
            }
            else if (number == 4 || number == 5 && letterToNumber == 4 || letterToNumber == 5)
            {
                if (direction3 == 1) rightDirection(letterToNumber);
                if (direction3 == 2) upDirection();
                if (direction3 == 3) leftDirection(letterToNumber);
                if (direction3 == 4) downDirection();
            }

            Console.WriteLine(positions[0] + positions[1] + positions[2] + positions[3] + positions[4]);
        }
    }
}


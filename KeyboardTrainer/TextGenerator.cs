using System;


namespace KeyboardTrainer
{
    internal class TextGenerator
    {
        static char[] charsLevelZero = new char[] { 'r', 't', 'y', 'u', 'f', 'g', ' ', 'h', 'j', 'v', 'b', 'n', 'm' };
        static char[] charsLevelOne = new char[] { 'r', 't', 'y', 'u', 'f', 'g', ' ', 'h', 'j', 'v', 'b', 'n', 'm', '5', '6', '7', '8' };
        static char[] charsLevelTwo = new char[] { 'r', 't', 'y', 'u', 'f', 'g', ' ', 'h', 'j', 'v', 'b', 'n', 'm', '5', '6', '7', '8', 'e', 'd', 'c', '4', 'i', 'k', ',', '9' };
        /*static char[] charsLevelThree = new char[] { 'r', 't', 'y', 'u', 'f', 'g', 'h', 'j', 'v', 'b', 'n', 'm' };
        static char[] charsLevelFour = new char[] { 'r', 't', 'y', 'u', 'f', 'g', 'h', 'j', 'v', 'b', 'n', 'm' };
        static char[] charsLevelFive = new char[] { 'r', 't', 'y', 'u', 'f', 'g', 'h', 'j', 'v', 'b', 'n', 'm' };
        static char[] charsLevelSix = new char[] { 'r', 't', 'y', 'u', 'f', 'g', 'h', 'j', 'v', 'b', 'n', 'm' };
        static char[] charsLevelSeven = new char[] { 'r', 't', 'y', 'u', 'f', 'g', 'h', 'j', 'v', 'b', 'n', 'm' };
        static char[] charsLevelEight = new char[] { 'r', 't', 'y', 'u', 'f', 'g', 'h', 'j', 'v', 'b', 'n', 'm' };
        static char[] charsLevelNine = new char[] { 'r', 't', 'y', 'u', 'f', 'g', 'h', 'j', 'v', 'b', 'n', 'm' };
        static char[] charsLevelTen = new char[] { 'r', 't', 'y', 'u', 'f', 'g', 'h', 'j', 'v', 'b', 'n', 'm' };*/
        static public string GetTextByDiffLvl( int diffLvl)
        {
            char[] currentLevelMassive;

            switch (diffLvl)
            {
                case 1: currentLevelMassive = charsLevelZero; break;
                case 2: currentLevelMassive = charsLevelOne; break;
                case 3: currentLevelMassive = charsLevelTwo; break;
                default: currentLevelMassive = charsLevelZero; break;
            }
            return GenerateText(currentLevelMassive);
        }

        static string GenerateText(char[] chars)
        {
            string resultText= "";
            Random rnd = new Random();
            for (int i = 0; i < 70; i++)
            {
                resultText += chars[rnd.Next(0, chars.Length)];
            }

            return resultText;
        }

    }
}

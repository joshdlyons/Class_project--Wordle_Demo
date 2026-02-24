using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC102_Final_Project
{
    internal class InputOutput
    {
        public List<string> guessList { get; } = new List<string>();
        public string[,] guessedLetters = new string[6, 5];

        public int lettersFilled = 0;
        public static int guesses = 0;

        GameLogic Game = new GameLogic();

        public void processKeystrokes(Keys key)
        {
            int row = lettersFilled / 5;
            int col = lettersFilled % 5;

            string letter = key.ToString();
            bool keyIsLetter = false;

            if (key >= Keys.A && key <= Keys.Z)
                keyIsLetter = true;

            if (lettersFilled < (guesses + 1) * 5 && keyIsLetter && guesses < 6)
            {
                Wordle.inputLabelsArray[row, col].Text = letter;
                guessedLetters[row, col] = letter;

                lettersFilled++;
            }

            if (key == Keys.Back && lettersFilled > guesses * 5)
            {
                if (lettersFilled % 5 == 0)
                {
                    Wordle.inputLabelsArray[row - 1, col + 4].Text = "";
                    guessedLetters[row - 1, col + 4] = "";
                }
                else
                {
                    Wordle.inputLabelsArray[row, col - 1].Text = "";
                    guessedLetters[row, col - 1] = "";
                }

                lettersFilled--;
            }
        }

        public string GuessSubmitted()
        {
            if (lettersFilled % 5 == 0 && lettersFilled == (guesses + 1) * 5)
            {
                string guess = "";

                for (int counter = 0; counter < 5; counter++)
                {
                    guess += guessedLetters[guesses, counter];
                }

                if (guesses < 6 && Game.CheckValidGuess(guess, guessList, FileManager.wordDict))
                {
                    guessList.Add(guess);
                    guesses++;
                    return guess;
                }

                return null;
            }

            if (guesses < 6)
            {
                MessageBox.Show("Word must be a valid five letter word.");
            }

            return null;
        }

        public void ResetData()
        {
            lettersFilled = 0;
            guesses = 0;
            guessList.Clear();
            guessedLetters = new string[6, 5];
        }
    }
}

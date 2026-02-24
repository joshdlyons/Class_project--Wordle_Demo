using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC102_Final_Project
{
    internal class GameLogic
    {

        public GameLogic() 
        {
            foreach(char key in Wordle.keyboardKeys)
            {
                keyboardColors.Add(key, "CONTROL");
            }
        }
        
        public Dictionary<char, string> keyboardColors = new Dictionary<char, string>();
        public static string debugWord = "";

        public void EvaluateGuess(string guess, string word)
        {
            // This method determines what letters match the word and therefore what labels to change colors

            // Variables to keep track of how many times a letter appears in a word so we don't color in duplicates
            Dictionary<char, int> counter = new Dictionary<char, int>();
            int[] letterInWordArray = new int[] { 0, 0, 0, 0, 0 };
            bool[] inWord = new bool[] {false, false, false, false, false};

            // This initializes a counter to track how many of each letter have been guessed so far
            foreach (char key in Wordle.keyboardKeys)
            {
                counter.Add(key, 0);
            }


            for (int y = 0; y < guess.Length; y++)
            {
                // This fills a counter that tracks how many of each letter are in the word
                foreach (char letter in word)
                {
                    if (letter == guess[y])
                    {
                        letterInWordArray[y]++;
                    }
                }
                   
                // This calls a method to make labels green if they should be and adds one to the counter for that letter
                if (guess[y] == word[y])
                {
                    handleLetterInLetter(guess[y], ref inWord[y], y);
                    counter[guess[y]]++;
                }
            }

            // This does the same thing for orange, doing it if the letter is in the word at all rather than in the correct spot
            for (int y = 0; y < guess.Length; y++)
            {
                for (int x = 0; x < word.Length; x++)
                {
                    if (guess[y] == word[x] && counter[guess[y]] < letterInWordArray[y] && !(guess[y] == word[y]))
                    {
                        Wordle.inputLabelsArray[InputOutput.guesses - 1, y].SetLabelColor("ORANGE");
                        counter[guess[y]]++;
                        inWord[y] = true;
                        break;
                    }
                }

                handleLabelColoring(guess[y], ref inWord[y], y);
            }
        }

        private void handleLetterInLetter(char guessLetter, ref bool inWord, int num)
        {
            Wordle.inputLabelsArray[InputOutput.guesses - 1, num].SetLabelColor("GREEN");
            Wordle.keyboardLabelsDict[guessLetter].SetLabelColor("GREEN");
            keyboardColors[guessLetter] = "GREEN";
            inWord = true;
        }

        private void handleLabelColoring(char guessLetter, ref bool inWord, int num)
        {
            if (keyboardColors[guessLetter] != "GREEN" && inWord)
            {
                Wordle.keyboardLabelsDict[guessLetter].SetLabelColor("ORANGE");
                keyboardColors[guessLetter] = "ORANGE";
            }

            if (!inWord)
            {
                Wordle.inputLabelsArray[InputOutput.guesses - 1, num].SetLabelColor("GRAY");

                if (keyboardColors[guessLetter] == "CONTROL")
                {
                    Wordle.keyboardLabelsDict[guessLetter].SetLabelColor("GRAY");
                    keyboardColors[guessLetter] = "GRAY";
                }
            }
        }

        public bool CheckValidGuess(string guess, List<string> pastGuesses, Dictionary<string, int> wordList)
        {
            bool guessValid = false;

            foreach (KeyValuePair<string, int> pair in wordList)
            {
                if (guess == pair.Key)
                {
                    guessValid = true;
                    break;
                }
            }

            if (guess == debugWord)
            {
                guessValid = true;
            }

            if (!guessValid)
            {
                MessageBox.Show("Guess is not in word list.");
            }

            for (int i = 0; i < pastGuesses.Count; i++)
            {
                if (guess == pastGuesses[i])
                {
                    guessValid = false;
                    MessageBox.Show("That has already been guessed.");
                    break;
                }
            }

            return guessValid;
        }

        public void ResetData()
        {
            keyboardColors.Clear();

            foreach (char key in Wordle.keyboardKeys)
            {
                keyboardColors.Add(key, "CONTROL");
            }
        }
    }
}
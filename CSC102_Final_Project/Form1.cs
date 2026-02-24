using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace CSC102_Final_Project
{
    public partial class Wordle : Form
    {
        public static Label[,] inputLabelsArray = new Label[6, 5];
        public static Dictionary<char, Label> keyboardLabelsDict = new Dictionary<char, Label>();
        public static char[] keyboardKeys = new char[26] {'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D',
                                                   'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M'};

        public string word;
        public static bool gameWon = false;

        InputOutput InOut = new InputOutput();
        FileManager Files = new FileManager("WordList.txt");
        GameLogic Game = new GameLogic();

        public Wordle()
        {
            InitializeComponent();

            // (This is to add these parts of the form to a click method in order to refocus to the main game)
            this.Click += new EventHandler(L_Click);
            debugPanel.Click += new EventHandler(L_Click);
            debugLabel.Click += new EventHandler(L_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeLabels();

            // Reading the file and getting the word
            Files.ReadFile();
            word = Files.GetWord();
        }

        private void InitializeLabels()
        {   
            // Initializing Input Text Labels 
            for (int y = 0; y < inputLabelsArray.GetLength(0); y++)
            {
                for (int x = 0; x < inputLabelsArray.GetLength(1); x++)
                {
                    inputLabelsArray[y, x] = new Label().SetLabelSettings(x, Color.White, new Size(50, 50), new Font("Arial", 24, FontStyle.Bold));
                    inputLabelsArray[y, x].Location = new Point((x * 55) + 74, (y * 55) + 20);
                    inputLabelsArray[y, x].Click += new EventHandler(L_Click);
                    this.Controls.Add(inputLabelsArray[y, x]);
                }
            }

            // Initialiing Keyboard Labels
            for (int key = 0; key < keyboardKeys.Length; key++)
            {
                char labelChar = keyboardKeys[key];

                keyboardLabelsDict.Add(labelChar, new Label().SetLabelSettings(key, Color.FromKnownColor(KnownColor.Control), new Size(32, 40), new Font("Arial", 10, FontStyle.Bold)));
                keyboardLabelsDict[labelChar].Text = keyboardKeys[key].ToString();

                if (key <= 9)
                {
                    keyboardLabelsDict[labelChar].Location = new Point((key * 36) + 30, 355);
                }
                else if (key >= 10 && key <= 18)
                {
                    keyboardLabelsDict[labelChar].Location = new Point(((key - 10) * 36) + 48, 400);
                }
                else
                {
                    keyboardLabelsDict[labelChar].Location = new Point(((key - 19) * 36) + 84, 445);
                }

                keyboardLabelsDict[labelChar].Click += new EventHandler(L_Click);
                this.Controls.Add(keyboardLabelsDict[labelChar]);
            }
        }

        private void L_Click(object sender, EventArgs e)
        {
            enterButton.Focus();
        }

        private void Wordle_KeyDown(object sender, KeyEventArgs e)
        {
            if (!newWordTextBox.Focused && !gameWon)
            {
                InOut.processKeystrokes(e.KeyCode);
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            // Or just pass each guess in along with the guess num and it can make its own array?

            string guess = null;

            if (!newWordTextBox.Focused)
            {
                if (!gameWon)
                {
                    guess = InOut.GuessSubmitted();
                }
            }
            else
            {
                setNewWordButton_Click(sender, e);
            }

            if (guess != null)
            {
                Game.EvaluateGuess(guess, word);
            }
            if (guess == word)
            {
                MessageBox.Show($"Congrats! You guessed the word in {InputOutput.guesses} guess(es).");
                gameWon = true;
            }
            if (InputOutput.guesses == 6 && !gameWon)
            {
                MessageBox.Show("Better luck next time! \nYou may exit the program or load a new word.");
            }
        }

        private void setNewWordButton_Click(object sender, EventArgs e)
        {
            if(newWordTextBox.Text.Length == 5)
            {
                ReloadGame(newWordTextBox.Text, newWordTextBox.Text);
                newWordTextBox.Clear();
                enterButton.Focus();
                MessageBox.Show($"{word} set as the new word.");
            }
            else
            {
                MessageBox.Show("Please enter a word with EXACTLY five characters.");
            } 
        }

        private void reloadWordButton_Click(object sender, EventArgs e)
        {
            ReloadGame(word, GameLogic.debugWord);

            enterButton.Focus();
        }

        private void loadNewWordButton_Click(object sender, EventArgs e)
        {
            ReloadGame(Files.GetWord(), "");

            enterButton.Focus();
        }

        private void ReloadGame(string newWord, string newDebugWord)
        {
            InOut.ResetData();
            Game.ResetData();
            
            word = newWord;
            gameWon = false;
            GameLogic.debugWord = newWord;

            foreach(Label label in keyboardLabelsDict.Values)
            {
                label.SetLabelColor("CONTROL");
            }

            for (int y = 0; y < inputLabelsArray.GetLength(0); y++)
            {
                for (int x = 0; x < inputLabelsArray.GetLength(1); x++)
                {
                    inputLabelsArray[y, x].Text = "";
                    inputLabelsArray[y, x].SetLabelColor("DEFAULT");
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Files.UpdateFile();
            this.Close();
        }
    }
}
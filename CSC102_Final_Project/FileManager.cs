using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC102_Final_Project
{
    internal class FileManager
    {
        public FileManager(string path) { Path = path; }

        public static Dictionary<string, int> wordDict { get; } = new Dictionary<string, int>();

        private string Path { get; set; }

        public Dictionary<string, int> ReadFile()
        {
            char delim = ',';
            string line;
            string[] tokens = new string[2];

            try
            {
                StreamReader inputfile;
                inputfile = File.OpenText(Path);

                while (!inputfile.EndOfStream)
                {
                    line = inputfile.ReadLine();
                    tokens = line.Split(delim);
                    wordDict.Add(tokens[0], int.Parse(tokens[1]));
                    Console.WriteLine(line);
                }

                inputfile.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return wordDict;
        }

        public void UpdateFile()
        {
            string line;

            try
            {
                StreamWriter outputfile;
                outputfile = File.CreateText(Path);

                foreach (KeyValuePair<string, int> pair in wordDict)
                {
                    line = $"{pair.Key},{pair.Value.ToString()}";
                    outputfile.WriteLine(line);
                }

                outputfile.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public string GetWord()
        {         
            Random rand = new Random();
            int wordNum = rand.Next(wordDict.Count);

            KeyValuePair<string, int> wordPair = wordDict.ElementAt(wordNum);

            string word = wordDict.ElementAt(wordNum).Key;
            
            //( WE'LL ENABLE THIS LATER TO UPDATE THE WORD USE COUNTER )
            //wordDict[word]++;

            return word;
        }
    }
}

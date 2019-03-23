using System;

namespace WordGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static void AddWords(string word)
        {
            string filePath = "./addWords.txt";
            string[] wordsArray = new string[] { word };
            System.IO.File.AppendAllLines(filePath, wordsArray);
        }
    }
}

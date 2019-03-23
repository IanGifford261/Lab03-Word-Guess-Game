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
            string filePath = "./gameWords.txt";
            string[] wordsArray = new string[] { word };
            System.IO.File.AppendAllLines(filePath, wordsArray);
        }
        public static void DeleteWords()
        {
            string filePath = "./gameWords.txt";

            System.IO.File.Delete(filePath);
        }
    }
}

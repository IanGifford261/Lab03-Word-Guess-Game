using System;

namespace WordGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Word Guessing Game");
            Console.WriteLine(" ");
            Console.WriteLine("Please select a menu option 1-3. Your input must be numerical");
            Console.WriteLine(" ");
            Console.WriteLine("1. Play Game");
            Console.WriteLine(" ");
            Console.WriteLine("2. Admin Menu");
            Console.WriteLine(" ");
            Console.WriteLine("3. Exit Game");

            string userInput = Console.ReadLine();
            int userChoice = Convert.ToInt32(userInput);
            switch(userChoice)
            {
                case 1:
                    PlayGame();
                    break;

                case 2:
                    AdminMenu();
                    break;

                case 3:
                    GameExit();
                    break;

            }
        }
        //public static int PlayGame()
        //{
        //    Console.WriteLine("");
        //}

        //public static int AdminMenu()
        //{

        //}

        public static void GameExit()
        {
            Console.WriteLine("Thank you for playing!");
            Environment.Exit(0);
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

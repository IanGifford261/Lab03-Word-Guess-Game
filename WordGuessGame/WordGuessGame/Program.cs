using System;
using System.IO;

namespace WordGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runGameMenu = true;
            do
            {
                Console.WriteLine(" ");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Welcome to the Word Guessing Game");
                Console.WriteLine(" ");
                Console.WriteLine("Please select a menu option 1-3. Your input must be numerical");
                Console.WriteLine(" ");
                Console.WriteLine("1. Play Game");
                Console.WriteLine(" ");
                Console.WriteLine("2. Admin Menu");
                Console.WriteLine(" ");
                Console.WriteLine("3. Exit Game");
                Console.WriteLine(" ");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine(" ");

                string userInput = Console.ReadLine();
                int userChoice = Convert.ToInt32(userInput);
                switch (userChoice)
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

            } while (runGameMenu);
        }

        public static void PlayGame()
        {
            Console.WriteLine("Please guess any letter, Good Luck!");


        }

        public static void AdminMenu()
        {
            bool menuLoop = true;
            do
            {
                Console.WriteLine(" ");
                Console.WriteLine("--------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Choose to Add/View/Delete words for the game");
                Console.WriteLine(" ");
                Console.WriteLine("1. Add word(s)");
                Console.WriteLine(" ");
                Console.WriteLine("2. Delete word(s)");
                Console.WriteLine(" ");
                Console.WriteLine("3. View Current Word List");
                Console.WriteLine(" ");
                Console.WriteLine("4. Return to main menu");
                Console.WriteLine(" ");
                Console.WriteLine("--------------------------------");
                Console.WriteLine(" ");

                string adminInput = Console.ReadLine();
                int adminChoice = Convert.ToInt32(adminInput);
                switch (adminChoice)
                {
                    case 1:
                        AddWords(" ");
                        break;

                    case 2:
                        DeleteWords();
                        break;

                    case 3:
                        ViewWordList();
                        break;

                    case 4:
                        menuLoop = false;
                        break;
                }

            } while (menuLoop);

        }

        public static void GameExit()
        {
            Console.WriteLine("Thank you for playing!");
            Environment.Exit(0);
        }

        public static void RandomWord()
        {

        }

        public static void AddLetter()
        {
            string filePath = "./gameWords.txt";


        }

        public static void AddWords(string word)
        {
            string filePath = "./gameWords.txt";
            string[] wordsArray = new string[] { word };
            File.AppendAllLines(filePath, wordsArray);
        }

        public static void ViewWordList()
        {
            string filePath = "./gameWords.txt";
            string[] wordList = File.ReadAllLines(filePath);
            Console.WriteLine(wordList);
            return;
        }

        public static void DeleteWords()
        {
            string filePath = "./gameWords.txt";

            File.Delete(filePath);
        }


    }
}

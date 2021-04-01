using System;
using System.Collections.Generic;

namespace LabDataStructures
{
    class Program
    {
        public static string ReverseString(string input)
        {
            string revWord = "";
            Stack<char> words = new Stack<char>();

            foreach (char item in input)
            {
                words.Push(item);
            }
            foreach (char item in input)
            {
                revWord += words.Pop();
            }
            return revWord;
        }
        static void Main(string[] args)
        {
            //Request & take user input
            //Create a separate method for reversing your string
            //Inside string reverse method, reverse the inputted string using a Stack
            //Display the reversed string in the console
            Console.Write("Please enter a word that you would like to reverse: ");       //Ask user for input
            string input = Console.ReadLine();
            Console.Write($"Your word in reverse is: " + ReverseString(input) + "\n");
            Console.WriteLine();
        }
    }
}

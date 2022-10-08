using System;

namespace Arrays_and_Lists___Exercise_2
{
    internal class Program
    {
        //2- Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name...");
            string userInput = Console.ReadLine();
            char[] userInputCharacters = userInput.ToCharArray();
            string result = string.Empty;
            for (int indexOfArray = userInputCharacters.Length - 1; indexOfArray >= 0; indexOfArray--)
            {
                result += userInputCharacters[indexOfArray];
            }
            Console.WriteLine(result);
        }
    }
}

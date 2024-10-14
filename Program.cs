namespace searchingAssessment4
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Get the first word from the user
            Console.Write("Enter the word 1: ");
            string word1 = Console.ReadLine();

            // Get the character to search
            Console.Write("Enter the character to search: ");
            char searchChar = Console.ReadLine()[0]; // Read the first character

            // Get the second word from the user
            Console.Write("Enter the word 2: ");
            string word2 = Console.ReadLine();

            // Replace the first occurrence of the search character in word1 with the second word
            string result = word1.Replace(searchChar.ToString(), word2, StringComparison.OrdinalIgnoreCase);

            // Display the result
            Console.WriteLine(result);
        }
    }
}

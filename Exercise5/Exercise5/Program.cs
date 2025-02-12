using System;
using System.IO;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Write a program that reads a text file and displays the number of words.

            var path = @"E:\Portfolio\C#\C#_Fundamentals\Exercise5\FileToRead.txt";
            var text = File.ReadAllText(path);
            var words = text.Split(' ');

            Console.WriteLine("There are " + words.Length + " in this file.");

            //2 - Write a program that reads a text file and displays the longest word in the file.
            var isLong = words[0];

            foreach (var word in words)
            {
                if (words[0].Length < word.Length)
                {
                    isLong = word;
                }
            }

            Console.WriteLine(isLong);
        }
    }
}

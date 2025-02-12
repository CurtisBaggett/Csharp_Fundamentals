using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Write a program that reads a text file and displays the number of words.

            var path = @"E:\Portfolio\C#\C#_Fundamentals\Conditionals\Files\ReadThis.txt";
            var text = File.ReadAllText(path).Split(" ");
            var count = 0;

            foreach(var word in text)
            {
                count++;
            }
            Console.WriteLine("there are {0} words.", count);

            //2 - Write a program that reads a text file and displays the longest word in the file.

            var isBiggest = "";

            foreach(var word in text)
            {
                if(word.Length > isBiggest.Length)
                {
                    isBiggest = word;
                }
            }

            Console.WriteLine("'{0}' is the longest word.", isBiggest);
        }
    }
}

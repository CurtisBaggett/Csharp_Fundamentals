using System;
using System.Collections.Generic;

namespace Text
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Write a program and ask the user to enter a few numbers separated by a hyphen.Work out if the numbers are consecutive.For example,
            //if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

            //Console.Write("Enter a series of numbers, separated by a hyphen: ");
            //var input = Console.ReadLine().Split('-');
            //var nums = new List<int>();

            //foreach(string num in input)
            //{
            //    nums.Add(Convert.ToInt32(num));
            //}

            //for(var i = 0; i < nums.Count - 1; i++)
            //{
            //    if(nums[i] + 1 != nums[i + 1])
            //    {
            //        if(nums[i] - 1 == nums[i + 1])
            //        {
            //            continue;
            //        }
            //        Console.WriteLine("Not Consecutive");
            //        return;
            //    }
            //    continue;
            //}
            //Console.WriteLine("Consecutive");

            //2 - Write a program and ask the user to enter a few numbers separated by a hyphen.If the user simply presses Enter,
            //without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.

            //Console.Write("Enter a few numbers separated by a hyphen: ");
            //var input = Console.ReadLine().Split('-');
            //var nums = new List<int>();
            //var isDoop = new List<int>();

            //foreach(string num in input)
            //{
            //    nums.Add(Convert.ToInt32(num));
            //}

            //foreach(int num in nums)
            //{
            //    if (isDoop.Contains(num))
            //    {
            //        Console.WriteLine("Duplicate");
            //        return;
            //    }
            //    isDoop.Add(num);
            //    continue;
            //}
            //Console.WriteLine("No duplicates");

            //3 - Write a program and ask the user to enter a time value in the 24 - hour time format(e.g. 19:00). A valid time should be
            //between 00:00 and 23:59.If the time is valid, display "Ok"; otherwise, display "Invalid Time".If the user doesn't provide any values,
            //consider it as invalid time.

            //Console.Write("Enter a time value in 24 hour time formate (e.g. 19:00): ");
            //var input = Console.ReadLine();

            //try
            //{
            //    var time = DateTime.Parse(input);
            //    Console.WriteLine("Valid Time");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Invalid Time");
            //}

            //4 - Write a program and ask the user to enter a few words separated by a space.Use the words to create a variable name with PascalCase.
            //For example, if the user types: "number of students", display "NumberOfStudents".Make sure that the program is not dependent on the input.
            //So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

            //Console.Write("Enter a few words: ");
            //var input = Console.ReadLine();
            //var pascalWord = "";

            //foreach(var word in input.Split(' '))
            //{
            //    var toUpperCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
            //    pascalWord += toUpperCase;
            //}

            //Console.WriteLine(pascalWord);

            //5 - Write a program and ask the user to enter an English word.Count the number of vowels(a, e, o, u, i) in the word. So,
            //if the user enters "inadequate", the program should display 6 on the console.

            Console.Write("Enter a word: ");
            var input = Console.ReadLine();
            var count = 0;

            foreach(var letter in input.ToLower())
            {
                switch (letter)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        count++;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(count);

        }
    }
}

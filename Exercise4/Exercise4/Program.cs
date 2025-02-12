using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Write a program and ask the user to enter a few numbers separated by a hyphen.
            //    Work out if the numbers are consecutive.For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
            //    display a message: "Consecutive"; otherwise, display "Not Consecutive".

            //Console.Write("Enter a few numbers separated by a hyphen: ");
            //var numsEntered = Console.ReadLine();
            //var numsArr = numsEntered.Split("-");
            //var firstNum = Convert.ToInt32(numsArr[0]);
            //var isConsec = true;

            //for (var i = 0; i < numsArr.Length; i++)
            //{
            //    if (Convert.ToInt32(numsArr[i]) - i != firstNum)
            //    {
            //        isConsec = false;
            //        break;
            //    }
            //}

            //if (isConsec)
            //{
            //    Console.WriteLine("Consecutive");
            //}
            //else
            //{
            //    Console.WriteLine("Not Consecutive");
            //}

            //2 - Write a program and ask the user to enter a few numbers separated by a hyphen.
            //    If the user simply presses Enter, without supplying an input, exit immediately; 
            //    otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.

            //Console.Write("Enter a few numbers separated by a hyphen: ");
            //var input = Console.ReadLine();

            //if (!String.IsNullOrWhiteSpace(input))
            //{
            //    var numArr = input.Split("-");
            //    var doops = new List<string>();
            //    var isDoop = false;

            //    foreach (var num in numArr)
            //    {
            //        if(doops.Contains(num))
            //        {
            //            isDoop = true;
            //            break;
            //        }

            //        doops.Add(num);


            //    }

            //    if (isDoop)
            //    {
            //        Console.WriteLine("Duplicate");
            //    }

            //3 - Write a program and ask the user to enter a time value in the 24 - hour time format(e.g. 19:00). 
            //    A valid time should be between 00:00 and 23:59.If the time is valid, display "Ok"; otherwise, 
            //    display "Invalid Time".If the user doesn't provide any values, consider it as invalid time.

            //Console.Write("Enter a time in the 24 - hour time format(e.g. 19:00): ");
            //var input = Console.ReadLine();
            //var isTime = new TimeSpan();

            //Console.WriteLine(TimeSpan.TryParse(input, out isTime) ? "Valid Time" : "Invalid Time");


            //4 - Write a program and ask the user to enter a few words separated by a space.Use the words to create a variable name 
            //    with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents".Make sure that 
            //    the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

            //Console.Write("Enter a few words separated by a space: ");
            //var input = Console.ReadLine();
            //var wordsArr = input.Split(" ");
            //var toLower = new List<string>();
            //var pascalCase = new List<string>();
            //var newString = new List<string>();
            //var varName = "";


            //foreach (var word in wordsArr)
            //{
            //    toLower.Add(word.ToLower());
            //    pascalCase.Add(word[0].ToString().ToUpper());

            //}

            //for (var i = 0; i < toLower.Count; i++)
            //{
            //    newString.Add(toLower[i].ToString().Replace(toLower[i][0], Convert.ToChar(pascalCase[i])));
            //}

            //for (var i = 0; i < newString.Count; i++)
            //{
            //    varName += newString[i];
            //}

            //Console.WriteLine(varName);

            //5 - Write a program and ask the user to enter an English word.Count the number of 
            //    vowels(a, e, o, u, i) in the word. So, if the user enters "inadequate", the program 
            //    should display 6 on the console.

            //Console.Write(("Enter any word: "));
            //var input = Console.ReadLine();
            //var inStr = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            //var freq = 0;

            //foreach (var letter in input)
            //{
            //    if (inStr.Contains(letter))
            //    {
            //        freq++;
            //    }
            //}

            //Console.WriteLine("The number of vowels in that word are: " + freq);
        }
        }
}

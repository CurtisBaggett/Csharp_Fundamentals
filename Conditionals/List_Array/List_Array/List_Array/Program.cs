using System;
using System.Collections.Generic;

namespace List_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

            //If no one likes your post, it doesn't display anything.
            //If only one person likes your post, it displays: [Friend's Name] likes your post.
            //If two people like your post, it displays:[Friend 1] and[Friend 2] like your post.
            //If more than two people like your post, it displays:[Friend 1], [Friend 2] and[Number of Other People] others like your post.
            //Write a program and continuously ask the user to enter different names, until the user presses Enter(without supplying a name).
            //Depending on the number of names provided, display a message based on the above pattern.

            //var names = new List<string>();

            //while (true)
            //{
            //    Console.Write("Please enter some names: ");
            //    string input = Console.ReadLine();

            //    if (!String.IsNullOrWhiteSpace(input))
            //    {
            //        names.Add(input);
            //        continue;
            //    }

            //    break;

            //}

            //if (names.Count == 1)
            //{               
            //    Console.WriteLine(names[0] + " likes your post.");

            //}
            //else if(names.Count == 2)
            //{
            //    Console.WriteLine("{0} and {1} likes your post.", names[0], names[1]);
            //}
            //else if(names.Count > 2)
            //{
            //    Console.WriteLine("{0} and {1} and a number of people likes your post.", names[0], names[1]);
            //}



            //2 - Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string.
            //Display the reversed name on the console.

            //Console.Write("Please write your name: ");
            //string input = Console.ReadLine();
            //var invert = new List<char>();

            //foreach(char letter in input)
            //{
            //    invert.Add(letter);
            //}

            //invert.Reverse();

            //foreach(char letter in invert)
            //{
            //    Console.Write(letter);
            //}



            //3 - Write a program and ask the user to enter 5 numbers.If a number has been previously entered, display an error message
            //and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

            //var nums = new List<int>();

            //while (nums.Count < 5)
            //{
            //    Console.Write("Please enter 5 numbers: ");
            //    string input = Console.ReadLine();
            //    int numsEntered = Convert.ToInt32(input);

            //    if (nums.Contains(numsEntered))
            //    {
            //        Console.WriteLine("Please enter a unique number.");
            //        continue;
            //    }

            //    nums.Add(numsEntered);

            //}

            //nums.Sort();
            //foreach(int num in nums)
            //{
            //    Console.WriteLine(num);
            //}




            //4 - Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates.
            //Display the unique numbers that the user has entered.

            //var nums = new List<int>();
            //var uniqueNums = new List<int>();

            //while (true)
            //{
            //    Console.Write("Please enter some numbers, and type 'Quit' to exit: ");
            //    string input = Console.ReadLine();

            //    if(input.ToLower() == "quit")
            //    {
            //        break;
            //    }

            //    int numsInput = Convert.ToInt32(input);
            //    nums.Add(numsInput);

            //}

            //foreach(int num in nums)
            //{
            //    if (!uniqueNums.Contains(num))
            //    {
            //        uniqueNums.Add(num);
            //    }
            //}
            //foreach(int num in uniqueNums)
            //{
            //    Console.WriteLine(num);
            //}



            //5 - Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10). If the list is empty or
            //includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.

            while (true)
            {
                Console.Write("Please enter a list of numbers separated by a comma: ");
                string input = Console.ReadLine();
                string[] inputString = input.Split(',');

                if (inputString.Length < 5)
                {
                    Console.WriteLine("Invalid List, please enter at least 5 numbers.");
                    continue;
                }

                var isSmol = new List<int>();

                foreach(string num in inputString)
                {
                    isSmol.Add(Convert.ToInt32(num));                    
                }

                isSmol.Sort();

                for(var i = 0; i < 3; i++)
                {
                    Console.WriteLine(isSmol[i]);
                }
                
            }
            
        }
    }
}

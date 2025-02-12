using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

            //    If no one likes your post, it doesn't display anything.
            //    If only one person likes your post, it displays: [Friend's Name] likes your post.
            //    If two people like your post, it displays:[Friend 1] and[Friend 2] like your post.
            //    If more than two people like your post, it displays:[Friend 1], [Friend 2] and[Number of Other People] others like your post.

            //    Write a program and continuously ask the user to enter different names, until the user presses Enter(without supplying a name). 
            //    Depending on the number of names provided, display a message based on the above pattern.

            var namesList = new List<string>();
            while (true)
            {
                Console.Write("Write a friends name: ");
                var names = Console.ReadLine();
                
                if (!String.IsNullOrWhiteSpace(names))
                {
                    namesList.Add(names);
                    continue;
                }

                if(namesList.Count > 0)
                {
                    switch (namesList.Count)
                    {
                        case 1:
                            Console.WriteLine(namesList[0] + " likes your post.");
                            break;
                        case 2:
                            Console.WriteLine(namesList[0] + " and " + namesList[1] + " likes your post.");
                            break;
                        default:
                            Console.WriteLine(namesList[0] + ", " + namesList[1] + " and " + (namesList.Count - 2) +  " others like your post.");
                            break;

                    }
                }

            }

            //2 - Write a program and ask the user to enter their name. Use an array to reverse 
            //    the name and then store the result in a new string.Display the reversed name on the console.

            //Console.Write("Enter your name: ");
            //var name = Console.ReadLine();
            //char[] toReverse = name.ToCharArray();
            //Array.Reverse(toReverse);

            //Console.WriteLine(toReverse);


            //3 - Write a program and ask the user to enter 5 numbers.If a number has been 
            //    previously entered, display an error message and ask the user to re-try. 
            //    Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

            //var numArr = new List<int>();
            //while (numArr.Count < 5)
            //{
            //    Console.Write("Enter 5 numbers, hit enter after each number: ");
            //    var numEntered = Convert.ToInt32(Console.ReadLine());

            //    if (numArr.Contains(numEntered))
            //    {
            //        Console.WriteLine(numEntered + " has already entered, enter a unique number.");
            //        continue;
            //    }

            //    numArr.Add(numEntered);

            //}

            //numArr.Sort();

            //foreach (var num in numArr)
            //{
            //    Console.WriteLine(num);
            //}

            //4 - Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
            //    The list of numbers may include duplicates.Display the unique numbers that the user has entered.

            //var numbers = new List<int>();

            //while (true)
            //{
            //    Console.Write("Enter as many numbers as you want, followed by enter. Type Quit to quit: ");
            //    var valueEntered = Console.ReadLine();

            //    if (valueEntered.ToLower() == "Quit")
            //    {
            //        break;
            //    }

            //    var numberEntered = Convert.ToInt32(valueEntered);
            //    numbers.Add(numberEntered);

            //}

            //var unique = new List<int>();

            //foreach (var num in numbers)
            //{
            //    if (!(unique.Contains(num)))
            //    {
            //        unique.Add(num);
            //    }
            //}

            //foreach (var num in unique)
            //{
            //    Console.WriteLine(num);
            //}

            //5 - Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10). 
            //    If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
            //    otherwise, display the 3 smallest numbers in the list.

            //var sortList = new List<int>();

            //while (true)
            //{
            //    Console.Write("Enter 5 numbers separated by commas: ");
            //    var numbers = Console.ReadLine();
            //    var nums = numbers.Split(',');

            //    if (!String.IsNullOrWhiteSpace(numbers))
            //    {
            //        if (nums.Length >= 5)
            //        {

            //            foreach (var item in nums)
            //            {
            //                sortList.Add(Convert.ToInt32(item));
            //            }

            //            break;
                        
            //        }

            //        Console.WriteLine("Invalid List");
                    
            //    }
                
            //}
            
            //var isSmall = new List<int>();
            
            //while (isSmall.Count < 3)
            //{
            //    var min = sortList[0];

            //    foreach (var list in sortList)
            //    {
            //        if (list < min)
            //        {
            //            min = list;
            //        }
            //    }

            //    isSmall.Add(min);
            //    sortList.Remove(min);
            //}

            //Console.WriteLine("The 3 smallest numbers are: ");
            //foreach (var num in isSmall)
            //{
            //    Console.WriteLine(num);
            //}

        }
    }
}

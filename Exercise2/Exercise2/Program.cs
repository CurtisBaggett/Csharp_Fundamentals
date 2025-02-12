using System;
using System.Linq;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Write a program to count how many numbers between 1 and 100 are 
            //    divisible by 3 with no remainder.Display the count on the console.

            //int isDiv = 0;

            //for (var i = 0; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        isDiv++;
            //    }
            //}

            //Console.WriteLine(isDiv);

            //2 - Write a program and continuously ask the user to enter a number or "ok" to exit. 
            //    Calculate the sum of all the previously entered numbers and display it on the console.

            //int numEntered = 0;

            //while (true)
            //{
            //    Console.Write("Write a number, or write ok to exit: ");
            //    string input = Console.ReadLine();

            //    if (input.ToLower() == "ok")
            //    {
            //        Console.WriteLine("The sum of all your entered numbers equals: " + numEntered);
            //        break;
            //    }

            //    try
            //    {
            //        numEntered += Convert.ToInt32(input);
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine("That is not a number");
            //    }
                
            //}

            //3 - Write a program and ask the user to enter a number. Compute the factorial of the number 
            //    and print it on the console. For example, if the user enters 5, the program should 
            //    calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

            //int factor = 1;

            //Console.Write("Input a number: ");
            //int num = int.Parse(Console.ReadLine());

            //while (num > 1)
            //{
            //    factor = factor * num;
            //    num = num - 1;
            //}

            //Console.WriteLine(factor);

            //4 - Write a program that picks a random number between 1 and 10.Give the user 4 chances to guess the number.
            //    If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program 
            //    is behaving correctly, you can display the secret number on the console first.)

            //var randomNum = new Random();
            //int secretNum = randomNum.Next(1, 10);
            //int tries = 4;

            ////Console.WriteLine("secret num " + secretNum);

            

            //while (true)
            //{
            //    Console.Write("Guess a number between 1 and 10: ");
            //    int guess = int.Parse(Console.ReadLine());
                
            //    if (guess == secretNum)
            //    {
            //        Console.WriteLine("You won!");
            //        break;
            //    }
            //    else if (tries == 1)
            //    {
            //        Console.WriteLine("You lost, secret number was: " + secretNum);
            //        break;
            //    }
            //    else
            //    {
            //        tries--;
            //        Console.WriteLine("Try again, tries remaining: " + tries);
            //        continue;
            //    }

                
            //}

            //5 - Write a program and ask the user to enter a series of numbers separated by comma.
            //    Find the maximum of the numbers and display it on the console. For example, if the 
            //    user enters “5, 3, 8, 1, 4", the program should display 8.

            Console.Write("Write a list of number separated by commas: ");
            var sortNums = Console.ReadLine();
            var nums = sortNums.Split(',');

            var max = Convert.ToInt32(nums[0]);

            foreach (var str in nums)
            {
                var num = Convert.ToInt32(str);
                if (num > max)
                {
                    max = num;
                }
            }

            Console.WriteLine(max);

        }
    }
}

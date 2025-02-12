using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
            //Display the count on the console.

            //int count = 0;

            //for (var i = 1; i <= 100; i++)
            //{
            //    if(i % 3 == 0)
            //    {
            //        count += 1;
            //    }
            //}

            //Console.WriteLine(count);

            //2 - Write a program and continuously ask the user to enter a number or "ok" to exit.
            //Calculate the sum of all the previously entered numbers and display it on the console.

            //int sum = 0;

            //while (true)
            //{
            //    Console.Write(@"Write a number, or enter 'ok' to exit: ");
            //    string input = Console.ReadLine();

            //    if(input == "ok")
            //    {
            //        break;
            //    }

            //    int newInput = Convert.ToInt32(input);
            //    sum += newInput;
            //}

            //Console.WriteLine(sum);

            //3 - Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example,
            //if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

            //Console.Write(@"Input a number: ");
            //int inputNum = Convert.ToInt32(Console.ReadLine());
            //int fact = inputNum;

            //for (var i = inputNum - 1; i > 0; i--)
            //{
            //   fact *= i;
            //}

            //Console.WriteLine("{0}! = {1}", inputNum, fact);

            //4 - Write a program that picks a random number between 1 and 10.Give the user 4 chances to guess the number.If the user guesses the number,
            //display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly,
            //you can display the secret number on the console first.)

            //Random random = new Random();
            //int secretNum = random.Next(1, 10);
            //int attempts = 3;
            //Console.WriteLine(secretNum);

            //while (true)
            //{
            //    Console.Write("Guess a number between 1 and 10, you have {0} attempts: ", attempts);
            //    int guess = Convert.ToInt32(Console.ReadLine());

            //    if (guess != secretNum)
            //    {
            //        attempts--;

            //        if (attempts == 0)
            //        {
            //            Console.WriteLine("You lost");
            //            break;
            //        }
            //        continue;
            //    }

            //    Console.WriteLine("You win");
            //    break;
            //}

            //5 - Write a program and ask the user to enter a series of numbers separated by comma.
            //Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

            Console.Write("Enter a series of numbers separated by a comma: ");
            string inputNums = Console.ReadLine();
            string[] nums = inputNums.Split(',');
            int isLarge = 0;

            foreach(string num in nums)
            {
                int number = Convert.ToInt32(num);

                if(number > isLarge)
                {
                    isLarge = number;
                }
                
            }
            Console.WriteLine("The largest number is {0}: ", isLarge);
        }
    }
}

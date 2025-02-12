using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Write a program and ask the user to enter a number. The number should be between 1 to 10.If the user enters a valid number, 
            //    display "Valid" on the console.Otherwise, display "Invalid". (This logic is used a lot in applications where values entered 
            //    into input boxes need to be validated.

            //float num = 5;

            //if (num >= 1 && num <= 10)
            //{
            //    Console.WriteLine("Valid");
            //    return;
            //}
            //Console.WriteLine("Invalid");

            //2 - Write a program which takes two numbers from the console and displays the maximum of the two.

            //int num1 = 5;
            //int num2 = 6;

            //if(num1 > num2)
            //{
            //    Console.WriteLine(num1);
            //    return;
            //}
            //Console.WriteLine(num2);


            //3 - Write a program and ask the user to enter the width and height of an image.Then tell if the image is landscape or portrait.

            //int width = 10;
            //int height = 7;

            //if(width > height)
            //{
            //    Console.WriteLine("Landscape");
            //    return;
            //}
            //Console.WriteLine("Portrait");


            //4 - Your job is to write a program for a speed camera. Write a program that asks the user to enter the speed limit.Once set, the program
            //asks for the speed of a car.If the user enters a value less than the speed limit, program should display Ok on the console.
            //If the value is above the speed limit, the program should calculate the number of demerit points.For every 5km / hr above the speed limit,
            //1 demerit points should be incurred and displayed on the console.If the number of demerit points is above 12, the program should display License Suspended.

            float speedLimit = 60;
            float speed = 122;

            if (speed <= speedLimit + 5)
            {
                Console.WriteLine("Ok");
            }else if (speed > speedLimit + 5)
            {
                if((speed - speedLimit) / 5 <= 12)
                {
                    Console.WriteLine("{0} demerits", (speed - speedLimit) / 5);
                    return;
                }
                Console.WriteLine("SUSPENDED!");
                
            }
          

        }
    }
}

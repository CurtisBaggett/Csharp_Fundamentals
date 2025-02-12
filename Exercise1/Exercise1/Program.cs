using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {

            //1 - Write a program and ask the user to enter a number. The number should be between 1 to 10.
            //    If the user enters a valid number, display "Valid" on the console.Otherwise, display "Invalid".
            //    (This logic is used a lot in applications where values entered into input boxes need to be validated.)

            int number = 11;

            if (number > 0 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            //2 - Write a program which takes two numbers from the console and displays the maximum of the two.

            int numA = 10;
            int numB = 6;

            int isBigger = (numA > numB) ? numA : numB;

            Console.WriteLine(isBigger);

            //if (numA > numB)
            //{
            //    Console.WriteLine(numA);
            //}
            //else
            //{
            //    Console.WriteLine(numB);
            //}

            //3 - Write a program and ask the user to enter the width and height of an image.Then tell if the image is landscape or portrait.

            int width = 10;
            int height = 18;

            string image = (width > height)
                ? "Image is landscape"
                : "Image is Portrait";

            Console.WriteLine(image);

            //if (width > height)
            //{
            //    Console.WriteLine("Image is landscape");
            //}
            //else
            //{
            //    Console.WriteLine("Image is Portrait");
            //}

            //4 - Your job is to write a program for a speed camera.For simplicity, ignore the details such as camera, 
            //    sensors, etc and focus purely on the logic.Write a program that asks the user to enter the speed limit.
            //    Once set, the program asks for the speed of a car.If the user enters a value less than the speed limit, 
            //    program should display Ok on the console.If the value is above the speed limit, the program should
            //    calculate the number of demerit points.For every 5km / hr above the speed limit, 1 demerit points should be
            //    incurred and displayed on the console.If the number of demerit points is above 12, the program should display License Suspended.

            int limit = 50;
            int speed = 115;
            const int demeritPoint = 5;
            int fine = (speed - limit) / demeritPoint;

            if (speed <= limit + 5)
            {
                Console.WriteLine("OK");
            }
            else
            {
                if (fine > 12)
                {
                    Console.WriteLine("SUSPENDED!");
                }
                else
                {
                    Console.WriteLine(fine + " Demerits");
                }
            }



        }
    }
}

﻿using System;

namespace MainMethodSubmissionAssignement
{
    class Program
    {
        static void Main()
        {
            //Instanciate the calcaulate class
            Calculate number = new Calculate();
            string numberEntered;

            //Get User Input            
            Console.Write("Enter a number: ");
            numberEntered = Console.ReadLine();

            //Call each method and pass the input. Convert the input to int,decimal and string for each of the methods
            int answer1 = number.addFive(Convert.ToInt32(numberEntered));
            int answer2 = number.addFive(Convert.ToDecimal(numberEntered));
            int answer3 = number.addFive(numberEntered);


            //Display the returned integer to the screen
            Console.WriteLine("Your number plus 5 is: " + answer1);
            Console.WriteLine("Your number times 5: " + answer2);
            Console.WriteLine("The remainer of your number p divied by your number is: " + answer3);

            Console.ReadKey();
        }
    }
}

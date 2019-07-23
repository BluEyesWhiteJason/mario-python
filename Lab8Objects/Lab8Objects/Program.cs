﻿using System;
using System.Collections.Generic;


namespace Lab8Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //create student objects
            Student s1 = new Student("Dakota", "Kent City", "Pho");
            Student s2 = new Student("Joshua", "Grand Rapids", "Cheese Tortellini");
            Student s3 = new Student("Tommy", "Raleigh", "Chicken Curry");
            Student s4 = new Student("James", "Grand Rapids", "Burgers and Fries");
            Student s5 = new Student("Maricela", "Morelia", "Tacos");

            //place into list
            List<Student> students = new List<Student>
            {
                s1,
                s2,
                s3,
                s4,
                s5
            };

            // Get input on which student, catch exceptions
            Console.WriteLine("Welcome to our C# class.");

            do
            {
                Console.WriteLine("Which student would you like to learn more about ? (enter a number 1 - {0}):", students.Count);
                for (int i = 0; i < students.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + students[i].GetName());
                }

                int input = 0;
                while (true)
                {

                    try
                    {
                        input = int.Parse(Console.ReadLine());
                        Console.WriteLine("What about {0} would you like to know?", students[input - 1].GetName());
                        Console.WriteLine("Try 'hometown' for hometown or 'food' for favorite food");
                        break;
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Invalid input, please enter a number");
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        Console.WriteLine("Invalid input, please enter a number from 1-{0}", students.Count);
                    }
                }

                // get what info user wants

                bool validInp = false;

                while (validInp == false)
                {
                    string info = Console.ReadLine();

                    if (info == "hometown")
                    {
                        Console.WriteLine("{0} is from {1}", students[input - 1].GetName(), students[input - 1].GetHometown());
                        validInp = true;
                    }
                    else if (info == "food")
                    {
                        Console.WriteLine("{0}'s favorite food is {1}", students[input - 1].GetName(), students[input - 1].GetFavoriteFood());
                        validInp = true;

                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please enter either 'hometown' or 'food'");
                        validInp = false;
                    }
                }
                //Proceed();
            }
            while (Proceed() == true);
        }

        public static bool Proceed()
        {
            Console.WriteLine("Learn about a different student? y/n : ");
            string contEnter = Console.ReadLine();

            // Check if they want to continue
            if (contEnter == "y" || contEnter == "Y")
            {
                return true;
            }
            else if (contEnter == "n" || contEnter == "N")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input, please enter y or n");
                Proceed();
                return false;
            } 
        }
    }
}

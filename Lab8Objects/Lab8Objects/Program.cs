using System;
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
            List<Student> students = new List<Student>();
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);

            // Get input on which student, catch exceptions
            Console.WriteLine("Welcome to our C# class.");

            do
            {
                Console.WriteLine("Which student would you like to learn more about ? (enter a number 1 - 10):");
                for (int i = 0; i < students.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + students[i].GetName());
                }

                int input = 0;
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Please input a number");
                }

                try
                {
                    Console.WriteLine("Student {0} is {1}. What would you like to know about them?", input, students[input - 1].GetName());
                    Console.WriteLine("Try 'hometown' for hometown or 'food' for favorite food");
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Please enter a number from 1-5");
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
            Console.WriteLine("Continue? y/n : ");
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

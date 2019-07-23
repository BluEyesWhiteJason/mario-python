using System;
namespace Lab8Objects
{
    class Student
    {
        // instance vars/properties
        public string Name;
        public string Hometown;
        public string FavoriteFood;

        //constructor - put data for properties
        public Student(string name, string homeTown, string favoriteFood) //parameters mean those data are necessary
        {
            Name = name;
            Hometown = homeTown;
            FavoriteFood = favoriteFood;

        }

        public string GetName()
        {
            return Name;
        }

        public string GetHometown()
        {
            return Hometown;
        }

        public string GetFavoriteFood()
        {
            return FavoriteFood;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring an array
            //dataType[]nameOfArray = {elements};
            int[] myArray = { 1, 2, 3, 4, 5, 6 };
            string[] students = { "Brad", "Amy", "Jackie", "Ric", "Mike" };
            Console.WriteLine(students[4]);
            Console.WriteLine(students[0]);

            //top 10 vacation spots
            //print out first and last
            string[] vacationSpots = { "Maui", "Bora Bora", "Maldives", "Paris", "Amalfi Coast", "Santorini", "Barcelona", "San Juan", "Napa Valley", "Miami" };
            Console.WriteLine(vacationSpots[0] +" "+ vacationSpots[9]); //need a space to list both on the same line
            Console.WriteLine(vacationSpots[vacationSpots.Length-1]); //will always give you the last element in array

            //ages of 3 children
            //print each child's age
            int[] kidsAges = { 2, 4, 5 };
            Console.WriteLine(kidsAges[0]+" "+kidsAges[1] +" "+ kidsAges[2]);

            //GPA on 4.0 scale of 8 students
            float[] studentsGPA = new float[8]; 
            //know how many elements but don't know what they are
            //dataType[] nameOfArray = new dataType[#ofElements];
            
            //first letter of your peers name who are sitting near you
            char[] peersFirstInitial = { 'G', 'H', 'M' };
            Console.WriteLine(peersFirstInitial); //only works with char arrays

            //declare and initialize an array for the days of the week
            string[] daysOfTheWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            //declare and initialize an array of student ages using the NEW keyword
            int[] studentsAges = new int[5];
            studentsAges[0] = 22;
            studentsAges[1] = 33;
            studentsAges[2] = 43;
            studentsAges[3] = 19;
            studentsAges[4] = 30;

            Console.WriteLine(daysOfTheWeek.Length);
            Console.WriteLine(daysOfTheWeek[0]);
            daysOfTheWeek.SetValue("Funday",0); 
            Console.WriteLine(daysOfTheWeek[0]);

            string[] birthMonths = { "December", "July", "May", "July" };
            Console.WriteLine(Array.IndexOf(birthMonths, "July"));  //returns the first index of your search
            Console.WriteLine(Array.LastIndexOf(birthMonths, "July"));  //returns last instance of an element

            int[] numbers = { 2, 3, 5, 8, 10, -2, 4, 897, 0 };
            Console.WriteLine(numbers[0]);
            Array.Reverse(numbers);     //reverse the order of the array
            Console.WriteLine(numbers[0]);
            Array.Sort(numbers);    //will sort the array elements from smallest to largest -- not available in all prog languages
            Console.WriteLine(numbers[numbers.Length-1]);

            //in-class problems
            //declare and initialize a string array of first names. choose a name to find and print the IndexOf
            //string[] firstNames = { "Holly", "Gabrielle", "Mike", "Jackie" };
            string[] firstNames = new string[5];
            firstNames[0] = "Holly";
            firstNames[1] = "Gabrielle";
            firstNames[2] = "Mike";
            firstNames[3] = "Jackie";
            Console.WriteLine(Array.IndexOf(firstNames, "Mike"));

            //create an array of lucky numbers. each should repeat at least once. 
            //choose a lucky number, find and print the LastIndexOf
            int[] luckyNumbers = { 24, 54, 22, 15, 24, 13, 22, 54, 15, 13 };
            Console.WriteLine(Array.LastIndexOf(luckyNumbers,54));

            //create an array of alphabet characters. print the first index of the array.
            //now reverse the array and print the first index
            char[] alphabetLetters = { 'a', 'j', 'e', 'c', 'u', 'v', 'l', 'k', 'i' };
            Console.WriteLine(alphabetLetters[0]);
            Array.Reverse(alphabetLetters);
            Console.WriteLine(alphabetLetters[0]);

            //create an array of student names in random order. order the names using the sort method.
            //print first and last students' names
            string[] studentNames = { "Holly", "Gabirelle", "Mike", "Jackie", "Jordan", "Colleen" };
            Array.Sort(studentNames);
            Console.WriteLine(studentNames[0]);
            Console.WriteLine(studentNames[studentNames.Length-1]);

            //ask 10 people their favorite numbers and create an array. Order using sort and print first/last numbers.
            int[] favoriteNumbers = { 12, 13, 24, 54, 15, 100, 44, 42, 88, 83 };
            Array.Sort(favoriteNumbers);
            Console.WriteLine(favoriteNumbers[0]); ;
            Console.WriteLine(favoriteNumbers[favoriteNumbers.Length-1]);
        }
    }
}

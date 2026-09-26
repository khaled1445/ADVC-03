using Microsoft.VisualBasic;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ADVC_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            // Create a program that manages student grades using One Of Collections

            // 1.Create a Collection with these grades: 85, 92, 78, 95, 88, 70, 100, 65
            //List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };
            //// 2.Print the collection, Count, first and last grade
            //Console.WriteLine("Grades: " + string.Join(", ", grades));
            //Console.WriteLine("Count: " + grades.Count);
            //Console.WriteLine("First grade: " + grades[0]);
            //Console.WriteLine("Last grade: " + grades[grades.Count - 1]);
            //// 3.Sort the grades ascending, then print
            //grades.Sort();
            //Console.WriteLine($"Grades (ascending): {string.Join(", ", grades)}");
            //// 4.Get the first grade above 90
            //Console.WriteLine($"The First grade above 90 is: {grades.Find(n => n > 90)} ");
            //// 5.Get all grades below 75(failing grades)
            //Console.WriteLine($"Failing grades: {string.Join(", ", grades.FindAll(n => n < 75))}");
            //// 6.Remove all failing grades(below 75)
            //grades.RemoveAll(n => n < 75);
            //// 7.Check if any grade equals 100
            //Console.WriteLine($"Contains grade 100: {grades.Contains(100)}");
            //// 8.Create a List<string> where each grade becomes "Grade: X"
            //List<string> gradeStrings = new List<string>();
            //foreach (int grade in grades) 
            //{
            //    gradeStrings.Add($"Grade: {grade}");
            //}
            //Console.WriteLine($"New List: [{string.Join(", ", gradeStrings)}]");
            #endregion

            #region Exercise 2: Leaderboard
            ////Create a leaderboard that automatically sorts players by score.
            ////1.Add: 500 = "Ahmed", 200 = "Sara", 800 = "Ali", 350 = "Mona"
            //SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>()
            //{
            //    [500] = "Ahmed",
            //    [200] = "Sara",
            //    [800] = "Ali",
            //    [350] = "Mona"
            //};
            ////2.Print all entries(they should be sorted by score automatically)
            //foreach (KeyValuePair<int, string> entry in leaderboard) 
            //{
            //    Console.WriteLine($"Score: {entry.Key}, Player: {entry.Value}");
            //}
            ////3.Access the first key and first value
            //Console.WriteLine($"First score: {leaderboard.Keys.First()}, First player: {leaderboard.Values.First()}");
            ////4.Check if score 500 exists
            //Console.WriteLine($"Contains score 500: {leaderboard.ContainsKey(500)}");
            ////5.Safely get the player with score 999
            //Console.WriteLine("Player with score 999: " + (leaderboard.TryGetValue(999, out string player999) ? player999 : "Not found"));
            ////6.Remove the player with score 200 and print the updated list
            //leaderboard.Remove(200);
            //Console.WriteLine("Updated leaderboard:");
            //foreach (KeyValuePair<int, string> entry in leaderboard)
            //{
            //    Console.WriteLine($"Score: {entry.Key}, Player: {entry.Value}");
            //}
            #endregion

            #region Exercise 3: Phone Book
            //Build a phone book application.
            //1.Create a Collection with 4 contacts(name → phone number)
            Dictionary<string, string> phoneBook = new Dictionary<string, string>()
            {
                { "khaled", "123-456-7890" },
                { "ahmed", "098-765-4321" },
                { "sayed", "555-555-5555" },
                { "ali", "111-111-1111" }
            };
            //2.Add a new contact using [] syntax (add or update)
            //3.Try adding a duplicate using .Add() — catch the exception and print the error
            //4.Try adding a duplicate using .TryAdd() — print whether it succeeded
            //5.Search for a contact that doesn’t exist
            //6.Get a contact with a fallback of "Not Found"
            //7.Print all Keys on one line, then all Values on another line

            #endregion
        }
    }
}

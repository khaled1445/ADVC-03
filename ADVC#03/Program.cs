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
            List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };
            // 2.Print the collection, Count, first and last grade
            Console.WriteLine("Grades: " + string.Join(", ", grades));
            Console.WriteLine("Count: " + grades.Count);
            Console.WriteLine("First grade: " + grades[0]);
            Console.WriteLine("Last grade: " + grades[grades.Count - 1]);
            // 3.Sort the grades ascending, then print
            grades.Sort();
            Console.WriteLine($"Grades (ascending): {string.Join(", ", grades)}");
            // 4.Get the first grade above 90
            Console.WriteLine($"The First grade above 90 is: {grades.Find(n => n > 90)} ");
            

            #endregion
        }
    }
}

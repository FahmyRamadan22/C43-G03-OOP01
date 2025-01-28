namespace Oop_Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1.	Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            //foreach (var item in Enum.GetNames(typeof(WeekDays)))
            //Console.WriteLine(item);
            #endregion
            #region 2.	Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //Person[] persons = [
            //              new("Ahmed" , 16),
            //                new("Mohamed" , 20),
            //                new("Fahmy" , 22)];

            //foreach (Person person in persons)
            //    Console.WriteLine(person.ToString());
            #endregion
            #region 3.	Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //Season season;

            //do
            //{
            //    Console.Write("Enter the name of the season [Spring, Summer, Autumn, Winter: ");
            //} while (!Enum.TryParse(Console.ReadLine(), out season));

            //switch (season)
            //{
            //    case Season.Spring:
            //        Console.WriteLine("March to may");
            //        break;
            //    case Season.Summer:
            //        Console.WriteLine("June to August");
            //        break;
            //    case Season.Autumn:
            //        Console.WriteLine("September to November");
            //        break;
            //    case Season.Winter:
            //        Console.WriteLine("December to February");
            //        break;
            //    default:
            //        break;
            //}
            #endregion
            #region 4.	Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            //string color = Console.ReadLine() ?? "No color";

            //if (Enum.TryParse(color, true, out Colors c))
            //    Console.WriteLine($"{color} is primary color");
            //else
            //    Console.WriteLine($"{color} is not primary color");


            #endregion
            #region 5.	Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Point p1, p2;
            //double x, y;

            //Console.WriteLine("Enter the coordinates for the first point");

            //do
            //{
            //    Console.Write("Enter the X coordinate: ");
            //} while (!double.TryParse(Console.ReadLine(), out x));



            //do
            //{
            //    Console.Write("Enter the Y coordinate: ");
            //} while (!double.TryParse(Console.ReadLine(), out y));

            //p1 = new(x, y);


            //Console.WriteLine("Enter the coordinates for the second point");

            //do
            //{
            //    Console.Write("Enter the X coordinate: ");
            //} while (!double.TryParse(Console.ReadLine(), out x));



            //do
            //{
            //    Console.Write("Enter the Y coordinate: ");
            //} while (!double.TryParse(Console.ReadLine(), out y));

            //p2 = new(x, y);

            //Console.WriteLine($"Distance is: {p1.GetDistanceBetween(p2)}");



            #endregion
            #region 6.	Create a struct called "Person" with properties "Name" and "Age". Write a C# prog


            #endregion
            #region 7.	ram that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            Person[] persons = [
                          new("Ahmed" , 16),
                          new("Mohamed" , 20),
                          new("Fahmy" , 22)];

            int age = 0;

            for (int j = 0; j < persons.Length; j++)
            {
                if (persons[j].Age > age)
                {
                    age = persons[j].Age;
                }

            }

            for (int j = 0; j < persons.Length; j++)
            {
                if (persons[j].Age == age)
                {
                    Console.WriteLine(persons[j]);
                    break;
                }
            }



            #endregion
        }
    }
}

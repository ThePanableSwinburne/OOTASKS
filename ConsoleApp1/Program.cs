using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3];
            people[0] = new Person("Dhanveer", "Ramnauth", "16th of June, 2003", 185);
            people[1] = new Person("Anh", "Nguyen", "12th of May, 1965", 100);
            people[2] = new Person("James", "Hallinan", "1th of April, 1600 (OLD)", 200);

            foreach (var human in people)
            {
                Console.WriteLine(human.GetFullName());
                foreach (var human2 in people)
                {
                    if (human2 == human) continue;
                    Console.WriteLine($"Height difference between {human.GetFullName()} and {human2.GetFullName()} is {human.GetHeightDifference(human2)}cm");
                }
            }
            
        }
    }
}

using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Person
    {
        private string firstName;
        private string surname;
        private string dob;
        private int height;
        private int id;
        private List<Subject> subjects = new List<Subject>();

        public Person(string firstName, string surname, string dob, int height)
        {
            this.firstName = firstName;
            this.surname = surname;
            this.dob = dob;
            this.height = height;
            id = new Random().Next(1000, 10000);
        }

        public void AddSubject(Subject subject)
        {
            subjects.Add(subject);
        }

        public void PrintSubjects()
        {
            foreach (Subject subject in subjects)
            {
                Console.WriteLine(subject);
            }
        }

        public string GetFullName()
        {
            return firstName + " " + surname;
        }

        public int GetHeightDifference(Person other)
        {
            return Math.Abs(other.height - height);
        }

        public string FirstName
        {
            get => firstName;
            set => firstName = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Surname
        {
            get => surname;
            set => surname = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Dob
        {
            get => dob;
            set => dob = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int Height
        {
            get => height;
            set => height = value;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }
    }
}
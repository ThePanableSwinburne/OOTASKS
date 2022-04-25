using System;

namespace ConsoleApp1
{
    class Subject
    {
        private string name;
        private string yearOfDelivery;
        private int grade;

        public Subject(string name, string yearOfDelivery, int grade = 0)
        {
            this.name = name;
            this.yearOfDelivery = yearOfDelivery;
            this.grade = grade;
        }

        public string Name
        {
            get => name;
            set => name = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string YearOfDelivery
        {
            get => yearOfDelivery;
            set => yearOfDelivery = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int Grade
        {
            get => grade;
            set => grade = value;
        }
    }
}
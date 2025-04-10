using System;

namespace MyCSharpApp.updated
{
    class StudentOOP_update
    {
        public static void Run()
        {
            try
            {
                Console.WriteLine("Student Details:");
                Student student1 = new Student("John Doe", 101, 85);
                student1.DisplayDetails();

                Console.WriteLine("\nIITGN Student Details:");
                StudentIITGN student2 = new StudentIITGN("Nidhi", 102, 92, "Hostel I");
                student2.DisplayDetails();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public double Marks { get; set; }

        public Student(string name, int id, double marks)
        {
            try
            {
                if (id <= 0)
                    throw new ArgumentException("ID must be a positive integer.");
                if (marks < 0 || marks > 100)
                    throw new ArgumentOutOfRangeException(nameof(marks), "Marks must be between 0 and 100.");

                Name = name;
                ID = id;
                Marks = marks;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Name = "Unknown"; // Assign default name
                ID = 0;
                Marks = 0;
            }
        }

        public string GetGrade()
        {
            if (Marks >= 90) return "A";
            if (Marks >= 80) return "B";
            if (Marks >= 70) return "C";
            if (Marks >= 60) return "D";
            return "F";
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Marks: {Marks}");
            Console.WriteLine($"Grade: {GetGrade()}");
        }
    }

    class StudentIITGN : Student
    {
        public string Hostel_Name_IITGN { get; set; }

        public StudentIITGN(string name, int id, double marks, string hostel)
            : base(name, id, marks)
        {
            if (string.IsNullOrWhiteSpace(hostel))
            {
                Console.WriteLine("Error: Hostel name cannot be empty.");
                Hostel_Name_IITGN = "Unknown"; // Assign a default value
            }
            else
            {
                Hostel_Name_IITGN = hostel;
            }
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Hostel: {Hostel_Name_IITGN}");
        }
    }
}

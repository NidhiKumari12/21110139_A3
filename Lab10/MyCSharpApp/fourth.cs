using System;

namespace MyCSharpApp
{
    class Task3_StudentOOP
    {
        public static void Run()
        {
            Console.WriteLine("Student Details:");
            Student student1 = new Student("John Doe", 101, 85);
            student1.DisplayDetails();

            Console.WriteLine("\nIITGN Student Details:");
            StudentIITGN student2 = new StudentIITGN("Nidhi", 102, 92, "Hostel I");
            student2.DisplayDetails();
        }
    }
    class Student
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public double Marks { get; set; }
        public Student(string name, int id, double marks)
        {
            Name = name;
            ID = id;
            Marks = marks;
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
            Hostel_Name_IITGN = hostel;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Hostel: {Hostel_Name_IITGN}");
        }
    }
}

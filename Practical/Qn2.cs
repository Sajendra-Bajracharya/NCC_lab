using System;
    class Student
    {
        private string name;
        private string studentId;
        private double gpa;

        public Student(string name, string studentId, double gpa)
        {
            this.name = name;
            this.studentId = studentId;
            this.gpa = gpa;
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
            }
        }
        public string StudentId
        {
            get { return studentId; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    studentId = value;
            }
        }
        public double GPA
        {
            get { return gpa; }
            set
            {
                if (value >= 0.0 && value <= 4.0)
                    gpa = value;
            }
        }
    public void DisplayInfo()
    {
        Console.WriteLine("\n========== Student Information ==========");
        Console.WriteLine($"Name:       {Name}");
        Console.WriteLine($"Student ID: {StudentId}");
        Console.WriteLine($"GPA:        {GPA:F2}");
        Console.WriteLine("=========================================\n");
    }
        public string GetGrade()
        {
            if (gpa >= 3.7) return "A";
            else if (gpa >= 3.0) return "B";
            else if (gpa >= 2.0) return "C";
            else return "Below C";
        }
    }


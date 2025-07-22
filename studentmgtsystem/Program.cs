using System;

class Student
{
    // Define properties
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }

    // Define constructor
    public Student(string name, int age, string grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter student details
        Console.WriteLine("Enter student's name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter student's age:");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter student's grade:");
        string grade = Console.ReadLine();

        // Create an instance of the Student class
        Student s = new Student(name, age, grade);

        // Print student details
        Console.WriteLine("The Name of the Student is: " + s.Name);
        Console.WriteLine("The Age of the Student is: " + s.Age);
        Console.WriteLine("The Grade of the Student is: " + s.Grade);
    }
}

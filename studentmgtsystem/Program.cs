using System;

class Student
{
    // Define properties
    // Complete Step 1:............
    public string Name;
    public int Age;
    public string Grade;

    // Define constructor
    // Complete Step 2:............
    public Student(){
        Console.WriteLine("The Name of the Student is:"+ Name);
        Console.WriteLine("The Age of the Student is:"+ Age);
        Console.WriteLine("The Grade of the Student is:"+ Grade);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter student details
        Console.WriteLine("Enter student's name:");
        // Complete Step 3:............
        string Name = Console.ReadLine();

        Console.WriteLine("Enter student's age:");
        // Complete Step 4:............
        int Age = Console.ReadLine();

        Console.WriteLine("Enter student's grade:");
        // Complete Step 5:............
        string Grade = Console.ReadLine();

        // Create an instance of the Student class
        // Complete Step 6:............
        Student s = new Student(name,age,grade);

        // Print student details
        // Complete Step 7:............
    }
}
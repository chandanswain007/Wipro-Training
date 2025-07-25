// // Create a collection of students to store student id ,student name and  subjectmarks(key as a subject and value as a marks)
// // then display each student detail with average score

// using System;
// using System.Collections.Generic;
// public class Program2
// {
//     public static void Main()
//     {
//         Dictionary<int, Dictionary<string, int>> students = new Dictionary<int, Dictionary<string, int>>();

//         // Adding student details
//         students.Add(101, new Dictionary<string, int> { { "Name", 90 }, { "Math", 85 }, { "Science", 88 } });
//         students.Add(102, new Dictionary<string, int> { { "Name", 92 }, { "Math", 78 }, { "Science", 80 } });

//         // Displaying each student's details with average score
//         foreach (var student in students)
//         {
//             int id = student.Key;
//             var details = student.Value;
//             string name = details["Name"].ToString();
//             int mathScore = details["Math"];
//             int scienceScore = details["Science"];
//             double averageScore = (mathScore + scienceScore) / 2.0;

//             Console.WriteLine($"Student ID: {id}, Name: {name}, Math: {mathScore}, Science: {scienceScore}, Average Score: {averageScore}");
//         }
//     }
// }
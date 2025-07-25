// using System;
// using System.Collections.Generic;

// // Step 1 & 2: Book class
// class Book
// {
//     public string Title { get; set; }
//     public string Author { get; set; }
//     public string ISBN { get; set; }

//     public Book(string title, string author, string isbn)
//     {
//         Title = title;
//         Author = author;
//         ISBN = isbn;
//     }
// }

// // Step 3 - 6: Library class
// class Library
// {
//     List<Book> books = new List<Book>();  // store Book objects

//     public void AddBook()
//     {
//         Console.WriteLine("Enter book title:");
//         string title = Console.ReadLine();

//         Console.WriteLine("Enter book author:");
//         string author = Console.ReadLine();

//         Console.WriteLine("Enter book ISBN:");
//         string isbn = Console.ReadLine();

//         books.Add(new Book(title, author, isbn));
//         Console.WriteLine("Book added successfully.");
//     }

//     public void RemoveBook()
//     {
//         Console.WriteLine("Enter book ISBN:");
//         string isbn = Console.ReadLine();

//         Book bookToRemove = books.Find(b => b.ISBN == isbn);
//         if (bookToRemove != null)
//         {
//             books.Remove(bookToRemove);
//             Console.WriteLine("Book removed successfully.");
//         }
//         else
//         {
//             Console.WriteLine("Book not found.");
//         }
//     }

//     public void ListBooks()
//     {
//         Console.WriteLine("Listing all books:");
//         foreach (var book in books)
//         {
//             Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}");
//         }

//         if (books.Count == 0)
//         {
//             Console.WriteLine("No books in the library.");
//         }
//     }
// }

// // Step 7-9: Main program
// class Program
// {
//     static void Main(string[] args)
//     {
//         Library library = new Library();
//         bool exit = false;

//         while (!exit)
//         {
//             Console.WriteLine("Choose an option:");
//             Console.WriteLine("1. Add Book");
//             Console.WriteLine("2. Remove Book");
//             Console.WriteLine("3. List Books");
//             Console.WriteLine("4. Exit");

//             int choice = Convert.ToInt32(Console.ReadLine());

//             switch (choice)
//             {
//                 case 1:
//                     library.AddBook();
//                     break;
//                 case 2:
//                     library.RemoveBook();
//                     break;
//                 case 3:
//                     library.ListBooks();
//                     break;
//                 case 4:
//                     exit = true;
//                     break;
//                 default:
//                     Console.WriteLine("Invalid choice. Please try again.");
//                     break;
//             }
//         }
//     }
// }
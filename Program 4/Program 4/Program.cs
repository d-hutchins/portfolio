//Grading ID: K6509
//Due Date: 12/1/2021
//Program 4
//CIS 199-01
//This program uses two files, one with the main method to display out to the user.
//The other being a new class named LibraryBook and multiple methods to change the check out
//status, and be able to display all book entries with statistics of title, author, publisher,
//publication year, and ISBN call number.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryBook[] books = new LibraryBook[5]; //creating array to store books objects
            books[0] = new LibraryBook("The Avengers", "Kevin Feige", "Simon & Schuster", -2013, "150"); //book one characteristics
            books[1] = new LibraryBook("Mogul Money", "Ludwig Ahgren", "Penguin Random House", 2021, "250"); //book two characteristics
            books[2] = new LibraryBook("A Programmer's Mind", "George McFly", "Harper Collins", 1987, "350"); //book three characteristics
            books[3] = new LibraryBook("Adventures of a Curious Student", "Danny Phantom", "Macmillian", 2003, "450"); //book four characteristics
            books[4] = new LibraryBook("The Streamer's Tale", "Matthew Rinaudo", "Hachette", 2020, "550"); //book five characteristics
            //initial view of entries
            Console.WriteLine("Original Book Data" ); //title line
            Console.WriteLine("==================" + Environment.NewLine); //symbols to break up text
            DisplayBooks(books); //method to write statements to console

            //Change statuses of entries
            books[0].CheckOut(); //changing book 1 check out status to true
            books[3].CheckOut(); //changing book 4 check out status to true

            //Changing book publisher and ISBN for two entries
            books[0].ISBN = "750"; //changing ISBN call number manually for book 1
            books[1].BookPublisher = "Penguin"; //changing publisher manually for book 2
            books[2].ISBN = "850"; //changing ISBN call number manually for book 3
            books[3].BookPublisher = "Simon & Schuster"; //changing publisher manually for book 4
            books[4].ISBN = "650"; //changing ISBN call number manually for book 5

            //display updated view of entries
            Console.WriteLine("First Changes to Book Data" ); //title line
            Console.WriteLine("==========================" + Environment.NewLine); //symbols to break up text
            DisplayBooks(books); //method to write statements to console

            //check statuses of entries if they are checked out
            Console.WriteLine("Book Title: " + books[0].BookTitle + " " + "Status: " + books[0].IsCheckedOut() + Environment.NewLine); //lines displayed to console for book check out status
            Console.WriteLine("Book Title: " + books[1].BookTitle + " " + "Status: " + books[1].IsCheckedOut() + Environment.NewLine); //lines displayed to console for book check out status

            //changing statuses of books checked out
            books[0].ReturnToShelf(); //book 1 check out changed to false
            books[3].ReturnToShelf(); //book 4 check out changed to false

            //final output of entries
            Console.WriteLine("Final Changes to Book Data" ); //title line
            Console.WriteLine("==========================" + Environment.NewLine); //symbols to break up text
            DisplayBooks(books); //method to write statements to console
        }

        //Method to display the book entries to the user in the console
        static void DisplayBooks(LibraryBook[] books)
        {
            for(int i = 0; i < books.Length; i++) //for loop to cycle through object array
            {
                Console.WriteLine(books[i].ToString()); //writeline statement for each book
            }
        }
    }
}

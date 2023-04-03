//Grading ID: K6509
//Due Date: 12/1/2021
//Program 4
//CIS 199-01
//This is the second file, housing the LibraryBook class and 4 methods:
//CheckOut, ReturnToShelf, IsCheckedOut, and ToString.
using System;
public class LibraryBook //establishing the new class to be used in the main
{
    bool checkedOut; //variable to establish if the book is checked out, returning true or false
    public string BookTitle { get; set; } //get & set book title for entry
    public string BookAuthor { get; set; } //get & set book author for entry
    public string BookPublisher { get; set; } //get & set book publisher for entry

    private int PublicationYear; //private value to be used for checking an entry's publication year
    public int YearOfPublication //public value to be passed back to the main
    {
        get { return PublicationYear; } //get year from book entry
        set //setting the value, validation
        {
            if(value < 0) //checking if entry is valid (non-negative)
            {
                PublicationYear = 2019; //setting default value if entry is found invalid
            } 
            else //if entry is valid, it is passed back to the main
            {
                PublicationYear = value; //passing value to the main
            }
        }
    }
    public string ISBN { get; set; } //get & set ISBN call number for entry
    
    //creating the constructor for the book entries, including necessary variables
    public LibraryBook(string title, string author, string publisher, int yearPublication, string callISBN)
    {
        this.BookTitle = title; //setting the title to the variable
        this.BookAuthor = author; //setting the author to the variable
        this.BookPublisher = publisher; //setting the publisher to the variable
        this.YearOfPublication = yearPublication; //setting the year to the variable
        this.ISBN = callISBN; //setting the ISBN to the variable
    }

    //Method to change status of book to checked out (true)
    public void CheckOut()
    {
        checkedOut = true; //variable status changed to indicate it is checked out
    }

    //Method to change status of book to not checked out (false)
    public void ReturnToShelf()
    {
        checkedOut = false; //variable status changed to indicate it is not checked out
    }

    //Method to verify if a book is checked out or not (true/false), returns the status
    public bool IsCheckedOut()
    {
        return checkedOut; //returning the status to the main
    }

    //Method to format the book entry in array into a string displayed to the user
    public override string ToString()
    {
        string stringReturn = "Title: " + BookTitle + Environment.NewLine; //line for book title
        stringReturn += "Author: " + BookAuthor + Environment.NewLine; //line for book author
        stringReturn += "Publisher: " + BookPublisher + Environment.NewLine; //line for book publisher
        stringReturn += "Year: " + YearOfPublication + Environment.NewLine; //line for book publication year
        stringReturn += "ISBN: " + ISBN + Environment.NewLine; //line for ISBN call number
        stringReturn += "Checked Out: " + checkedOut.ToString() + Environment.NewLine; //line for check out status
        return stringReturn; //returning statement to the main
    }
}
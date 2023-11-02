// Grading ID: S5040
// Program 4
// Due December 1st
// CIS 199-50-4218
// This program sets up library books to display information as well as if it has been checked out or not.
using System;
public class LibraryBook // public class library
{
    private String title; // creating a private string for title
    private String author; // creating a private string for author
    private String publisher; // creating a private string for publisher
    private int publication; // creating a private int for publication
    private String BookISBN; // creating a private string for isbn
    private bool checkoutStatus; // creating a private bool to see if checked out or not

    public LibraryBook(String BookTitle, String BookAuthor, String BookPublisher, int YearOfPublication, String ISBN) // creating a public class named library book
    {
        title = BookTitle; // delcaring variables used
        author = BookAuthor; // delcaring variables used
        publisher = BookPublisher; // delcaring variables used
        publication = YearOfPublication; // delcaring variables used
        BookISBN = ISBN; // delcaring variables used
        checkoutStatus = false; // delcaring variables used
    }

    public String BookTitle // public string to return the book title
    {
        get
        {
            return title; // returns the title of the book
        }

        set
        {
            title = value; // sets the title as a value
        }
    }

    public String BookAuthor // public string to returnb the book author
    {
        get
        {
            return author; // returns the author of the book
        }

        set
        {
            author = value; // sets the author as a value
        }
    }

    public String BookPublisher // public string to return the publisher
    {
        get
        {
            return publisher; // returns the publisher of the book
        }

        set
        {
            publisher = value; // sets the publisher as a value
        }
    }

    public int YearOfPublication // public int to return publication year
    {
        get
        {
            return publication; // returns the publication year of the book
        }

        set
        {
            publication = value; // sets the publication year of the book
        }
    }

    public String ISBN // public string to return book ISBN
    {
        get
        {
            return BookISBN; // returns the isbn of the book
        }

        set
        {
            BookISBN = value; // sets the isbn as a value
        }
    }

    public void CheckOut() // static method named checkout that returns no data
    {
        checkoutStatus = !checkoutStatus;
    }

    public void ReturnToShelf() // static method named return to shelf that returns no data
    {
        checkoutStatus = !checkoutStatus;
    }

    public bool IsCheckedOut() // static bool method named ischeckout to return whether or not the book is checked out
    {
        return checkoutStatus;
    }

    public override String ToString() // to string method to setup
    {
        String result = "";

        result += "Title: " + title + Environment.NewLine;
        result += "Author: " + author + Environment.NewLine;
        result += "Publisher: " + publisher + Environment.NewLine;
        result += "Published Year: " + publication + Environment.NewLine;
        result += "ISBN: " + BookISBN + Environment.NewLine;
        result += "Checkouted Out?: " + checkoutStatus + Environment.NewLine;

        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {

        LibraryBook book1 = new LibraryBook("Titanic", "Walter Lord", "Bantam Books", 1955, "0-03-027615-2");
        LibraryBook book2 = new LibraryBook("Behind Enemy Lines", "Marthe Cohn", "Harmony Books", 2002, "0609610546");
        LibraryBook book3 = new LibraryBook("The Boy in the Striped Pyjamas", "	John Boyne", "	David Fickling Books", 2006, "0-385-60940-X");
        LibraryBook book4 = new LibraryBook("The Great Gatsby", "F. Scott Fitzgerald", "Charles Scribner's Sons", 1925, "9780333791035");
        LibraryBook book5 = new LibraryBook("The Lord of the Rings", "J. R. R. Tolkien", "Allen & Unwin", 1968, "9788845292613");

        LibraryBook[] books = { book1, book2, book3, book4, book5 };

        book(books);

        book1.BookPublisher = "Bantam Books";
        book2.CheckOut();
        book3.ISBN = "0-385-60940-X";
        book4.CheckOut();
        book5.BookPublisher = "Allen & Unwin";

        book(books);

        book1.CheckOut();
        book2.CheckOut();
        book3.CheckOut();
        book4.CheckOut();
        book5.CheckOut();
        
        book(books);

        Console.ReadKey();
    }

    public static void book(LibraryBook[] books)
    {
        for (int i = 0; i < books.Length; i++)
        {

            Console.WriteLine("Book Number " + (i + 1));

            Console.WriteLine(books[i]);

        }
    }
}
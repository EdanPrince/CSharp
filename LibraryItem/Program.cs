using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LibraryItem
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublicationYear { get; set; }

    public override string ToString()
    {
        return $"Title: {Title}\nAuthor: {Author}\nPublication Year: {PublicationYear}";
    }
    protected LibraryItem(string Title, string Author, int PublicationYear)
    {
        this.Title = Title;
        this.Author = Author;
        this.PublicationYear = PublicationYear;
    }
}
public class Book : LibraryItem
{
    protected string Category { get; set; }

    public Book(string Title, string Author, int PublicationYear, string category) : base(Title, Author, PublicationYear)
    {
        this.Category = category;
    }

    public override string ToString()
    {
        return "Type: " + GetType().Name + "\n" + base.ToString() + "\nCategory: " + Category;
    }
}

public class Magazine : LibraryItem
{
    protected int AmountMaking { get; set; }

    public Magazine(string Title, string Author, int PublicationYear, int amountMaking) : base(Title, Author, PublicationYear)
    {
        this.AmountMaking = amountMaking;
    }

    public override string ToString()
    {
        return "Type: " + GetType().Name + "\n" + base.ToString() + "\nAmount Making: " + AmountMaking;
    }
}

public class DVD : LibraryItem
{
    protected string Material { get; set; }

    public DVD(string Title, string Author, int PublicationYear, string material) : base(Title, Author, PublicationYear)
    {
        this.Material = material;
    }

    public override string ToString()
    {
        return "Type: " + GetType().Name + "\n" + base.ToString() + "\nMaterial: " + Material;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Book book = new Book("The Catcher in the Rye", "J.D. Salinger", 1951, "Fiction");
        Console.WriteLine(book.ToString());
        Console.WriteLine();

        Magazine magazine = new Magazine("National Geographic", "National Geographic Society", 2023, 12);
        Console.WriteLine(magazine.ToString());
        Console.WriteLine();

        DVD dvd = new DVD("Inception", "Christopher Nolan", 2010, "Blu-ray");
        Console.WriteLine(dvd.ToString());
    }
}

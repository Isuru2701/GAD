using System;

//an inheritance for book to magazine, comic etc etc
namespace InheritancePractice
{
    class Book
    {
        protected string name = "", author = "";
         protected int  isbn = 0;

        public Book(string n, string a, int i)
        {
            name = n;
            author = a;
            isbn = i;
           
        }
        public void DisplayDetails()
        {
            Console.WriteLine(name + " " + author +  " " + isbn);

        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetAuthor(string author)
        {
            this.author = author;
        }

        public void SetISBN(int isbn)
        {
            this.isbn = isbn;
        }


    }

   class Magazine : Book
    {
        private int edition = 0;

        public Magazine(string n, string a, int i, int e) : base(n, a, i)
        {
            edition = e;
        }
        public void setEdition(int ed)
        {
            edition = ed;
        }
    }

    class Program
    {
        static void Main(String[] args)
        {
            Book book = new Book("Song of Ice and Fire", "Gerorge R R Martin", 097235973);
            book.DisplayDetails();
            Console.ReadKey();
        }
    }
}
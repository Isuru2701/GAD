using System;

//an inheritance for book to magazine, comic etc etc
namespace InheritancePractice
{
    class Book
    {
        protected string name = "", author = "", isbn = "";

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

        public void SetISBN(string isbn)
        {
            this.isbn = isbn;
        }


    }

   class Magazine : Book
    {
        private int edition = 0;

        public void setEdition(int ed)
        {
            edition = ed;
        }
    }
}
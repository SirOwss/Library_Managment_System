using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Library_Managment_System
{
    public enum Genre
    {
        Fiction,
        NonFiction,
        Biography,
        ScienceFiction,
        Technology // Add more genres as needed
    }
    internal class Book
    {
        string title;
        string author;
        int isbn;
        string genre;
        int quantity;

        public Book()
        {

        }

        public Book(string t, string a, int b, string gen, int q)
        {
            Title = t;
            author = a;
            isbn = b;
            genre = gen;
            quantity = q;
        }

        public string Title
        {

            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }

        public int ISBN
        {
            get
            {
                return isbn;
            }
            set
            {
                isbn = value;
            }
        }

        

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

    }
}

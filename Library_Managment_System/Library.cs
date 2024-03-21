using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managment_System
{
    internal class Library
    {
        //Dana
        public List<Book> Books = new List<Book>();


        public Book Find_Book(int isbn)
        {
            foreach (Book item in Books)
            {
                if (item.ISBN.Equals(isbn))
                {
                    return item;
                }
            }
            return null;
        }

        public void Add_Book(Book book)
        {
            Books.Add(book);

        }

        public bool Remove_Book(int isbn)
        {
            for (int i = 0; i < Books.Count; i++)
            {
                if (isbn == Books[i].ISBN)
                {
                    Books.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public void Display_Book()
        {
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Quantity > 0)
                {
                    Console.WriteLine(Books[i].Title + " , Author: " + Books[i].Author +", ISBN: " + Books[i].ISBN + ", Quantity: " + Books[i].Quantity);


                }

            }

        }

        public bool Update_Quantity_Book(int isbn, int num)
        {
            for (int i = 0; i < Books.Count; ++i)
            {
                if (Books[i].ISBN == isbn)
                {
                    Books[i].Quantity += num;
                    return true;
                }

            }
            return false;
        }

    }
}

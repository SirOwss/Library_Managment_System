using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managment_System
{
    internal class Transaction
    {
        int transactionId;
        User user;
        Book book;
        string transactionDate = DateTime.Now.ToString();//Dana


        public Transaction(User user)
        {
            this.user = user;
            
        }

        public void setBook(Book book)
        {
            this.book = book;
        }

        public void RecordTransaction(string status)
        {
            Random RandNumber = new Random();
            this.transactionId = RandNumber.Next(1000, 9999);
            Console.WriteLine("tID: "+transactionId.ToString() + "\nName: " + user.name + "\nBook: " + book.Title +"\nState: "+status+ "\ntDate: " + transactionDate);
            Console.WriteLine("---------------------------------");

        }



    }
}

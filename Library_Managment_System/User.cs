using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library_Managment_System
{
    abstract class User : Library
    {
        string Name;
        int MemberShip_Number;



        public User(string Name, int MemberShip_Number)
        {
            this.Name = Name;
            this.MemberShip_Number = MemberShip_Number;
        }

        public abstract string GetInformation();
        
        

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public int getMemberShipNumber()
        {
            return MemberShip_Number;
        }


    }

    class Regular_User : User
    {
        string typeUser = "Customer";
        List<Book> Borrow_Books = new List<Book>();

        public Regular_User(string Name, int MemberShip_Number) : base(Name, MemberShip_Number)
        {
            base.name = Name;
            
        }



        public void Borrowing_Books(Book book)
        {
            if (book.Quantity > 0)
            {
                Borrow_Books.Add(book);
                book.Quantity -= 1;
            }
        }

        public void Returning_Books(Book book)
        {

            Borrow_Books.Remove(book);
            book.Quantity += 1;




        }

        public Book Find_Book(int isbn)
        {
            foreach (Book item in Borrow_Books)
            {
                if (item.ISBN.Equals(isbn))
                {
                    return item;
                }
            }
            return null;
        }

        public override string GetInformation()
        {
            return "Name: " + base.name + "\nMemberShip Number: " + base.getMemberShipNumber() + "\nUser Type: " + typeUser;
        }
    }

    class Admins : User
    {
        string typeUser = "Admin";
        public Admins(string Name, int MemberShip_Number) : base(Name, MemberShip_Number)
        {
            base.name = Name;
        }

        public override string GetInformation()
        {
            return "Name: " + base.name + "\nMemberShip Number: " + base.getMemberShipNumber() + "\nUser Type: " + typeUser;
        }
    }
}

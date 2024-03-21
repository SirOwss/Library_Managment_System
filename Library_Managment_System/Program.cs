using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managment_System
{
    
    internal class Program
    {
        static void Main(string[] args)
        {

            Library library_Management = new Library();
            Console.WriteLine("-----Welcome to Library Management System-----");
            while (true)
            {
                Console.WriteLine("You Are Admin Or Customer? 1.Admin , 2.Customer , 3.Exit");
                int c = int.Parse(Console.ReadLine());
                

                
                    try
                    {

                    if (c == 1)
                    {

                        Console.Write("Enter your Name: ");
                        string name = Console.ReadLine();
                        Random random = new Random();
                        int membership_number = random.Next(10000, 99999);
                        Admins obj = new Admins(name, membership_number);
                        while (true)
                        {

                            Console.WriteLine("This our Services: ");
                            Console.WriteLine("1.Display Admin Information\n2.Display Avaliable books\n3.Adding Book\n4.Update Quantity Of Book\n5.Remove Book\n6.Exit");
                            Console.Write("Please Choose from 1 to 6 : ");
                            int choice = int.Parse(Console.ReadLine());

                            if(choice == 1)
                            {
                                Console.WriteLine(obj.GetInformation() + "\n");
                            
                        }
                            else if (choice == 2)
                            {
                                library_Management.Display_Book();
                            }
                            else if (choice == 3)
                            {
                                Console.Write("Enter Title of book: ");
                                string title = Console.ReadLine();
                                Console.Write("Enter author name: ");
                                string author = Console.ReadLine();
                                Console.Write("Enter ISBN: ");
                                int isbn = int.Parse(Console.ReadLine());
                                Console.Write("Choose The Genre or Write your own: ");
                                foreach (Genre g in Enum.GetValues(typeof(Genre)))
                                {
                                    Console.Write(g+" - ");
                                }
                                Console.WriteLine();
                                string genre = Console.ReadLine();
                             
                                Console.Write("Enter Quantity of Book: ");
                                int quantity = int.Parse(Console.ReadLine());

                                Book book = new Book(title, author, isbn, genre, quantity);
                                library_Management.Add_Book(book);
                                Console.WriteLine("Adding Book is Done :)");
                            }
                            else if (choice == 4)
                            {
                                Console.Write("Enter ISBN: ");
                                int isbn = int.Parse(Console.ReadLine());
                                Console.WriteLine("How many added? ");
                                int q = int.Parse(Console.ReadLine());
                                if (library_Management.Update_Quantity_Book(isbn, q))
                                {
                                    Console.WriteLine("Quantity was Updated!");
                                }
                                else
                                {
                                    Console.WriteLine("ISBN Code is Wrong, Please Try Again!");
                                }
                            }
                            else if (choice == 5)
                            {
                                Console.Write("Enter ISBN: ");
                                int isbn = int.Parse(Console.ReadLine());
                                if (library_Management.Remove_Book(isbn))
                                {
                                    Console.WriteLine("----Book is Removed----");
                                }
                                else
                                {
                                    Console.WriteLine("ISBN Code is Wrong, Please Try Again!");
                                }
                            }
                            else if (choice == 6)
                            {
                                Console.WriteLine("Thank you Admin , See you Later.............");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Your Entry is Worng , Please Try Again..........");
                            }
                        }
                    }
                    else if (c == 2)
                    {
                        Console.Write("Enter your Name: ");
                        string name = Console.ReadLine();
                        Random random = new Random();
                        int membership_number = random.Next(10000, 99999);

                        Regular_User obj = new Regular_User(name, membership_number);

                        Transaction tr = new Transaction(obj);
                        while (true)
                        {








                            Console.WriteLine("This our Services: ");
                            Console.WriteLine("1.Display User Information\n2.Display Avaliable books\n3.Borrowing Book\n4.Returning Book\n5.Exit\n");
                            Console.Write("Please Choose from 1 to 5 : ");
                            int choice = int.Parse(Console.ReadLine());

                            if (choice == 1)
                            {
                                Console.WriteLine(obj.GetInformation() + "\n");
                            }
                            else if (choice == 2)
                            {















                                library_Management.Display_Book();
                            }
                            else if (choice == 3)
                            {
                                Console.WriteLine("Enter the ISBN for Book: ");
                                int isbn = int.Parse(Console.ReadLine());
                                Book b = library_Management.Find_Book(isbn);

                                if (b != null && b.Quantity > 0)
                                {
                                    obj.Borrowing_Books(b);

                                    Console.WriteLine("Book borrowed successfully!");
                                    tr.setBook(b);
                                    tr.RecordTransaction("Borrowed Book");
                                }
                                else
                                {
                                    Console.WriteLine("Sorry Your Book is not avaliable :(");
                                }
                            }
                            else if (choice == 4)
                            {
                                Console.WriteLine("Enter the ISBN for Book: ");
                                int isbn = int.Parse(Console.ReadLine());
                                Book Return_Book = obj.Find_Book(isbn);

                                if (Return_Book != null)
                                {
                                    obj.Returning_Books(Return_Book);
                                    Console.WriteLine("Book returned successfully!");
                                    tr.setBook(Return_Book);
                                    tr.RecordTransaction("Returned Book");
                                }
                                else
                                {
                                    Console.WriteLine("Sorry Your Book is not in your system :(");
                                }


                            }
                            else if (choice == 5)
                            {
                                Console.WriteLine("Thank you for using our System :)");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Your Entry is Worng , Please Try Again..........");
                            }



                        }
                    }
                    else if (c == 3)
                    {
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Your Entry is Worng , Please Try Again..........");
                        continue;
                    }

                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                
            }
                Console.Read();
            
            
        }
    }
}

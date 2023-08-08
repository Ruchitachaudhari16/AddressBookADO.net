using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookADO.NET_Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Contacts contacts = new Contacts()
                { FirstName = "Ruchita", LastName = "Chaudhari", Address = "Gandhi Nagar", City = "Amravti", State = "Maharastra", Zip = 444105, PhoneNumber = 9158834070, EmailID = "cruchita@gmail.com" };

                AddressBook addressBook = new AddressBook();
                Console.WriteLine("1:Insert Value in Table");
                Console.WriteLine("2:Get all data from database");
                Console.WriteLine("3:Update Data From Database");
                Console.WriteLine("Select correct option");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        addressBook.AddNewContactInDatabase(contacts);
                        break;
                    case 2:
                        addressBook.GetAllDataFromDatabase();
                        break;
                    case 3:
                        Contacts contact = new Contacts()
                        {
                            FirstName = "Swati",
                            LastName = "Gangurde",
                            City = "SouthGoa"
                        };
                        addressBook.UpdateDataInDB(contact);
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;



                }
            }
            Console.ReadLine();
        }
    }
}

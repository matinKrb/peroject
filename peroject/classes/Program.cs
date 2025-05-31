using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome To Hostel Managing Application ");
                Console.WriteLine("_______________________________________");
                Console.WriteLine('\n');
                Console.WriteLine("1 : Login");
                Console.WriteLine("2 : Sign Up");

                Console.Write("Please Enter The Number Of Your Choice: ");

                int LoginOption = int.Parse(Console.ReadLine());

                switch (LoginOption) 
                {
                    case 1:

                        break;

                    case 2:
                        Console.Write("please Enter Your Name :");
                        string Name = Console.ReadLine();
                        Console.Write("please Enter Your FamilyName :");
                        string Family = Console.ReadLine();
                        Console.Write("please Enter Your National Code :");
                        long nationalcode = Convert.ToInt64(Console.ReadLine());
                        Console.Write("please Enter Your PhoneNumber :");
                        string phonenumber = Console.ReadLine();
                        Console.Write("please Enter Your Address :");
                        string address = Console.ReadLine();

                        Person NewPerson = new Person(Name , Family , nationalcode , phonenumber , address);

                        Lists.PersonList.Add(NewPerson);

                        


                        break;
                }
            }
        }
    }
}

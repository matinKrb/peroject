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


            Console.WriteLine("Welcome To Hostel Managing Application ");
            Console.WriteLine("_______________________________________");
            Console.WriteLine('\n');

            LoginPage();

        }
        public static void LoginPage() 
        {
            bool testmainmenu = true;


            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 : Login");
                Console.WriteLine("2 : Sign Up");

                Console.Write("Please Enter The Number Of Your Choice: ");

                var LoginOption = 0;
                try
                {
                    LoginOption = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine('\n');
                    Console.WriteLine(ex.Message);
                    Console.WriteLine('\n');
                }
                switch (LoginOption)
                {
                    case 1:
                        Console.Write("Please Enter Your UserName :");
                        string fusrename = Console.ReadLine();

                        Console.Write("Please Enter Your Password :");
                        int fpaasword = int.Parse(Console.ReadLine());

                        foreach (var item in Lists.UserList)
                        {
                            if (fusrename == item._Username && fpaasword == item._Password)
                            {
                                Console.Clear();
                                Console.WriteLine("Main Menu:");
                                testmainmenu = true;
                                while (testmainmenu)
                                {

                                    MainMenu(ref testmainmenu);

                                }
                            }
                            else
                            {
                                Console.WriteLine("Incorect UserName Or Password");
                                Console.WriteLine("Press Any Butten");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }



                        break;

                    case 2:
                        Console.Write("please Enter Your Name :");
                        string Name = Console.ReadLine();
                        Console.Write("please Enter Your Family :");
                        string Family = Console.ReadLine();
                        Console.Write("please Enter Your National Code :");
                        long nationalcode = 0;
                        try
                        {
                            nationalcode = Convert.ToInt64(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        Console.Write("please Enter Your PhoneNumber :");
                        string phonenumber = Console.ReadLine();
                        Console.Write("please Enter Your Address :");
                        string address = Console.ReadLine();
                        Console.Write("Please Enter Your UserName :");
                        string username = Console.ReadLine();
                        Console.Write("please Enter Your Password :");
                        int password = 0;

                        try
                        {
                            password = int.Parse(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        Person NewPerson = new Person(Name, Family, nationalcode, phonenumber, address);
                        user NewUser = new user(username, password);
                        Lists.PersonList.Add(NewPerson);
                        Lists.UserList.Add(NewUser);

                        Console.WriteLine("Sign Up Successful");
                        Console.WriteLine("press any button");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("LOGIN");
                        Console.WriteLine("---------------------");
                        Console.WriteLine('\n');

                        Console.Write("Please Enter Your UserName :");
                        string Fusrename = Console.ReadLine();

                        Console.Write("Please Enter Your Password :");
                        int Fpaasword = int.Parse(Console.ReadLine());

                        foreach (var item in Lists.UserList)
                        {
                            if (Fusrename == item._Username && Fpaasword == item._Password)
                            {
                                Console.Clear();
                                Console.WriteLine("Main Menu:");
                                testmainmenu = true;
                                while (testmainmenu)
                                {
                                    MainMenu(ref testmainmenu);
                                    Console.ReadKey();

                                }
                            }
                            else
                            {
                                Console.WriteLine("Incorect UserName Or Password");
                                Console.WriteLine("Press Any Butten");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }

                        break;
                    default:
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("Please Just Enter 1 Or 2 !");
                        Console.WriteLine("Press Any Butten");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
        public static void MainMenu(ref bool testmainmenu)
        {
            Console.Clear();
            Console.WriteLine("1 : Hostels Management ");
            Console.WriteLine("2 : Blocks Management ");
            Console.WriteLine("3 : Persons Management ");
            Console.WriteLine("4 : Equipment Management ");
            Console.WriteLine("5 : Reporting ");
            Console.WriteLine("6 : Exit ");
            Console.Write("Please Enter The Option Number : ");

            int menuoption = 0;

            try 
            {
                menuoption = int.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            switch (menuoption)
            {
                case 1:
                    Console.Clear();
                    HostelManagement.DisplayHostelManagmentMenu();
                    break;

                case 2:
                    Console.Clear();
                    BlockManagment.BlockManagmentMenu();
                    break;

                case 3:
                    Console.Clear();
                    PersonManagement.DisplayPersonManagemantMenu();
                    break;

                case 4:
                    Console.Clear();
                    EquipmentManagment.DisplayEquipmentManagment();
                    break;

                case 5:
                    Reporting.ReportingMenu();
                    break;

                case 6:
                    LoginPage();
                    break;

            }

        }
    }
}

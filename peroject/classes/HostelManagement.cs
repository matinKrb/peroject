using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public static class HostelManagement
    {
        public static bool hostelmanagerMainMenu = true;
        public static void DisplayHostelManagmentMenu()
        {
            Console.Clear();

            Console.WriteLine("1 : Add New Hostel");
            Console.WriteLine("2 : Delete A Hostel");
            Console.WriteLine("3 : Edit A Hostel Info");
            Console.WriteLine("4 : Display Hostels List");

            Console.WriteLine('\n');
            Console.Write("Please Enter The Option Number :");

            int HostelManagmentOption = 0;

            try 
            {
                HostelManagmentOption = int.Parse(Console.ReadLine());
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
                hostelmanagerMainMenu = true;

                while (hostelmanagerMainMenu)
                {

                    Program.MainMenu(ref hostelmanagerMainMenu);

                }
            }

            switch(HostelManagmentOption)
            {
                case 1:
                    AddHostel();
                    break;

                case 2:
                    RemoveHostelByName();
                    break;

                case 3:
                    EditHostel();
                    break;

                case 4:
                    DisplayHostel();
                    break;
            }
        }
        public static void AddHostel()
        {
            Console.Clear();

            Console.Write("Please Enter The Hostel Name :");
            string HostelName = Console.ReadLine();
            Console.Write("Please Enter The Hostel Address :");
            string HostelAddress = Console.ReadLine();
            Console.Write("Please Enter The Hostel Capacity :");
            int HostelCapacity = 0;
            try 
            {
                HostelCapacity = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n");
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
                hostelmanagerMainMenu = true;

                while (hostelmanagerMainMenu)
                {

                    Program.MainMenu(ref hostelmanagerMainMenu);

                }

            }

            if (Lists.HostelManagerList.Count>0)
            {
                Console.WriteLine("List Of Hostel Managers Is :");
                Console.WriteLine('\n');
                for (int i = 0; i < Lists.HostelManagerList.Count; i++)
                {
                    Console.WriteLine($"{i + 1} : {Lists.HostelManagerList[i].Name} {Lists.HostelManagerList[i].Family}");

                }
                Console.WriteLine('\n');
                Console.Write("Please Enter The Family Of Hostel Manager Who You Want To Be Manager Of This Hostel :");
            }
            else
            {
                Console.WriteLine("List Of Hostel Manager Is Empty!");
            }


            string HMFamily = Console.ReadLine();

            HostelManager HostelManagerWhoToBeManager = HostelManager.FindHostelManagerByFamily(HMFamily);

            if (HostelManagerWhoToBeManager!=null)
            {
                Hostel NewHostel = new Hostel(HostelName, HostelAddress, HostelCapacity, HostelManagerWhoToBeManager);
                Lists.HostelList.Add(NewHostel);
                Console.WriteLine('\n');
                Console.WriteLine("Hostel Added Successfuly");
            }

            Console.WriteLine("Press Any Button");
            Console.ReadKey();
        }
        public static void RemoveHostelByName()
        {
            Console.Clear();
            if (Lists.HostelList.Count>0)
            {
                Console.WriteLine("List Of Hostel With Name :");
                for (int i = 0; i < Lists.HostelManagerList.Count; i++)
                {
                    Console.WriteLine($"{i + 1} : {Lists.HostelList[i].Name}");

                }
                Console.WriteLine('\n');
                Console.Write("Please Enter The Name Of Hostel Wich You Wanna Delete :");
                string HostelNameToDelete = Console.ReadLine();
                Hostel HostelToRemove = Hostel.FindHostelByName(HostelNameToDelete);
                Lists.HostelList.Remove(HostelToRemove);
                Console.WriteLine('\n');
                if (HostelToRemove != null)
                {
                    Console.WriteLine("Hostel Removed Successfuly");
                }
            }
            else
            {
                Console.WriteLine("List Is Empty!");
            }

           


            Console.WriteLine("Press Any Button");
            Console.ReadKey();
        }

        

        public static void EditHostel()
        {
            Console.Clear();

            if (Lists.HostelList.Count>0)
            {
                Console.WriteLine("List Of Hostels With Name:");
                for (int i = 0; i < Lists.HostelList.Count; i++)
                {
                    Console.WriteLine($"{i + 1} : {Lists.HostelList[i].Name}");

                }
                Console.WriteLine('\n');

                Console.Write("Please Enter The Name Of Hostel Wich You Wanna Edit :");
                string name = Console.ReadLine();

                Hostel ToEditHostel = Hostel.FindHostelByName(name);

                if(ToEditHostel != null) 
                {
                    Console.Write("Please Enter The New Name Of Hostel :");
                    string editedname = Console.ReadLine();
                    Console.Write("Please Enter The New Address Of Hostel :");
                    string address = Console.ReadLine();
                    Console.Write("Please Enter The New Capacity Of Hostel :");
                    int capacity = 0;
                    try
                    {
                        capacity = int.Parse(Console.ReadLine());
                    }
                    catch(Exception ex)
                    {
                        
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Press Any Button");
                        Console.ReadKey();

                        hostelmanagerMainMenu = true;
                        
                        while (hostelmanagerMainMenu)
                        {

                            Program.MainMenu(ref hostelmanagerMainMenu);

                        }
                    }
                    Console.Write("Please Enter The National Code Of Hostel Manager Who You Want to Replace With Older One :");

                    long NewNationalCode = 0;

                    try
                    {
                        NewNationalCode = Convert.ToInt64(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Press Any Button");
                        Console.ReadKey();
                        hostelmanagerMainMenu = true;

                        while (hostelmanagerMainMenu)
                        {

                            Program.MainMenu(ref hostelmanagerMainMenu);

                        }
                        
                    }


                    HostelManager NewHostelManager = HostelManager.FindHostelManagerByNationalCode(NewNationalCode);


                    ToEditHostel.Name = name;
                    ToEditHostel.Address = address;
                    ToEditHostel.Capacity = capacity;
                    ToEditHostel.ManagerName = NewHostelManager;

                    Console.WriteLine('\n');
                    if (NewHostelManager != null)
                    {
                        Console.WriteLine("Hostel Edited Successfuly");
                    }
                }
                
            }
            else
            {
                Console.WriteLine("List Is Empty!");
            }

      

            Console.WriteLine("Press Any Button");
            Console.ReadKey();
        }
        public static void DisplayHostel()
        {
            Console.Clear();
            if (Lists.HostelList.Count>0)
            {

                Console.WriteLine("List Of Hostels :");
                for (int i = 0; i < Lists.HostelList.Count; i++)
                {
                    Console.WriteLine($"{i + 1} :Name: {Lists.HostelList[i].Name} , Address : {Lists.HostelList[i].Address}, Capacity : {Lists.HostelList[i].Capacity} , Name Of Hostel Manager : {Lists.HostelList[i].ManagerName.Name} {Lists.HostelList[i].ManagerName.Family}");
                    Console.WriteLine('\n');

                }
            }
            else
            {
                Console.WriteLine("List Is Empty!");
            }

            Console.WriteLine("Press Any Button");
            Console.ReadKey();
        }

    }
}

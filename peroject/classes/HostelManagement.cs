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
        public static void DisplayHostelManagmentMenu()
        {
            Console.Clear();

            Console.WriteLine("1 : Add New Hostel");
            Console.WriteLine("2 : Delete A Hostel");
            Console.WriteLine("3 : Edit A Hostel Info");
            Console.WriteLine("4 : Display Hostels List");

            Console.WriteLine('\n');
            Console.Write("Please Enter The Option Number :");

            int HostelManagmentOption = int.Parse(Console.ReadLine());

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
            int HostelCapacity = int.Parse(Console.ReadLine());

            for (int i = 0; i < Lists.HostelManagerList.Count; i++)
            {
                Console.WriteLine($"{i+1} : {Lists.HostelManagerList[i].Name} {Lists.HostelManagerList[i].Family}"); 
                
            }
            Console.Write("Please Enter The Family Of Hostel Manager Who You Want To Be Manager Of This Hostel :");


            string HMFamily = Console.ReadLine();

            HostelManager HostelManagerWhoToBeManager = HostelManager.FindHostelManagerByFamily(HMFamily);


            Hostel NewHostel = new Hostel(HostelName, HostelAddress, HostelCapacity, HostelManagerWhoToBeManager);
            Lists.HostelList.Add(NewHostel);

        }
        public static void RemoveHostelByName()
        {
            Console.Clear();

            Console.WriteLine("List Of Hostel With Name :");
            for (int i = 0; i < Lists.HostelManagerList.Count; i++)
            {
                Console.WriteLine($"{i + 1} : {Lists.HostelList[i].Name}");

            }
            Console.WriteLine('\n');
            Console.Write("Please Enter The Name Of Hostel Wich You Wanna Delete :");

            string HostelNameToDelete = Console.ReadLine();

            Lists.HostelList.Remove(Hostel.FindHostelByName(HostelNameToDelete));

        }

        public static void EditHostel()
        {
            Console.Clear();

            Console.WriteLine("List Of Hostels With Name:");
            for (int i = 0; i < Lists.HostelList.Count; i++)
            {
                Console.WriteLine($"{i + 1} : {Lists.HostelList[i].Name}");

            }

            Console.WriteLine('\n');

            Console.Write("Please Enter The Name Of Hostel Wich You Wanna Edit :");
            string name =Console.ReadLine();

            Hostel ToEditHostel = Hostel.FindHostelByName(name);

            Console.Write("Please Enter The Name Of Hostel :");
            string editedname = Console.ReadLine();
            Console.Write("Please Enter The Address Of Hostel :");
            string address = Console.ReadLine();
            Console.Write("Please Enter The Capacity Of Hostel :");
            int capacity = int.Parse(Console.ReadLine());
            Console.Write("Please Enter The National Code Of Hostel Manager Who You Want to Replace With Older One :");

            long NewNationalCode = Convert.ToInt64(Console.ReadLine());

            HostelManager NewHostelManager = HostelManager.FindHostelManagerByNationalCode(NewNationalCode);
            

            ToEditHostel.Name = name;
            ToEditHostel.Address = address;
            ToEditHostel.Capacity = capacity;
            ToEditHostel.ManagerName = NewHostelManager;


        }
        public static void DisplayHostel()
        {
            Console.Clear();

            Console.WriteLine("List Of Hostels :");
            for (int i = 0; i < Lists.HostelList.Count; i++)
            {
                Console.WriteLine($"{i + 1} :Name: {Lists.HostelList[i].Name} , Address : {Lists.HostelList[i].Address}, Capacity : {Lists.HostelList[i].Capacity} , Name Of Hostel Manager : {Lists.HostelList[i].ManagerName.Name}");
                Console.WriteLine('\n');
            }

        }

    }
}

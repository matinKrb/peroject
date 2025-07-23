using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class HostelManagerManagment
    {
        static bool hostelmanagermanagmentMainmenu = true;

        public static void DisplayHostelManagerMenu()
        {
            Console.Clear();
            Console.WriteLine("1 : Add A New Hostel Manager");
            Console.WriteLine("2 : Delete A Hostel Manager");
            Console.WriteLine("3 : Edit A Hostel Manager Info");
            Console.WriteLine("4 : Display Hostels Manager List");

            Console.Write("Please Enter The Option Number : ");
            int HostelManagerManagementOption = 0;

            try
            {
                HostelManagerManagementOption = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
                hostelmanagermanagmentMainmenu = true;

                while (hostelmanagermanagmentMainmenu)
                {

                    Program.MainMenu(ref hostelmanagermanagmentMainmenu);

                }
            }

            switch (HostelManagerManagementOption)
            {
                case 1:
                    AddHostelManager();
                    break;

                case 2:
                    RemoveHostelManager();
                    break;

                case 3:
                    EditHostelManager();
                    break;

                case 4:
                    DisplayHostelManager();
                    break;
            }
        }
        public static void AddHostelManager() 
        {
            Console.Clear();
            Console.Write("Please Enter The Name Of Hostel Manager :");
            string name = Console.ReadLine(); 
            Console.Write("Please Enter The Family Of Hostel Manager :");
            string family = Console.ReadLine();
            Console.Write("Please Enter The Position Of Hostel Manager :");
            string position = Console.ReadLine();
            Console.Write("Please Enter The National Code Of Hostel Manager :");
            long nationalcode = 0;

            try
            {
                nationalcode = Convert.ToInt64(Console.ReadLine());
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
                hostelmanagermanagmentMainmenu = true;

                while (hostelmanagermanagmentMainmenu)
                {

                    Program.MainMenu(ref hostelmanagermanagmentMainmenu);

                }
            }

            Console.Write("Please Enter The Phone Number Of Hostel Manager :");
            string phonenumber = Console.ReadLine();
            Console.Write("Please Enter The Address Of Hostel Manager :");
            string address = Console.ReadLine();

            HostelManager NewHostelManager = new HostelManager(position,name , family , phonenumber , nationalcode , address );
            Lists.HostelManagerList.Add(NewHostelManager);
            Console.WriteLine('\n');
            Console.WriteLine("Hostel Manager Added Successfully");
            Console.WriteLine("Press Any Button");
            Console.ReadKey();

        }

        public static void RemoveHostelManager() 
        {
            Console.Clear();

            if (Lists.HostelManagerList.Count>0)
            {
                Console.WriteLine("List Of Hostel Managers With National Code:");
                for (int i = 0; i < Lists.HostelManagerList.Count; i++)
                {
                    Console.WriteLine($"{i + 1} : {Lists.HostelManagerList[i].Family} {Lists.HostelManagerList[i].NationalCode}");

                }
                Console.WriteLine('\n');

                Console.Write("Please Enter The NationalCode Wich You Wanna Delete :");
                long nationalcode = 0;

                try
                {
                    nationalcode = Convert.ToInt64(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Press Any Button");
                    Console.ReadKey();
                    hostelmanagermanagmentMainmenu = true;

                    while (hostelmanagermanagmentMainmenu)
                    {

                        Program.MainMenu(ref hostelmanagermanagmentMainmenu);

                    }
                }
                HostelManager HostelManagerToRemove = HostelManager.FindHostelManagerByNationalCode(nationalcode);
                Lists.HostelManagerList.Remove(HostelManagerToRemove);
                Console.WriteLine('\n');
                if (HostelManagerToRemove != null)
                {
                    Console.WriteLine("Hostel Manager Removed Successfully");
                }
            }
            else
            {
                Console.WriteLine("List Of Hostel Managers Is Empty!");
            }

            Console.WriteLine("Press Any Button");
            Console.ReadKey();

        }

        public static void EditHostelManager()
        {
            Console.Clear();
            if (Lists.HostelManagerList.Count>0)
            {
                Console.WriteLine("List Of Hostel Managers With National Code:");
                for (int i = 0; i < Lists.HostelManagerList.Count; i++)
                {
                    Console.WriteLine($"{i + 1} : {Lists.HostelManagerList[i].Family} {Lists.HostelManagerList[i].NationalCode}");

                }

                Console.WriteLine('\n');

                Console.Write("Please Enter The NationalCode Of Hostel Manager Wich You Wanna Edit :");
                long nationalcode = 0;

                try
                {
                    nationalcode = Convert.ToInt64(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Press Any Button");
                    Console.ReadKey();
                    hostelmanagermanagmentMainmenu = true;

                    while (hostelmanagermanagmentMainmenu)
                    {

                        Program.MainMenu(ref hostelmanagermanagmentMainmenu);

                    }
                }

                HostelManager ToEditHostelManager = HostelManager.FindHostelManagerByNationalCode(nationalcode);


                if (ToEditHostelManager != null)
                {
                    Console.Write("Please Enter The New Name Of Hostel Manager :");
                    string name = Console.ReadLine();
                    Console.Write("Please Enter The New Family Of Hostel Manager :");
                    string family = Console.ReadLine();
                    Console.Write("Please Enter The New Position Of Hostel Manager :");
                    string position = Console.ReadLine();
                    Console.Write("Please Enter The New National Code Of Hostel Manager :");
                    long editednationalcode = 0;

                    try
                    {
                        editednationalcode = Convert.ToInt64(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Press Any Button");
                        Console.ReadKey();
                        hostelmanagermanagmentMainmenu = true;

                        while (hostelmanagermanagmentMainmenu)
                        {

                            Program.MainMenu(ref hostelmanagermanagmentMainmenu);

                        }
                    }
                    Console.Write("Please Enter The New Phone Number Of Hostel Manager :");
                    string phonenumber = Console.ReadLine();
                    Console.Write("Please Enter The New Address Of Hostel Manager :");
                    string address = Console.ReadLine();

                    ToEditHostelManager.Name = name;
                    ToEditHostelManager.Family = family;
                    ToEditHostelManager.Position = position;
                    ToEditHostelManager.NationalCode = editednationalcode;
                    ToEditHostelManager.PhoneNumber = phonenumber;
                    ToEditHostelManager.Addres = address;
                    Console.WriteLine('\n');
                    Console.WriteLine("Hostel Manager Edited Successfully");
                }
            }
            else
            {
                Console.WriteLine("List Of Hostel Managers Is Empty!");
            }


            Console.WriteLine("Press Any Button");
            Console.ReadKey();
        }

        public static void DisplayHostelManager() 
        {
            Console.Clear();

            if (Lists.HostelManagerList.Count>0)
            {
                Console.WriteLine("List Of Hostel Managers:");
                Console.WriteLine("\n");
                for (int i = 0; i < Lists.HostelManagerList.Count; i++)
                {
                    Console.WriteLine($"{i + 1} :Name: {Lists.HostelManagerList[i].Name} Family: {Lists.HostelManagerList[i].Family} National Code: {Lists.HostelManagerList[i].NationalCode} Position: {Lists.HostelManagerList[i].Position} Phone Number: {Lists.HostelManagerList[i].PhoneNumber} Address: {Lists.HostelManagerList[i].Addres}");
                    Console.WriteLine('\n');
                }
            }
            else
            {
                Console.WriteLine("List Of Hostel Managers Is Empty!");
            }


            Console.WriteLine("Press Any Button");
            Console.ReadKey();
        }
    }
}

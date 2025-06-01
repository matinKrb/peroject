using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class HostelManagerManagment
    {

        public static void DisplayHostelManagerMenu()
        {
            Console.Clear();
            Console.WriteLine("1 : Add A New Hostel Manager");
            Console.WriteLine("2 : Delete A Hostel Manager");
            Console.WriteLine("3 : Edit A Hostel Manager Info");
            Console.WriteLine("4 : Display Hostels Manager List");

            Console.Write("Please Enter The Option Number : ");
            int HostelManagerManagementOption = int.Parse(Console.ReadLine());

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
            long nationalcode = Convert.ToInt64(Console.ReadLine());
            Console.Write("Please Enter The Phone Number Of Hostel Manager :");
            string phonenumber = Console.ReadLine();
            Console.Write("Please Enter The Address Of Hostel Manager :");
            string address = Console.ReadLine();

            HostelManager NewHostelManager = new HostelManager(position,name , family , phonenumber , nationalcode , address );
            Lists.HostelManagerList.Add(NewHostelManager);
            Console.WriteLine('\n');
            Console.WriteLine("Hostel Manager Added Successfuly");
            Console.WriteLine("Press Any Button");
            Console.ReadKey();

        }

        public static void RemoveHostelManager() 
        {
            Console.Clear();

            Console.WriteLine("List Of Hostel Managers With National Code:");
            for (int i = 0; i < Lists.HostelManagerList.Count; i++)
            {
                Console.WriteLine($"{i + 1} : {Lists.HostelManagerList[i].Family} {Lists.HostelManagerList[i].NationalCode}");

            }
            Console.WriteLine('\n');

            Console.Write("Please Enter The NationalCode Wich You Wanna Delete :");
            long nationalcode = Convert.ToInt64(Console.ReadLine());

            Lists.HostelManagerList.Remove(HostelManager.FindHostelManagerByNationalCode(nationalcode));
            Console.WriteLine('\n');
            Console.WriteLine("Hostel Manager Removed Successfuly");
            Console.WriteLine("Press Any Button");
            Console.ReadKey();

        }

        public static void EditHostelManager()
        {
            Console.Clear();

            Console.WriteLine("List Of Hostel Managers With National Code:");
            for (int i = 0; i < Lists.HostelManagerList.Count; i++)
            {
                Console.WriteLine($"{i + 1} : {Lists.HostelManagerList[i].Family} {Lists.HostelManagerList[i].NationalCode}");

            }

            Console.WriteLine('\n');

            Console.Write("Please Enter The NationalCode Of Hostel Manager Wich You Wanna Edit :");
            long nationalcode = Convert.ToInt64(Console.ReadLine());

            HostelManager ToEditHostelManager = HostelManager.FindHostelManagerByNationalCode(nationalcode);

            Console.Write("Please Enter The Name Of Hostel Manager :");
            string name = Console.ReadLine();
            Console.Write("Please Enter The Family Of Hostel Manager :");
            string family = Console.ReadLine();
            Console.Write("Please Enter The Position Of Hostel Manager :");
            string position = Console.ReadLine();
            Console.Write("Please Enter The National Code Of Hostel Manager :");
            long editednationalcode = Convert.ToInt64(Console.ReadLine());
            Console.Write("Please Enter The Phone Number Of Hostel Manager :");
            string phonenumber = Console.ReadLine();
            Console.Write("Please Enter The Address Of Hostel Manager :");
            string address = Console.ReadLine();

            ToEditHostelManager.Name = name;
            ToEditHostelManager.Family = family;
            ToEditHostelManager.Position = position;
            ToEditHostelManager.NationalCode = editednationalcode;
            ToEditHostelManager.PhoneNumber = phonenumber;
            ToEditHostelManager.Addres = address;
            Console.WriteLine('\n');
            Console.WriteLine("Hostel Manager Edited Successfuly");
            Console.WriteLine("Press Any Button");
            Console.ReadKey();
        }

        public static void DisplayHostelManager() 
        {
            Console.Clear();

            Console.WriteLine("List Of Hostel Managers:");
            for (int i = 0; i < Lists.HostelManagerList.Count; i++)
            {
                Console.WriteLine($"{i + 1} : {Lists.HostelManagerList[i].Name} {Lists.HostelManagerList[i].Family} {Lists.HostelManagerList[i].NationalCode} {Lists.HostelManagerList[i].Position} {Lists.HostelManagerList[i].PhoneNumber} {Lists.HostelManagerList[i].Addres}");
                Console.WriteLine('\n');
            }
            
            
            Console.WriteLine("Press Any Button");
            Console.ReadKey();
        }
    }
}

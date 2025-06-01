using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class HostelManagerManagment
    {
        public static void AddHostelManager() 
        {
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


        }

        public static void RemoveHostelManager() 
        {
            Console.WriteLine("List Of Hostel Managers With National Code:");
            for (int i = 0; i < Lists.HostelManagerList.Count; i++)
            {
                Console.WriteLine($"{i + 1} : {Lists.HostelManagerList[i].Family} {Lists.HostelManagerList[i].NationalCode}");

            }
            Console.WriteLine('\n');

            Console.Write("Please Enter The NationalCode Wich You Wanna Delete :");
            long nationalcode = Convert.ToInt64(Console.ReadLine());

            Lists.HostelManagerList.Remove(HostelManager.FindHostelManagerByNationalCode(nationalcode));


        }

        public static void EditHostelManager() 
        {
            Console.WriteLine("List Of Hostel Managers With National Code:");
            for (int i = 0; i < Lists.HostelManagerList.Count; i++)
            {
                Console.WriteLine($"{i + 1} : {Lists.HostelManagerList[i].Family} {Lists.HostelManagerList[i].NationalCode}");

            }

            Console.WriteLine('\n');

            Console.Write("Please Enter The NationalCode Wich You Wanna Edit :");
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

        }

        public static void Display() 
        {
            Console.WriteLine("List Of Hostel Managers:");
            for (int i = 0; i < Lists.HostelManagerList.Count; i++)
            {
                Console.WriteLine($"{i + 1} : {Lists.HostelManagerList[i].Name} {Lists.HostelManagerList[i].Family} {Lists.HostelManagerList[i].NationalCode} {Lists.HostelManagerList[i].Position} {Lists.HostelManagerList[i].PhoneNumber} {Lists.HostelManagerList[i].Addres}");
                Console.WriteLine('\n');
            }

        }
    }
}

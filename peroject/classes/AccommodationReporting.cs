using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class AccommodationReporting
    {
        public static bool AccommodationReportiMenu = true;
        public static void AccommodationReportingMenu()
        {
            Console.Clear();
            Console.WriteLine("1 : General Statistics On Student Accommodation");
            Console.WriteLine("2 : List Of Empty And Full Room");
            Console.WriteLine("3 : Remaining Capacity Of Each Hostel And Block");
            Console.WriteLine('\n');
            Console.Write("Please Enter The Option Number : ");

            int AccommodationReportingoption = 0;

            try
            {
                AccommodationReportingoption = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            switch (AccommodationReportingoption)
            {
                case 1:
                    Console.Clear();
                    GeneralStatisticsAccommodtion();
                    break;

                case 2:
                    Console.Clear();
                    ListOfEmptyAndFullRoom();
                    break;

                case 3:
                    Console.Clear();
                    RemainingCapacityOfHostel();
                    break;



            }
        }
        public static void GeneralStatisticsAccommodtion()
        {
            Console.Clear();
            Console.WriteLine($"Number Of Registered Student In Hostel : {StudentManagement.NumberOFRegisteredStudent}");

            if (StudentManagement.NumberOFRegisteredStudent>0)
            {
                Console.WriteLine("Press any Button To Display Their List");
                Console.ReadKey();
                Console.Clear();
                for (int i = 0; i < Lists.RegisteredStudent.Count; i++)
                {
                    Console.WriteLine($"{i + 1} : Name : {Lists.RegisteredStudent[i].Name} , Family : {Lists.RegisteredStudent[i].Family} , Student Id : {Lists.RegisteredStudent[i].StudentId} , Hostel : {Lists.RegisteredStudent[i].StHostel.Name} , Block : {Lists.RegisteredStudent[i].StBlock.BlockName} , Room : {Lists.RegisteredStudent[i].StRoom.roomNum}");
                }

                Console.WriteLine('\n');
                Console.WriteLine("Press any Button");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Press any Button");
                Console.ReadKey();
            }
        }
        public static void ListOfEmptyAndFullRoom()
        {
            if (Lists.HostelList.Count > 0)
            {
                Console.WriteLine("List Of Hotels :");
                Console.WriteLine('\n');
                for (int i = 0; i < Lists.HostelList.Count; i++)
                {
                    Console.WriteLine($"{i + 1} : {Lists.HostelList[i].Name}");
                }
                Console.WriteLine('\n');
                Console.Write("Please Enter The Name Of Hostel Wich You Want To Display Its Rooms :");
                string HostelNameToSeeItsRoom = Console.ReadLine();

                Hostel HostelToSeeItsRoom = Hostel.FindHostelByName(HostelNameToSeeItsRoom);
                Console.WriteLine('\n');
                Console.WriteLine("Successfuly");
                Console.WriteLine("Press Any Button to Select Block");
                Console.ReadKey();
                Console.Clear();

                if (HostelToSeeItsRoom.BlockList.Count > 0)
                {
                    Console.WriteLine("List Of Blocks From This Hostel :");
                    for (int i = 0; i < HostelToSeeItsRoom.BlockList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1} : {HostelToSeeItsRoom.BlockList[i].BlockName}");
                    }
                    Console.WriteLine('\n');
                    Console.Write("Please Enter The Name Of Block Wich You Want To Display Its Rooms :");
                    string BlockNameToSeeItsRoom = Console.ReadLine();

                    Block BlockToSeeItsRoom = Block.FindBlockByName(BlockNameToSeeItsRoom, HostelToSeeItsRoom);
                    Console.WriteLine('\n');
                    Console.WriteLine("Successfuly");
                    Console.WriteLine("Press Any Button");
                    Console.ReadKey();
                    Console.Clear();
                    if (BlockToSeeItsRoom.BlockRoomsList.Count > 0)
                    {
                        Console.WriteLine("List Of Rooms From This Block :");
                        for (int i = 0; i < BlockToSeeItsRoom.BlockRoomsList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1} : Room {BlockToSeeItsRoom.BlockRoomsList[i].roomNum} , Remaining Capacity : {BlockToSeeItsRoom.BlockRoomsList[i].capacity}");
                        }
                        Console.WriteLine('\n');

                        Console.WriteLine("Press Any Button");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine('\n');
                        Console.WriteLine("There Is No Room From This Block");
                        Console.WriteLine("Press Any Button");
                        Console.ReadKey();
                    }

                }
                else
                {
                    Console.WriteLine('\n');
                    Console.WriteLine("There Is No Block From This Hostel");
                    Console.WriteLine("Press Any Button");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("List Of Hostel Is Empty !");
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
            }

        }
        public static void RemainingCapacityOfHostel()
        {
            if (Lists.HostelList.Count > 0)
            {
                Console.WriteLine("List Of Hotels :");
                Console.WriteLine('\n');
                for (int i = 0; i < Lists.HostelList.Count; i++)
                {
                    Console.WriteLine($"{i + 1} : {Lists.HostelList[i].Name}");
                }
                Console.WriteLine('\n');
                Console.Write("Please Enter The Name Of Hostel Which You Want To Display Its Remaining Capacity And Its Blocks Capacity :");
                string HostelNameToSeeItsCapacity = Console.ReadLine();

                Hostel HostelToSeeItsCapacity = Hostel.FindHostelByName(HostelNameToSeeItsCapacity);
                Console.WriteLine('\n');
                Console.WriteLine($"Remaining Capacity Of This Hostel : {HostelToSeeItsCapacity.Capacity}");
                Console.WriteLine('\n');
                Console.WriteLine("Press Any Button to Select Block");
                Console.ReadKey();
                Console.Clear();

                if (HostelToSeeItsCapacity.BlockList.Count > 0)
                {
                    Console.WriteLine("List Of Blocks From This Hostel :");
                    for (int i = 0; i < HostelToSeeItsCapacity.BlockList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1} : {HostelToSeeItsCapacity.BlockList[i].BlockName}");
                    }
                    Console.WriteLine('\n');
                    Console.Write("Please Enter The Name Of Block Wich You Want To Display Its Remaining Capacity :");
                    string BlockNameToSeeItsCapacity = Console.ReadLine();

                    Block BlockToSeeItsCapacity = Block.FindBlockByName(BlockNameToSeeItsCapacity, HostelToSeeItsCapacity);
                    int sum = 0;
                    for (int i = 0; i < BlockToSeeItsCapacity.BlockRoomsList.Count; i++)
                    {
                        sum += BlockToSeeItsCapacity.BlockRoomsList[i].capacity;
                    }

                    Console.WriteLine('\n');

                    Console.WriteLine($"Remaining Capacity Of This Block : {sum}");

                    Console.WriteLine("Press Any Button");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine('\n');
                    Console.WriteLine("There Is No Block From This Hostel");
                    Console.WriteLine("Press Any Button");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("List Of Hostel Is Empty !");
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
            }
        }
    }
}

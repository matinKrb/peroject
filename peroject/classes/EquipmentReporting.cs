using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class EquipmentReporting
    {
        public static bool EquipmentreportingMenu = true;
        public static void EquipmentReportingMenu()
        {
            Console.Clear();
            Console.WriteLine("1 : List Of All Equipment");
            Console.WriteLine("2 : List Of Equipment Allocated To Each Room");
            Console.WriteLine("3 : List Of Equipment Allocated To Each Student");
            Console.WriteLine("4 : List Of Defective And Fixing Equipment");
            Console.WriteLine('\n');
            Console.Write("Please Enter The Option Number : ");

            int EquipmentReportingoption = 0;

            try
            {
                EquipmentReportingoption = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            switch (EquipmentReportingoption)
            {
                case 1:
                    Console.Clear();
                    ListOfAllInfo();
                    break;

                case 2:
                    Console.Clear();
                    ListOfEquipmentRoom();
                    break;

                case 3:
                    Console.Clear();
                    ListOfEquipmentStudent();
                    break;

                case 4:
                    Console.Clear();
                    ListOfDefectiveAndFixingEquipment();
                    break;



            }
        }
        public static void ListOfAllInfo()
        {
            Console.Clear();
            if (Lists.EquipmentsList.Count > 0)
            {
                Console.WriteLine("Please Enter Any Button To Show Equipment List !");
                Console.ReadKey();
                for (int j = 0; j < Lists.EquipmentsList.Count; j++)
                {
                    Console.WriteLine($"{j + 1}: {Lists.EquipmentsList[j].EqType} , {Lists.EquipmentsList[j].PartNumber} , {Lists.EquipmentsList[j].PropNum} ");
                }
                Console.WriteLine('\n');
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The List Of Equipment Is Empty!");
                Console.WriteLine("Press Any Button ");
                Console.ReadKey();

                EquipmentreportingMenu = true;

                while (EquipmentreportingMenu)
                {

                    Program.MainMenu(ref EquipmentreportingMenu);

                }
            }
        }

        public static void ListOfEquipmentRoom()
        {
            Console.Clear();
            if (Lists.HostelList.Count > 0)
            {
                Console.WriteLine("Please Enter Any Button To Show Hostel List !");
                Console.ReadKey();
                for (int j = 0; j < Lists.HostelList.Count; j++)
                {
                    Console.WriteLine($"{j + 1}: {Lists.HostelList[j].Name}  ");
                }
                Console.WriteLine('\n');
            }
            else
            {
                Console.WriteLine("The List Of Hostels Is Empty!");
                Console.WriteLine("Press Any Button ");
                Console.ReadKey();

                EquipmentreportingMenu = true;

                while (EquipmentreportingMenu)
                {

                    Program.MainMenu(ref EquipmentreportingMenu);

                }
            }
            Console.Write("Please Enter The Name Of Hostel :");
            string FoundedHostel = Console.ReadLine();
            Hostel FoundedHostlForEntering = Hostel.FindHostelByName(FoundedHostel);

            Console.Clear();
            if (FoundedHostlForEntering.BlockList.Count > 0)
            {
                Console.WriteLine("Please Enter Any Button To Show Block List !");
                Console.ReadKey();
                for (int j = 0; j < FoundedHostlForEntering.BlockList.Count; j++)
                {
                    Console.WriteLine($"{j + 1}: {FoundedHostlForEntering.BlockList[j].BlockName} ");
                }
                Console.WriteLine('\n');
            }
            else
            {
                Console.WriteLine("The List Of Block Is Empty!");
                Console.WriteLine("Press Any Button ");
                Console.ReadKey();

                EquipmentreportingMenu = true;

                while (EquipmentreportingMenu)
                {

                    Program.MainMenu(ref EquipmentreportingMenu);

                }
            }
            Console.Write("Please Enter The Name Of Block :");
            string FoundedBlock = Console.ReadLine();
            Block FoundedBlockForEntering = Block.FindBlockByName(FoundedBlock, FoundedHostlForEntering);

            Console.Clear();
            if (FoundedBlockForEntering.BlockRoomsList.Count > 0)
            {
                Console.WriteLine("Please Enter Any Button To Show Room List !");
                Console.ReadKey();
                for (int j = 0; j < FoundedBlockForEntering.BlockRoomsList.Count; j++)
                {
                    Console.WriteLine($"{j + 1}: Room {FoundedBlockForEntering.BlockRoomsList[j].roomNum}");
                }
                Console.WriteLine('\n');
            }
            else
            {
                Console.WriteLine("The List Of Equipment Is Empty!");
                Console.WriteLine("Press Any Button ");
                Console.ReadKey();

                EquipmentreportingMenu = true;

                while (EquipmentreportingMenu)
                {

                    Program.MainMenu(ref EquipmentreportingMenu);

                }
            }


            Console.Write("Please Enter The Number Of Room :");
            int FoudedRoomNuber = 0;



            try
            {
                FoudedRoomNuber = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
                EquipmentreportingMenu = true;

                while (EquipmentreportingMenu)
                {

                    Program.MainMenu(ref EquipmentreportingMenu);

                }
            }
            Room FoundedRoom = Room.FindRoomByRoomNumber(FoudedRoomNuber, FoundedBlockForEntering);

            Console.Clear();
            if (FoundedRoom.RoomEq.Count > 0)
            {
                Console.WriteLine("Please Enter Any Button To Show Equipment List !");
                Console.ReadKey();

                for (int j = 0; j < FoundedRoom.RoomEq.Count; j++)
                {
                    Console.WriteLine($"{j + 1}: {FoundedRoom.RoomEq[j].EqType} , {FoundedRoom.RoomEq[j].PartNumber} , {FoundedRoom.RoomEq[j].PropNum} ");
                }
                Console.WriteLine('\n');
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The List Of Equipment Is Empty!");
                Console.WriteLine("Press Any Button ");
                Console.ReadKey();

                EquipmentreportingMenu = true;

                while (EquipmentreportingMenu)
                {

                    Program.MainMenu(ref EquipmentreportingMenu);

                }
            }

        }
        public static void ListOfEquipmentStudent()
        {
            if (Lists.StudentList.Count > 0)
            {
                Console.Write("Please Enter The Student Id Who You Wanna Display His Equipment : ");
                int FoudedStudentId = 0;



                try
                {
                    FoudedStudentId = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Press Any Button");
                    Console.ReadKey();
                    EquipmentreportingMenu = true;

                    while (EquipmentreportingMenu)
                    {

                        Program.MainMenu(ref EquipmentreportingMenu);

                    }
                }

                Student Foundstudent = Student.FindStudentByStudentId(FoudedStudentId);

                if (Foundstudent.StEquipment.Count > 0)
                {
                    Console.WriteLine("Please Enter Any Button To Show Equipment List !");
                    Console.ReadKey();
                    for (int j = 0; j < Foundstudent.StEquipment.Count; j++)
                    {
                        Console.WriteLine($"{j + 1}: {Foundstudent.StEquipment[j].EqType} , {Foundstudent.StEquipment[j].PartNumber} , {Foundstudent.StEquipment[j].PropNum} ");
                    }
                    Console.WriteLine('\n');
                    Console.WriteLine("Press Any Button");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("The List Of Equipment Is Empty!");
                    Console.WriteLine("Press Any Button ");
                    Console.ReadKey();

                    EquipmentreportingMenu = true;

                    while (EquipmentreportingMenu)
                    {

                        Program.MainMenu(ref EquipmentreportingMenu);

                    }
                }
            }
            else
            {
                Console.WriteLine("The List Of Student Is Empty!");
                Console.WriteLine("Press Any Button ");
                Console.ReadKey();

                EquipmentreportingMenu = true;

                while (EquipmentreportingMenu)
                {

                    Program.MainMenu(ref EquipmentreportingMenu);

                }
            }


        }
        public static void ListOfDefectiveAndFixingEquipment()
        {
            Console.WriteLine("Please Enter Any Button To Show Equipment List !");
            Console.ReadKey();
            if (Lists.FixingEquipments.Count > 0)
            {
                Console.WriteLine("The List Of Fixing Equipment");
                Console.WriteLine('\n');
                for (int j = 0; j < Lists.FixingEquipments.Count; j++)
                {
                    Console.WriteLine($"{j + 1}: {Lists.FixingEquipments[j].EqType} , {Lists.FixingEquipments[j].PartNumber} , {Lists.FixingEquipments[j].PropNum} ");

                }

            }
            else
            {
                Console.WriteLine("The List Of Fixing Equipment Is Empty!");
                Console.WriteLine("Press Any Button ");
                Console.ReadKey();

                EquipmentreportingMenu = true;

                while (EquipmentreportingMenu)
                {

                    Program.MainMenu(ref EquipmentreportingMenu);

                }
            }
            Console.WriteLine('\n');
            if (Lists.DefectiveEquipment.Count > 0)
            {
                Console.WriteLine("The List Of Defective Equipment");
                Console.WriteLine('\n');

                for (int j = 0; j < Lists.DefectiveEquipment.Count; j++)
                {
                    Console.WriteLine($"{j + 1}: {Lists.DefectiveEquipment[j].EqType} , {Lists.DefectiveEquipment[j].PartNumber} , {Lists.DefectiveEquipment[j].PropNum} ");

                }
            }
            else
            {
                Console.WriteLine("The List Of Defective Equipment Is Empty!");
                Console.WriteLine("Press Any Button ");
                Console.ReadKey();

                EquipmentreportingMenu = true;

                while (EquipmentreportingMenu)
                {

                    Program.MainMenu(ref EquipmentreportingMenu);

                }
            }

            Console.WriteLine('\n');
            Console.WriteLine("Press Any Button");
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{


    public class EquipmentManagment
    {
        public static bool Equipmentmanagment = true;
        public static void DisplayEquipmentManagment()
        {
            Console.WriteLine("1: Add New Equipment ");
            Console.WriteLine("2: Allocating Equipment To rooms ");
            Console.WriteLine("3: Allocating Equipment To Student ");
            Console.WriteLine("4: Managing The Movement Of Equipment ");
            Console.WriteLine("5: Fixing Managment ");
            Console.WriteLine('\n');
            Console.Write("Please Enter Number Of Option :");
            int EquipmentNumberOption = 0;

            try
            {
                EquipmentNumberOption = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
                Equipmentmanagment = true;

                while (Equipmentmanagment)
                {

                    Program.MainMenu(ref Equipmentmanagment);

                }
            }
            switch (EquipmentNumberOption)
            {

                case 1:
                    AddEquipmentMenu();
                    break;

                case 2:
                    AllocationEquipmentToRoomMenu();
                    break;

                case 3:
                    AllocatingEquipmentToStudentMenu();
                    break;

                case 4:
                    ManagingTheMovementOfEquipment();
                    break;

                case 5:
                    FixingManagment();
                    break;
            }


        }

        public static int EquipmentsCount;
        public static void AddEquipmentMenu()
        {
            Console.Clear();
            Console.Write("Please Enter The Equipment Type :");
            string Type = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ok! Now You Should Enter A part Number Based On Equipment Type :");
            Console.WriteLine();
            Console.WriteLine("Pay Attention !");
            Console.WriteLine("001: Refrigerator");
            Console.WriteLine("002: Table");
            Console.WriteLine("003: Chair");
            Console.WriteLine("004: Bed");
            Console.WriteLine("005: Closet");
            Console.WriteLine();
            Console.Write("Part Number:");

            string PartNumber = Console.ReadLine();

            long HelpPropNum = 10000 + EquipmentsCount;

            string PropNum = $"{HelpPropNum}{PartNumber}";


            Equipment NewEquipment = new Equipment(Type, PartNumber, PropNum);
            EquipmentsCount++;
            Lists.EquipmentsList.Add(NewEquipment);
            Console.WriteLine("Equipment Added Successfuly");
            Console.WriteLine('\n');


            Console.WriteLine("List:");
            Console.WriteLine("\n");
            for (int j = 0; j < Lists.EquipmentsList.Count; j++)
            {
                Console.WriteLine($"{j + 1}: {Lists.EquipmentsList[j].EqType} , {Lists.EquipmentsList[j].PartNumber} , {Lists.EquipmentsList[j].PropNum} ");
            }

            Console.WriteLine("Press Any Button ");
            Console.ReadKey();
        }

        public static Equipment FindEquipmentByPropNum(string propnum)
        {
            Equipment Result = null;
            for (int i = 0; i < Lists.EquipmentsList.Count; i++)
            {
                if (Lists.EquipmentsList[i].PropNum == propnum)
                {
                    Result = Lists.EquipmentsList[i];
                }

            }
            if (Result == null)
            {
                {
                    Console.WriteLine("Equipment Not Found!");
                    Console.WriteLine("Press Any Button ");
                    Console.ReadKey();

                    Equipmentmanagment = true;

                    while (Equipmentmanagment)
                    {

                        Program.MainMenu(ref Equipmentmanagment);

                    }
                }
            }
            return Result;

        }





        public static void AllocationEquipmentToRoomMenu()
        {
            Console.Clear();
            Console.Write("Please Enter The Hostel Name Wich You Wanna Manage Its Equipments :");
            string HostelName = Console.ReadLine();
            Hostel FoundHostel = Hostel.FindHostelByName(HostelName);
            Console.WriteLine("Now You Should Chosse Block From The List Below ");
            for (int i = 0; i < FoundHostel.BlockList.Count; i++)
            {
                Console.WriteLine($"{i+1}:{FoundHostel.BlockList[i].BlockName}");
                Console.WriteLine();
            }

            Console.Write("Please Enter The Block Name Wich You Wanna Manage Its Equipment :");
            string BlockName = Console.ReadLine();
            
            Block FoundBlock = Block.FindBlockByName(BlockName, FoundHostel);
            Console.WriteLine("Now You Should Chosse Room From The List Below ");
            for (int i = 0; i < FoundBlock.BlockRoomsList.Count; i++)
            {
                Console.WriteLine($"{i+1}:Room {FoundBlock.BlockRoomsList[i].roomNum}");
                Console.WriteLine();
            }
            Console.WriteLine('\n');
            Console.Write("Please Enter The Room Number Wich You Wanna Manage Its Equipment :");

            int RoomNum = 0;
            try
            {
                RoomNum = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
                Equipmentmanagment = true;

                while (Equipmentmanagment)
                {

                    Program.MainMenu(ref Equipmentmanagment);

                }
            }
            Room FoundRoom = Room.FindRoomByRoomNumber(RoomNum,FoundBlock);
            Console.WriteLine('\n');
            Console.WriteLine("Now You Should Chosse Equipments From The List Below ");
            Console.WriteLine('\n');
            
            for (int j = 0; j < Lists.EquipmentsList.Count; j++)
            {
                Console.WriteLine($"{j + 1}: {Lists.EquipmentsList[j].EqType} , {Lists.EquipmentsList[j].PartNumber} , {Lists.EquipmentsList[j].PropNum} ");
            }
            Console.WriteLine('\n');
            Console.Write("Enter The Choosen Refrigerator(PropNum):");
            string RefrigeratorPropNum = Console.ReadLine();
            FoundRoom.RoomEq.Add(FindEquipmentByPropNum(RefrigeratorPropNum));
            Console.WriteLine('\n');
            for (int i = 1; i <= 6; i++)
            {
                Console.Write($"Enter The Choosen Table{i} (PropNum) :");
                string TablePropNum = Console.ReadLine();
                FoundRoom.RoomEq.Add(FindEquipmentByPropNum(TablePropNum));

            }
            Console.WriteLine('\n');
            for (int i = 1; i <= 6; i++)
            {
                Console.Write($"Enter The Choosen Chair{i} (PropNum) :");
                string ChairPropNum = Console.ReadLine();
                FoundRoom.RoomEq.Add(FindEquipmentByPropNum(ChairPropNum));

            }
            Console.WriteLine('\n');
            for (int i = 1; i <= 6; i++)
            {
                Console.Write($"Enter The Choosen Bed{i} (PropNum) :");
                string BedPropNum = Console.ReadLine();
                FoundRoom.RoomEq.Add(FindEquipmentByPropNum(BedPropNum));

            }
            Console.WriteLine('\n');
            for (int i = 1; i <= 6; i++)
            {
                Console.Write($"Enter The Choosen Closet{i} (PropNum) :");
                string ClosetPropNum = Console.ReadLine();
                FoundRoom.RoomEq.Add(FindEquipmentByPropNum(ClosetPropNum));

            }
            
            Console.WriteLine('\n');
            Console.WriteLine($"Equipments Successfuly Allocated To Room {FoundRoom.roomNum}");
            Console.WriteLine("Press Any Button!");
            Console.ReadKey();
        }





        //****************************************************************************************

        public static void AllocatingEquipmentToStudentMenu()
        {
            Console.Clear();

            Console.WriteLine("Please Enter The Student Id Of Student Who You Wanna Manage His Equipments:");

            long StudentIdToFind = 0;

            try
            {
                StudentIdToFind = Convert.ToInt64(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
                Equipmentmanagment = true;

                while (Equipmentmanagment)
                {

                    Program.MainMenu(ref Equipmentmanagment);

                }
            }

            Student OwnerStudent = Student.FindStudentByStudentId(StudentIdToFind);

            Console.WriteLine("Now You Should Chosse Equipments From The List Below ");
            Console.WriteLine('\n');
            for (int j = 0; j < Lists.EquipmentsList.Count; j++)
            {
                Console.WriteLine($"{j + 1}: {Lists.EquipmentsList[j].EqType} , {Lists.EquipmentsList[j].PartNumber} , {Lists.EquipmentsList[j].PropNum} ");
            }

            Console.WriteLine('\n');

            Console.WriteLine("Enter The Choosen Refrigerator(PropNum):");
            string RefrigeratorPropNum = Console.ReadLine();

            Console.WriteLine("Enter The Choosen Table(PropNum):");
            string TablePropNum = Console.ReadLine();

            Console.WriteLine("Enter The Choosen Chair(PropNum):");
            string ChairPropNum = Console.ReadLine();

            Console.WriteLine("Enter The Choosen Bed(PropNum):");
            string BedPropNum = Console.ReadLine();

            Console.WriteLine("Enter The Choosen Closet(PropNum):");
            string ClosetPropNum = Console.ReadLine();

            OwnerStudent.StEquipment.Add(FindEquipmentByPropNum(RefrigeratorPropNum));
            OwnerStudent.StEquipment.Add(FindEquipmentByPropNum(TablePropNum));
            OwnerStudent.StEquipment.Add(FindEquipmentByPropNum(ChairPropNum));
            OwnerStudent.StEquipment.Add(FindEquipmentByPropNum(BedPropNum));
            OwnerStudent.StEquipment.Add(FindEquipmentByPropNum(ClosetPropNum));
            Console.WriteLine('\n');
            Console.WriteLine($"Equipments Successfuly Allocated To {OwnerStudent.Name} {OwnerStudent.Family}");
        }





        public static void ManagingTheMovementOfEquipment()
        {
            Console.Clear();
            Console.WriteLine("1: Add Movment Of Equipment Between Rooms");
            Console.WriteLine("2: Add Replacement Of Student Equipment");
            Console.WriteLine('\n');
            Console.Write("Please Enter Number Option :");
            int EquipmenManagingTheMovementOfEquipmentNumberOption = 0;

            try
            {
                EquipmenManagingTheMovementOfEquipmentNumberOption = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
                Equipmentmanagment = true;

                while (Equipmentmanagment)
                {

                    Program.MainMenu(ref Equipmentmanagment);

                }
            }
            switch (EquipmenManagingTheMovementOfEquipmentNumberOption)
            {
                case 1:
                    AddMovmentOfEquipmentBetweenRooms();


                    break;

                case 2:
                    AddReplacementOfStudentEquipment();

                    break;
            }
        }
        public static void AddMovmentOfEquipmentBetweenRooms()
        {
            Console.Clear();
        }
        public static void AddReplacementOfStudentEquipment()
        {
            Console.Clear();
        }





        public static void FixingManagment()
        {
            Console.Clear();
            Console.WriteLine("1: Add Fixing Request Through Part Number ");
            Console.WriteLine("2: Tracking The Status Of Fixing");
            Console.WriteLine("3: Add Defective Equipment");
            Console.WriteLine('\n');
            Console.Write("Please Enter Number Of Option :");
            int EquipmenFixingManagmentNumberOption = 0;

            try
            {
                EquipmenFixingManagmentNumberOption = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
                Equipmentmanagment = true;

                while (Equipmentmanagment)
                {

                    Program.MainMenu(ref Equipmentmanagment);

                }
            }
            switch (EquipmenFixingManagmentNumberOption)
            {
                case 1:
                    AddFixingRequestThroughPartNumber();

                    break;

                case 2:
                    TrackingTheStatusOfFixing();
                    break;
                case 3:
                    AddDefectiveEquipment();
                    break;
            }
        }
        public static void AddFixingRequestThroughPartNumber()
        {
            Console.Clear();
        }
        public static void TrackingTheStatusOfFixing()
        {
            Console.Clear();
        }
        public static void AddDefectiveEquipment()
        {
            Console.Clear();
        }
    }
}

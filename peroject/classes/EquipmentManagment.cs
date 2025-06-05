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
           
            long HelpPropNum = 10000 +EquipmentsCount ;

            string PropNum = $"{HelpPropNum}{PartNumber}";
            

            Equipment NewEquipment = new Equipment(Type , PartNumber , PropNum);
            EquipmentsCount++;
            Lists.EquipmentsList.Add(NewEquipment);
            Console.WriteLine("Equipment Added Successfuly");
            Console.WriteLine('\n');


            Console.WriteLine("List:");
            Console.WriteLine("\n");
            for (int j = 0; j < Lists.EquipmentsList.Count; j++)
            {
                Console.WriteLine($"{j+1}: {Lists.EquipmentsList[j].EqType} , {Lists.EquipmentsList[j].PartNumber} , {Lists.EquipmentsList[j].PropNum} ");
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
                else
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
            Console.WriteLine("1: Choose Desired Room");
            Console.WriteLine("2: Allocating Equipment To Room");
            Console.WriteLine('\n');
            Console.Write("Please Enter Number Of Option :");
            int EquipmenAllocatingRoomNumberOption = 0;

            try
            {
                EquipmenAllocatingRoomNumberOption = Convert.ToInt32(Console.ReadLine());
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
            switch (EquipmenAllocatingRoomNumberOption)
            {
                case 1:
                    ChooseDesiredRoom();

                    break;

                case 2:
                    AllocatingEquipmentToRoom();

                    break;
            }
        }
        public static void ChooseDesiredRoom()
        {
            Console.Clear();
        }
        public static void AllocatingEquipmentToRoom()
        {
            Console.Clear();
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

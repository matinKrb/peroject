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
        public static void AddEquipmentMenu()
        {
            Console.Clear();
            Console.WriteLine("1: Add New Equipment With All Info");
            Console.WriteLine("2: Allocation Equipment Uniq Number And Part Number ");
            Console.WriteLine('\n');
            Console.Write("Please Enter Number Of Option :");
            int EquipmenAddtNumberOption = 0;

            try
            {
                EquipmenAddtNumberOption = Convert.ToInt32(Console.ReadLine());
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
            switch (EquipmenAddtNumberOption)
            {
                case 1:
                    AddNewEquipmentWithAllInfo();
                    break;

                case 2:
                    AllocationEquipmentUniqNumberAndPartNumber();
                    break;
            }

        }
        public static void AddNewEquipmentWithAllInfo()
        {
            Console.Clear();
            Console.WriteLine("Please Enter Type Of Equipment :");
            Console.WriteLine("Please Enter Part Number :");
            Console.WriteLine("Please Enter Equipment Number :");
        }
        public static void AllocationEquipmentUniqNumberAndPartNumber()
        {
            Console.Clear();

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






        public static void AllocatingEquipmentToStudentMenu()
        {
            Console.Clear();
            Console.WriteLine("1: Choose Desired Student");
            Console.WriteLine("2: Allocating Personal Equipment To Student");
            Console.WriteLine('\n');
            Console.Write("Please Enter Number Of Option :");
            int EquipmenAllocatingStudentNumberOption = 0;

            try
            {
                EquipmenAllocatingStudentNumberOption = Convert.ToInt32(Console.ReadLine());
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
            switch (EquipmenAllocatingStudentNumberOption)
            {
                case 1:
                    ChooseDesiredStudent();

                    break;

                case 2:
                    AllocatingPersonalEquipmentToStudent();

                    break;
            }
        }
        public static void ChooseDesiredStudent()
        {
            Console.Clear();
        }
        public static void AllocatingPersonalEquipmentToStudent()
        {
            Console.Clear();
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

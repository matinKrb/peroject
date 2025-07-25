﻿using System;
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
            Console.WriteLine("5: Fixing Management ");
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
            Console.WriteLine("Equipment Added Successfully");
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
            Console.WriteLine("Now You Should Choose Block From The List Below ");
            for (int i = 0; i < FoundHostel.BlockList.Count; i++)
            {
                Console.WriteLine($"{i + 1}:{FoundHostel.BlockList[i].BlockName}");
                Console.WriteLine();
            }

            Console.Write("Please Enter The Block Name Wich You Wanna Manage Its Equipment :");
            string BlockName = Console.ReadLine();

            Block FoundBlock = Block.FindBlockByName(BlockName, FoundHostel);
            Console.WriteLine("Now You Should Choose Room From The List Below ");
            for (int i = 0; i < FoundBlock.BlockRoomsList.Count; i++)
            {
                Console.WriteLine($"{i + 1}:Room {FoundBlock.BlockRoomsList[i].roomNum}");
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
            Room FoundRoom = Room.FindRoomByRoomNumber(RoomNum, FoundBlock);
            Console.WriteLine('\n');
            Console.WriteLine("Now You Should Choose Equipments From The List Below ");
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
            Console.WriteLine($"Equipments Successfully Allocated To Room {FoundRoom.roomNum}");
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

            Console.WriteLine("Now You Should Choose Equipments From The List Below ");
            Console.WriteLine('\n');
            for (int j = 0; j < Lists.EquipmentsList.Count; j++)
            {
                Console.WriteLine($"{j + 1}: {Lists.EquipmentsList[j].EqType} , {Lists.EquipmentsList[j].PartNumber} , {Lists.EquipmentsList[j].PropNum} ");
            }

            Console.WriteLine('\n');

            Console.WriteLine("Enter The Choosen Refrigerator(PropNum):");
            string RefrigeratorPropNum = Console.ReadLine();
            OwnerStudent.StEquipment.Add(FindEquipmentByPropNum(RefrigeratorPropNum));


            Console.WriteLine("Enter The Choosen Table(PropNum):");
            string TablePropNum = Console.ReadLine();
            OwnerStudent.StEquipment.Add(FindEquipmentByPropNum(TablePropNum));


            Console.WriteLine("Enter The Choosen Chair(PropNum):");
            string ChairPropNum = Console.ReadLine();
            OwnerStudent.StEquipment.Add(FindEquipmentByPropNum(ChairPropNum));


            Console.WriteLine("Enter The Choosen Bed(PropNum):");
            string BedPropNum = Console.ReadLine();
            OwnerStudent.StEquipment.Add(FindEquipmentByPropNum(BedPropNum));


            Console.WriteLine("Enter The Choosen Closet(PropNum):");
            string ClosetPropNum = Console.ReadLine();
            OwnerStudent.StEquipment.Add(FindEquipmentByPropNum(ClosetPropNum));


            Console.WriteLine('\n');
            Console.WriteLine($"Equipments Successfully Allocated To {OwnerStudent.Name} {OwnerStudent.Family}");
            Console.WriteLine("Press Any Button");
            Console.ReadKey();
        }




        //******************************************************************
        public static void ManagingTheMovementOfEquipment()
        {
            Console.Clear();
            Console.WriteLine("1: Replacement Of Equipment Between Rooms");
            Console.WriteLine("2: Replacement Of Student Equipment");
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
                    ReplacmentOfEquipmentBetweenRooms();


                    break;

                case 2:
                    ReplacementOfStudentEquipment();

                    break;
            }
        }
        public static void ReplacmentOfEquipmentBetweenRooms()
        {
            Console.Clear();
            Console.WriteLine("Ok! Now We Have To Choose Two Rooms For Replacing Their Equipments.");
            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
            Console.WriteLine("First Of All You should Choose The Hostel Of First Room From The List Below:");
            Console.WriteLine('\n');

            for (int i = 0; i < Lists.HostelList.Count; i++)
            {
                Console.WriteLine($"1: {Lists.HostelList[i].Name}");
            }
            Console.WriteLine('\n');

            Console.Write("Please Enter The Name Of First Hostel:");
            string FirstHostelName = Console.ReadLine();
            Hostel FirstHostel = Hostel.FindHostelByName(FirstHostelName);

            Console.Clear();
            Console.WriteLine("Ok Now You Should Choose The First Block From The List Below: ");
            Console.WriteLine('\n');

            for (int i = 0; i < FirstHostel.BlockList.Count; i++)
            {
                Console.WriteLine($"1: {FirstHostel.BlockList[i].BlockName}");
            }
            Console.WriteLine('\n');

            Console.Write("Please Enter The Name Of First Block:");
            string FirstBlockName = Console.ReadLine();
            Block FirstBlock = Block.FindBlockByName(FirstBlockName, FirstHostel);

            Console.Clear();
            Console.WriteLine("And Finally You Should Choose First Room From The List Below:");
            Console.WriteLine('\n');

            for (int i = 0; i < FirstBlock.BlockRoomsList.Count; i++)
            {
                Console.WriteLine($"1: {FirstBlock.BlockRoomsList[i].roomNum}");
            }
            Console.WriteLine('\n');

            Console.Write("Please Enter The Room Number:");

            int FirstRoomNum = 0;

            try
            {
                FirstRoomNum = int.Parse(Console.ReadLine());
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

            Room FirstRoom = Room.FindRoomByRoomNumber(FirstRoomNum, FirstBlock);
            Console.WriteLine();
            Console.WriteLine("First Room Successfully Detected!");

            Console.Clear();
            Console.WriteLine("Now You should Choose The Hostel Of Second Room From The List Below:");
            Console.WriteLine('\n');

            for (int i = 0; i < Lists.HostelList.Count; i++)
            {
                Console.WriteLine($"1: {Lists.HostelList[i].Name}");
            }
            Console.WriteLine('\n');

            Console.Write("Please Enter The Name Of Second Hostel:");
            string SecondHostelName = Console.ReadLine();
            Hostel SecondHostel = Hostel.FindHostelByName(SecondHostelName);

            Console.Clear();
            Console.WriteLine("Ok Now You Should Choose The Second Block From The List Below: ");
            Console.WriteLine('\n');

            for (int i = 0; i < SecondHostel.BlockList.Count; i++)
            {
                Console.WriteLine($"1: {SecondHostel.BlockList[i].BlockName}");
            }
            Console.WriteLine('\n');

            Console.Write("Please Enter The Name Of Second Block:");
            string SecondBlockName = Console.ReadLine();
            Block SecondBlock = Block.FindBlockByName(SecondBlockName, SecondHostel);


            Console.Clear();
            Console.WriteLine("And Finally You Should Choose Second Room From The List Below:");
            Console.WriteLine('\n');

            for (int i = 0; i < SecondBlock.BlockRoomsList.Count; i++)
            {
                Console.WriteLine($"1: {SecondBlock.BlockRoomsList[i].roomNum}");
            }
            Console.WriteLine('\n');

            Console.Write("Please Enter The Room Number:");

            int SecondRoomNum = 0;

            try
            {
                SecondRoomNum = int.Parse(Console.ReadLine());
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

            Room SecondRoom = Room.FindRoomByRoomNumber(SecondRoomNum, SecondBlock);
            Console.WriteLine();
            Console.WriteLine("Second Room Successfully Detected!");
            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Now You Should Choose First Equipment From Firs Room To Transfer To second Room ");
            Console.WriteLine("Firs Room Equipments List:");
            Console.WriteLine('\n');
            for (int j = 0; j < FirstRoom.RoomEq.Count; j++)
            {
                Console.WriteLine($"{j + 1}: Type: {FirstRoom.RoomEq[j].EqType} , Part Number: {FirstRoom.RoomEq[j].PartNumber} , Property Number: {FirstRoom.RoomEq[j].PropNum} ");
            }

            Console.WriteLine('\n');
            Console.Write("Please Enter The PropNumber Of Equipment:");
            string FirstPropNum = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Now You Should Choose Second Equipment From Second Room To Transfer To First Room");
            Console.WriteLine('\n');

            Console.WriteLine("Second Room Equipments List:");
            Console.WriteLine('\n');
            for (int j = 0; j < SecondRoom.RoomEq.Count; j++)
            {
                Console.WriteLine($"{j + 1}: Type: {SecondRoom.RoomEq[j].EqType} , Part Number: {SecondRoom.RoomEq[j].PartNumber} , Property Number: {SecondRoom.RoomEq[j].PropNum} ");
            }
            Console.WriteLine('\n');

            Console.WriteLine("Pay Attention!!!");
            Console.WriteLine("Type Of First Equipment And Second Equipment Must Be Same!");
            Console.WriteLine();
            Console.WriteLine("Please Enter The PropNumber Of Second Equipment:");
            string SecondPropNum = Console.ReadLine();

            EquipmentsReplacment(FirstPropNum, SecondPropNum);
            Console.WriteLine('\n');
            Console.WriteLine("Equipments Replaced Successfully");

        }

        public static void EquipmentsReplacment(string FirstPropNum, string SecondPropNum)
        {
            Equipment FirstEquipment = FindEquipmentByPropNum(FirstPropNum);
            Equipment SecondEquipment = FindEquipmentByPropNum(SecondPropNum);
            Equipment Temp = null;

            Temp = FirstEquipment;
            FirstEquipment = SecondEquipment;
            SecondEquipment = Temp;

        }
        public static void ReplacementOfStudentEquipment()
        {
            Console.Clear();
            Console.WriteLine("First Of All You Should Choose Two Students Who You Wanna Replace Their Equipments");
            Console.WriteLine('\n');
            Console.Write("please Enter The Student Id Of First Student:");
            long FirstStudentId = 0;

            try
            {
                FirstStudentId = Convert.ToInt64(Console.ReadLine());
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

            Student FirstStudent = Student.FindStudentByStudentId(FirstStudentId);
            Console.WriteLine('\n');


            Console.Clear();
            Console.Write("Now please Enter The Student Id Of Second Student:");
            long SecondStudentId = 0;

            try
            {
                SecondStudentId = Convert.ToInt64(Console.ReadLine());
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

            Student SecondStudent = Student.FindStudentByStudentId(SecondStudentId);
            Console.WriteLine('\n');

            Console.Clear();
            Console.WriteLine("Now You Should Choose First Equipment From First Student From The List Below");
            Console.WriteLine('\n');
            Console.WriteLine("Equipments Of First Student List:");
            Console.WriteLine('\n');
            for (int i = 0; i < FirstStudent.StEquipment.Count; i++)
            {
                Console.WriteLine($"{i + 1}: Type: {FirstStudent.StEquipment[i].EqType} , PropNumber: {FirstStudent.StEquipment[i].PropNum}");
            }

            Console.WriteLine('\n');
            Console.Write("Please Enter The Prop Number Of First Equipment: ");
            string FirstPropNum = Console.ReadLine();


            Console.Clear();
            Console.WriteLine("Now You Should Choose Second Equipment From Second Student From The List Below");
            Console.WriteLine('\n');
            Console.WriteLine("Equipments Of Second Student List:");
            Console.WriteLine('\n');
            for (int i = 0; i < SecondStudent.StEquipment.Count; i++)
            {
                Console.WriteLine($"{i + 1}: Type: {SecondStudent.StEquipment[i].EqType} , PropNumber: {SecondStudent.StEquipment[i].PropNum}");
            }

            Console.WriteLine('\n');
            Console.WriteLine("Pay Attention!!!");
            Console.WriteLine("Type Of First Equipment And Second Student Must Be Same!");
            Console.WriteLine();
            Console.Write("Please Enter The Prop Number Of second Equipment: ");
            string SecondPropNum = Console.ReadLine();

            EquipmentsReplacment(FirstPropNum, SecondPropNum);
            Console.WriteLine("Equipments Replaced Successfully");

        }





        public static void FixingManagment()
        {
            Console.Clear();
            Console.WriteLine("1: Add Fixing Request Through Part Number ");
            Console.WriteLine("2: Tracking The Status Of Fixing");
            Console.WriteLine("3: Add Defective Equipment");
            Console.WriteLine("4: Change The Status Of Fixed Equipment");
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
                case 4:
                    ChangeTheStatusOfFixedEquipment();
                    break;
            }
        }
        //*****************************************************************************
        public static void AddFixingRequestThroughPartNumber()
        {
            Console.Clear();
            if (Lists.DefectiveEquipment.Count > 0)
            {
                Console.Write("Please Enter Your Student Id :");
                long FixingRequestStudentId = 0;

                try
                {
                    FixingRequestStudentId = Convert.ToInt64(Console.ReadLine());
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

                Console.WriteLine("Please Enter Any Button To Show Defective Equipment List !");
                Console.ReadKey();
                for (int j = 0; j < Lists.DefectiveEquipment.Count; j++)
                {
                    Console.WriteLine($"{j + 1}: {Lists.DefectiveEquipment[j].EqType} , {Lists.DefectiveEquipment[j].PartNumber} , {Lists.DefectiveEquipment[j].PropNum} ");
                }

                Console.Write("Please Enter The Prop Number Of Equipment Wich You Wanna Request For Fixing :");
                string FixingEquipmentPropNum = Console.ReadLine();
                Equipment FoundFixingEquipmentPropNum = FindDefectiveEquipmentByPropNum(FixingEquipmentPropNum);
                Lists.FixingEquipments.Add(FoundFixingEquipmentPropNum);
                FoundFixingEquipmentPropNum.Status = "Fixing";
                Lists.DefectiveEquipment.Remove(FoundFixingEquipmentPropNum);
                Student FoundedStudentRequst = Student.FindStudentByStudentId(FixingRequestStudentId);
                ReportFixingRequest NewRequste = new ReportFixingRequest(FoundedStudentRequst, FoundFixingEquipmentPropNum);
                Lists.reportFixingRequestsList.Add(NewRequste);
                Console.WriteLine('\n');
                Console.WriteLine("Your Request Register Is Successfully");
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The List Of Defective Equipment Is Empty!");
                Console.WriteLine("Press Any Button ");
                Console.ReadKey();

                Equipmentmanagment = true;

                while (Equipmentmanagment)
                {

                    Program.MainMenu(ref Equipmentmanagment);

                }
            }
        }

        //*************************************************************
        public static void TrackingTheStatusOfFixing()
        {
            Console.Clear();
            if (Lists.FixingEquipments.Count > 0 || Lists.DefectiveEquipment.Count > 0)
            {
                Console.WriteLine("Please Enter Any Button To Show Equipment List !");
                Console.ReadKey();
                int k = 1;
                for (int j = 0; j < Lists.FixingEquipments.Count; j++)
                {
                    Console.WriteLine($"{k}: {Lists.FixingEquipments[j].EqType} , {Lists.FixingEquipments[j].PartNumber} , {Lists.FixingEquipments[j].PropNum} ");
                    k++;
                }

                for (int j = 0; j < Lists.DefectiveEquipment.Count; j++)
                {
                    Console.WriteLine($"{k}: {Lists.DefectiveEquipment[j].EqType} , {Lists.DefectiveEquipment[j].PartNumber} , {Lists.DefectiveEquipment[j].PropNum} ");
                    k++;
                }
                Console.WriteLine('\n');
                Console.Write("Please Enter The Prop Number Of Equipment Wich You Wanna Track Its Fixing Status :");
                string TrackFixingEquipmentPropNum = Console.ReadLine();
                Console.WriteLine('\n');

                Equipment TrackFoundFixingEquipment = FindDFixingEquipmentByPropNum(TrackFixingEquipmentPropNum);
                if (TrackFoundFixingEquipment == null)
                {
                    Equipment TrackFoundDefectiveEquipment = FindDefectiveEquipmentByPropNum(TrackFixingEquipmentPropNum);
                    if (TrackFoundDefectiveEquipment.Status == "Fixing" && TrackFoundFixingEquipment != null)
                    {
                        Console.WriteLine("The Equipment Is Being Fixing");
                    }
                    else if (TrackFoundDefectiveEquipment.Status == "Intact" && TrackFoundFixingEquipment != null)
                    {
                        Console.WriteLine("The Equipment Is Intact");
                    }
                    else if (TrackFoundDefectiveEquipment.Status == "Defective")
                    {
                        Console.WriteLine("The Equipment Is Defective");
                    }
                }
                else
                {

                    Console.WriteLine('\n');
                    if (TrackFoundFixingEquipment.Status == "Fixing")
                    {
                        Console.WriteLine("The Equipment Is Being Fixing");
                    }
                    else if (TrackFoundFixingEquipment.Status == "Intact")
                    {
                        Console.WriteLine("The Equipment Is Intact");
                    }
                    else if (TrackFoundFixingEquipment.Status == "Defective")
                    {
                        Console.WriteLine("The Equipment Is Defective");
                    }
                }
                Console.WriteLine('\n');
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The List Of Fixing Equipment Is Empty!");
                Console.WriteLine("Press Any Button ");
                Console.ReadKey();

                Equipmentmanagment = true;

                while (Equipmentmanagment)
                {

                    Program.MainMenu(ref Equipmentmanagment);

                }
            }
        }

        //***********************************************************************8
        public static void AddDefectiveEquipment()
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
                Console.Write("Please Enter The Prop Number Of Equipment Wich Is Defective :");
                string FoundEquipmentPropNum = Console.ReadLine();
                Equipment FoundDefectiveEquipment = FindEquipmentByPropNum(FoundEquipmentPropNum);
                Lists.DefectiveEquipment.Add(FoundDefectiveEquipment);

                FoundDefectiveEquipment.Status = "Defective";
                Console.WriteLine('\n');
                Console.WriteLine("Register Equipment Was Successfully");
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The List Of Equipment Is Empty!");
                Console.WriteLine("Press Any Button ");
                Console.ReadKey();

                Equipmentmanagment = true;

                while (Equipmentmanagment)
                {

                    Program.MainMenu(ref Equipmentmanagment);

                }
            }
        }

        //***********************************************************************
        public static Equipment FindDefectiveEquipmentByPropNum(string propnum)
        {
            Equipment Result = null;
            for (int i = 0; i < Lists.DefectiveEquipment.Count; i++)
            {
                if (Lists.DefectiveEquipment[i].PropNum == propnum)
                {
                    Result = Lists.DefectiveEquipment[i];
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

        //**********************************************************************************
        public static Equipment FindDFixingEquipmentByPropNum(string propnum)
        {
            Equipment Result = null;
            for (int i = 0; i < Lists.FixingEquipments.Count; i++)
            {
                if (Lists.FixingEquipments[i].PropNum == propnum)
                {
                    Result = Lists.FixingEquipments[i];
                }

            }

            return Result;

        }
        //**********************************************************************************************
        public static void ChangeTheStatusOfFixedEquipment()
        {
            Console.Clear();
            if (Lists.FixingEquipments.Count > 0)
            {
                Console.WriteLine("Please Enter Any Button To Show Fixing Equipment List !");
                Console.ReadKey();
                for (int j = 0; j < Lists.FixingEquipments.Count; j++)
                {
                    Console.WriteLine($"{j + 1}: {Lists.FixingEquipments[j].EqType} , {Lists.FixingEquipments[j].PartNumber} , {Lists.FixingEquipments[j].PropNum} ");
                }
                Console.WriteLine('\n');
                Console.Write("Please Enter The Prop Number Of Equipment Wich You Wanna To Change Its Status : ");
                string ChangeStatusEquipmentPropNum = Console.ReadLine();
                Equipment FoundedChangeStatusEquipmentPropNum = FindDFixingEquipmentByPropNumBaVogodelse(ChangeStatusEquipmentPropNum);
                FoundedChangeStatusEquipmentPropNum.Status = "Intact";
                Console.WriteLine("Change Of Equipment Status Is Successfully");
            }
            else
            {
                Console.WriteLine("The List Of Fixing Equipment Is Empty!");
                Console.WriteLine("Press Any Button ");
                Console.ReadKey();

                Equipmentmanagment = true;

                while (Equipmentmanagment)
                {

                    Program.MainMenu(ref Equipmentmanagment);

                }
            }
            Console.WriteLine('\n');
            Console.WriteLine("Perss Any Button");
            Console.ReadKey();
        }

        //**************************************************************************
        public static Equipment FindDFixingEquipmentByPropNumBaVogodelse(string propnum)
        {
            Equipment Result = null;
            for (int i = 0; i < Lists.FixingEquipments.Count; i++)
            {
                if (Lists.FixingEquipments[i].PropNum == propnum)
                {
                    Result = Lists.FixingEquipments[i];
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

    }
}

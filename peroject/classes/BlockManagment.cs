using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class BlockManagment
    {
        public static bool BlockManagmentMainMenu = true;

        public static Hostel ChoosenHostel = null;

        public static void BlockManagmentMenu()
        {
            if (Lists.HostelList.Count > 0)
            {
                Console.WriteLine("List Of Hostels :");
                Console.WriteLine("\n");
                for (int i = 0; i < Lists.HostelList.Count; i++)
                {
                    Console.WriteLine($"{i + 1} : {Lists.HostelList[i].Name}");

                }
                Console.WriteLine('\n');
                Console.Write("Please Enter The Name Of Hostel Wich You Want To Manage Its Blocks :");
                string name = Console.ReadLine();
                Console.WriteLine('\n');

                ChoosenHostel = Hostel.FindHostelByName(name);
            }
            else
            {
                Console.WriteLine("List Of Hostel Is Empty");
                Console.WriteLine("Press Any Button!");
                Console.ReadKey();
            }

            if (ChoosenHostel != null)
            {
                Console.WriteLine("Entering Hostel Successfully");
                Console.WriteLine("Press Any Button!");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("1 : Add A New Block");
                Console.WriteLine("2 : Remove A Block");
                Console.WriteLine("3 : Edit A Block");
                Console.WriteLine("4 : Displsy Blocks List Of This Hostel");
                Console.WriteLine("5 : Manage Rooms");
                Console.WriteLine("\n");

                Console.Write("Please Enter The Option Number :");

                int DisplayBlockManagmentOption = 0;

                try
                {
                    DisplayBlockManagmentOption = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Press Any Button");
                    Console.ReadKey();
                    BlockManagmentMainMenu = true;

                    while (BlockManagmentMainMenu)
                    {

                        Program.MainMenu(ref BlockManagmentMainMenu);

                    }
                }

                switch (DisplayBlockManagmentOption)
                {
                    case 1:
                        AddBlock(ChoosenHostel);
                        break;

                    case 2:
                        RemoveBlock(ChoosenHostel);
                        break;

                    case 3:
                        EditBlock(ChoosenHostel);
                        break;

                    case 4:
                        DisplayBlocksOfHostel(ChoosenHostel);
                        break;

                    case 5:
                        RooomManagment.RoomManagmentMenu(ChoosenHostel);
                        break;
                }
            }
        }
        public static void AddBlock(Hostel choosenhostel)
        {
            Console.Clear();

            Console.Write("Please Enter The Block Name :");
            string name = Console.ReadLine();
            Console.Write("Please Enter Floors Count :");
            int FloorsCount = 0;

            try
            {
                FloorsCount = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
                BlockManagmentMainMenu = true;

                while (BlockManagmentMainMenu)
                {

                    Program.MainMenu(ref BlockManagmentMainMenu);

                }
            }
            Console.Write("Please Enter Rooms Count :");
            int RoomsCount = 0;

            try
            {
                RoomsCount = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
                BlockManagmentMainMenu = true;

                while (BlockManagmentMainMenu)
                {

                    Program.MainMenu(ref BlockManagmentMainMenu);

                }
            }

            if (Lists.blockManagersList.Count > 0)
            {
                Console.WriteLine('\n');
                Console.WriteLine("List Of Block Managers With Studet Id Is : ");
                Console.WriteLine('\n');

                for (int i = 0; i < Lists.blockManagersList.Count; i++)
                {
                    Console.WriteLine($"{Lists.blockManagersList[i].Family} , {Lists.blockManagersList[i].StudentId}");
                }
                Console.WriteLine('\n');
                Console.Write("Please Enter The Student Id Who You Want To Choose For Managing Block :");

                long StudentId = 0;
                try
                {
                    StudentId = Convert.ToInt64(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Press Any Button");
                    Console.ReadKey();
                    BlockManagmentMainMenu = true;

                    while (BlockManagmentMainMenu)
                    {
                        Program.MainMenu(ref BlockManagmentMainMenu);
                    }
                }

                BlockManager BlockManagerToManage = BlockManager.FindBlockManagerByStudentId(StudentId);

                if (BlockManagerToManage !=null)
                {
                    Block NewBlock = new Block(name, FloorsCount, RoomsCount, BlockManagerToManage, choosenhostel);

                    choosenhostel.BlockList.Add(NewBlock);
                    Console.WriteLine('\n');
                    Console.WriteLine("Block Added Successfuly");
                    Console.WriteLine("\n");
                    Console.WriteLine("Press Any Button!");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("List Of Block Manager Is Empty!");
                Console.WriteLine("Press Any Button!");
                Console.ReadKey();
            }
        }
        public static void RemoveBlock(Hostel choosenhostel)
        {
            Console.Clear();
            if (choosenhostel.BlockList.Count > 0)
            {
                Console.WriteLine("List Of Blocks Is :");
                Console.WriteLine("\n");

                for (int i = 0; i < choosenhostel.BlockList.Count; i++)
                {
                    Console.WriteLine($"{i + 1} : {choosenhostel.BlockList[i].BlockName}");
                }
                Console.WriteLine("\n");

                Console.Write("Please Enter The Name Of Block Wich Want To Remove :");
                string name = Console.ReadLine();

                Block BlockToRemove = Block.FindBlockByName(name, choosenhostel);
                if (BlockToRemove != null)
                {
                    choosenhostel.BlockList.Remove(BlockToRemove);

                    Console.WriteLine("Block Removed Successfuly");

                }
            }
            else
            {
                Console.WriteLine("List Of Blocks From This Hostel Is Empty !");
            }
            Console.WriteLine('\n');
            Console.WriteLine("Press Any Button!");
            Console.ReadKey();

        }
        public static void EditBlock(Hostel choosenhostel)
        {
            Console.Clear();
            if (choosenhostel.BlockList.Count > 0)
            {
                Console.WriteLine("List Of Blocks From This Hostel :");
                Console.WriteLine("\n");
                for (int i = 0; i < choosenhostel.BlockList.Count; i++)
                {
                    Console.WriteLine($"{i + 1} : {ChoosenHostel.BlockList[i].BlockName}");
                }
                Console.WriteLine("\n");
                Console.Write("Please Enter The Name Of Block Wich You Want To Edit :");
                string BlockNameToEdit = Console.ReadLine();

                Block BlockToEdit = Block.FindBlockByName(BlockNameToEdit, ChoosenHostel);
                ChoosenHostel.BlockList.Remove(BlockToEdit);
                Console.WriteLine("\n");
                Console.Write("Please Enter The New Block Name :");
                string NewName = Console.ReadLine();
                Console.Write("Please Enter The New Floors Count :");
                int NewFloorsCount = 0;

                try
                {
                    NewFloorsCount = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Press Any Button");
                    Console.ReadKey();
                    BlockManagmentMainMenu = true;

                    while (BlockManagmentMainMenu)
                    {

                        Program.MainMenu(ref BlockManagmentMainMenu);

                    }
                }
                Console.Write("Please Enter The New Rooms Count :");
                int NewRoomsCount = 0;

                try
                {
                    NewRoomsCount = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Press Any Button");
                    Console.ReadKey();
                    BlockManagmentMainMenu = true;

                    while (BlockManagmentMainMenu)
                    {

                        Program.MainMenu(ref BlockManagmentMainMenu);

                    }
                }
                if (Lists.blockManagersList.Count > 0)
                {
                    Console.WriteLine('\n');
                    Console.WriteLine("List Of Block Managers With Studet Id Is : ");
                    Console.WriteLine('\n');

                    for (int i = 0; i < Lists.blockManagersList.Count; i++)
                    {
                        Console.WriteLine($"{Lists.blockManagersList[i].Family} , {Lists.blockManagersList[i].StudentId}");
                    }
                    Console.WriteLine('\n');
                    Console.Write("Please Enter The New Student Id Who You Want To Replace For Managing Block :");

                    long NewStudentId = 0;
                    try
                    {
                        NewStudentId = Convert.ToInt64(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Press Any Button");
                        Console.ReadKey();
                        BlockManagmentMainMenu = true;

                        while (BlockManagmentMainMenu)
                        {
                            Program.MainMenu(ref BlockManagmentMainMenu);
                        }
                    }
                    BlockManager NewBlockManagerToManage = BlockManager.FindBlockManagerByStudentId(NewStudentId);
                    if(NewBlockManagerToManage!=null)
                    {
                        Block ReplacedBlock = new Block(NewName, NewFloorsCount, NewRoomsCount, NewBlockManagerToManage, choosenhostel);
                        ChoosenHostel.BlockList.Add(ReplacedBlock);
                        Console.WriteLine('\n');
                        Console.WriteLine("Block Edited Successfuly");
                        Console.WriteLine("Press Any Button!");
                        Console.ReadKey();

                    }

                }

            }
            else
            {
                Console.WriteLine("List Of Blocks From This Hostel Is Empty ! ");
                Console.WriteLine("Press Any Button!");
                Console.ReadKey();
            }
        }
        public static void DisplayBlocksOfHostel(Hostel choosenhostel)
        {
            Console.Clear();
            if (choosenhostel.BlockList.Count>0)
            {
                Console.WriteLine("List Of Blocks From This Hostel :");
                Console.WriteLine('\n');
                for (int i = 0; i < choosenhostel.BlockList.Count; i++)
                {
                    Console.WriteLine($"{i+1} : {choosenhostel.BlockList[i].BlockName}");
                }
                Console.WriteLine('\n');
                Console.WriteLine("Press Any Button!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("List Of Blocks From This Hostel Is Empty ! ");
                Console.WriteLine("Press Any Button!");
                Console.ReadKey();
            }
        }
    }
}

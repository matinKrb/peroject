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


        public static void BlockManagmentMenu()
        {
            Hostel ChoosenHostel = null;
            if (Lists.HostelList.Count>0)
            {
                Console.WriteLine("List Of Hostels :");
                Console.WriteLine("\n");
                for (int i = 0; i < Lists.HostelList.Count; i++)
                {
                    Console.WriteLine($"{i + 1} : {Lists.HostelList[i].Name}");

                }
                Console.Write("Please Enter The Name Of Hostel Wich You Want To Manage Its Blocks :");
                string name = Console.ReadLine();

                ChoosenHostel = Hostel.FindHostelByName(name);


                Console.WriteLine("Entering Hostel Successfully");
                Console.WriteLine("Press Any Button!");
                Console.ReadKey();
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("List Of Hostel Is Empty");
                Console.WriteLine("Press Any Button!");
                Console.ReadKey();
            }

            if (ChoosenHostel != null) 
            {

                Console.WriteLine("1 : Add A New Block");
                Console.WriteLine("2 : Remove A Block");
                Console.WriteLine("3 : Edit A Block");
                Console.WriteLine("4 : Add A New Block");
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
                        RemoveBlock();
                        break;

                    case 3:
                        break;

                    case 4:
                        break;
                }
            }
            //else
            //{
            //    while (true) 
            //    {
            //        Program.MainMenu();
            //    }
            //}

        }

        public static void AddBlock(Hostel choosenhostel)
        {
            Console.Clear();

            Console.WriteLine("Please Enter The Block Name");
            string name = Console.ReadLine();
            Console.WriteLine("Please Enter Floors Count");
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
            Console.WriteLine("Please Enter Rooms Count");
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
                Console.WriteLine("List Of Block Managers With Studet Id Is : ");

                for (int i = 0; i < Lists.blockManagersList.Count; i++)
                {
                    Console.WriteLine($"{Lists.blockManagersList[i].Family} , {Lists.blockManagersList[i].StudentId}");
                }

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

                Block NewBlock = new Block(name, FloorsCount, RoomsCount, BlockManagerToManage, choosenhostel);

                Hostel.BlockList.Add(NewBlock);
                Console.WriteLine("Block Added Successfuly");
                Console.WriteLine("Press Any Button!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("List Of Block Manager Is Empty!");
                Console.WriteLine("Press Any Button!");
                Console.ReadKey();
            }
        }
        public static void RemoveBlock() 
        {
            Console.Clear();
            Console.WriteLine("List Of Blocks Is :");
            Console.WriteLine("\n");

            for (int i = 0; i < Hostel.BlockList.Count; i++)
            {
                Console.WriteLine($"{i+1} : {Hostel.BlockList[i].BlockName}");
            }
            Console.WriteLine("\n");

            Console.Write("Please Enter The Name Of Block Wich Want To Remove :");
            string name = Console.ReadLine();

            Block BlockToRemove = Block.FindBlockByName(name);
            if (BlockToRemove != null) 
            {
                Hostel.BlockList.Remove(BlockToRemove);

                Console.WriteLine("Block Removed Successfuly");

            }
            Console.WriteLine("Press Any Button!");
            Console.ReadKey();

        }


    }
}

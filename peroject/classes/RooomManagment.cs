using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class RooomManagment
    {
        public static bool RoomManagmentMainMenu = true;

        public static void RoomManagmentMenu(Hostel choosenhostel)
        {
            Console.Clear();
            if (choosenhostel.BlockList.Count > 0)
            {
                Console.WriteLine("List Of Blocks :");
                for (int i = 0; i < choosenhostel.BlockList.Count; i++)
                {
                    Console.WriteLine($"{i + 1} : {choosenhostel.BlockList[i].BlockName}");
                }
                Console.WriteLine('\n');
                Console.Write("Please Enter The Name Of Block Wich You Want To Manage Its Rooms :");
                string BlockNameToManageItsRooms = Console.ReadLine();

                Block BlockToManageItsRoom = Block.FindBlockByName(BlockNameToManageItsRooms, choosenhostel);

                if (BlockToManageItsRoom != null)
                {
                    Console.WriteLine("Entering Block Successfully");
                    Console.WriteLine("Press Any Button!");
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("1 : Define The Block Rooms");
                    Console.WriteLine("2 : Remove A Room");
                    Console.WriteLine("3 : Edit A Room");
                    Console.WriteLine("4 : Displsy Rooms List Of This Block");
                    Console.WriteLine("\n");

                    Console.Write("Please Enter The Option Number :");

                    int DisplayRoomManagmentOption = 0;

                    try
                    {
                        DisplayRoomManagmentOption = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Press Any Button");
                        Console.ReadKey();
                        RoomManagmentMainMenu = true;

                        while (RoomManagmentMainMenu)
                        {

                            Program.MainMenu(ref RoomManagmentMainMenu);

                        }
                    }

                    switch (DisplayRoomManagmentOption)
                    {
                        case 1:
                            DefineRoom(BlockToManageItsRoom);
                            break;

                        case 2:
                            RemoveRoom(BlockToManageItsRoom);
                            break;

                        case 3:
                            EditRoom(BlockToManageItsRoom);
                            break;

                        case 4:
                            DisplayRoom(BlockToManageItsRoom);
                            break;

                        case 5:
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("List Of Blocks From This Hostel Is Empty !");
            }

        }
        public static void DefineRoom(Block blocktomanageitsroom)
        {
            Console.Clear();
            if (blocktomanageitsroom.blockRoom > 0)
            {
                Console.WriteLine($"This Block Has {blocktomanageitsroom.blockRoom} Rooms");
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
                for (int i = 0; i < blocktomanageitsroom.blockRoom; i++)
                {
                    Console.Clear();

                    Console.WriteLine($"Defining Room {i + 1} :");

                    Console.Write("Please Enter The Room Number :");

                    int RoomNumber = 0;

                    try
                    {
                        RoomNumber = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Press Any Button");
                        Console.ReadKey();
                        RoomManagmentMainMenu = true;

                        while (RoomManagmentMainMenu)
                        {

                            Program.MainMenu(ref RoomManagmentMainMenu);

                        }
                    }

                    Console.Write("Please Enter The Floor Of Room :");
                    int RoomFloor = 0;

                    try
                    {
                        RoomFloor = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Press Any Button");
                        Console.ReadKey();
                        RoomManagmentMainMenu = true;

                        while (RoomManagmentMainMenu)
                        {

                            Program.MainMenu(ref RoomManagmentMainMenu);

                        }
                    }

                    Console.Write("Please Enter The Room Capacity :");
                    int RoomCapacity = 0;

                    try
                    {
                        RoomCapacity = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Press Any Button");
                        Console.ReadKey();
                        RoomManagmentMainMenu = true;

                        while (RoomManagmentMainMenu)
                        {

                            Program.MainMenu(ref RoomManagmentMainMenu);

                        }
                    }

                    Room NewRoom = new Room(RoomNumber, RoomFloor, RoomCapacity, blocktomanageitsroom);
                    blocktomanageitsroom.BlockRoomsList.Add(NewRoom);

                    if (NewRoom != null)
                    {
                        Console.WriteLine($"Room {i + 1} Definded Successfully !");
                        Console.WriteLine("Press Any Button !");
                        Console.ReadKey();
                    }
                    else
                    {
                        break;
                    }

                }
            }
            else
            {
                Console.WriteLine("This Block Dosent Have Any Room To Define !");
                Console.WriteLine("Press Any Button !");
                Console.ReadKey();
            }
        }

        public static void RemoveRoom(Block blocktomanageitsroom)
        {
            Console.Clear();
            if (blocktomanageitsroom.BlockRoomsList.Count > 0)
            {
                Console.WriteLine("List Of Rooms :");
                Console.WriteLine("\n");
                for (int i = 0; i < blocktomanageitsroom.BlockRoomsList.Count; i++)
                {
                    Console.WriteLine($"{i + 1} : Room {blocktomanageitsroom.BlockRoomsList[i].roomNum}");
                }
                Console.WriteLine('\n');
                Console.Write("Please Enter The Room Number Wich You Want To Delete :");
                int RoomNumberToRemove = 0;

                try
                {
                    RoomNumberToRemove = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Press Any Button");
                    Console.ReadKey();
                    RoomManagmentMainMenu = true;

                    while (RoomManagmentMainMenu)
                    {

                        Program.MainMenu(ref RoomManagmentMainMenu);

                    }
                }
                Room RoomToRemove = Room.FindRoomByRoomNumber(RoomNumberToRemove, blocktomanageitsroom);
                blocktomanageitsroom.BlockRoomsList.Remove(RoomToRemove);

                if (RoomToRemove != null)
                {
                    blocktomanageitsroom.blockRoom--;

                    Console.WriteLine("Room Removed Successfully");
                    Console.WriteLine("Press Any Button");
                    Console.ReadKey();

                }
            }
            else
            {
                Console.WriteLine("There Is No Any Definded Room To Remove !");
                Console.WriteLine("Press Any Button!");
            }
        }
        public static void EditRoom(Block blocktomanageitsroom)
        {
            Console.Clear();
            if (blocktomanageitsroom.BlockRoomsList.Count > 0)
            {
                Console.WriteLine("List Of Rooms :");
                Console.WriteLine("\n");
                for (int i = 0; i < blocktomanageitsroom.BlockRoomsList.Count; i++)
                {
                    Console.WriteLine($"{i + 1} : Room {blocktomanageitsroom.BlockRoomsList[i].roomNum}");
                }
                Console.WriteLine('\n');
                Console.Write("Please Enter The Room Number Wich You Want To Edit :");
                int RoomNumberToEdit = 0;

                try
                {
                    RoomNumberToEdit = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Press Any Button");
                    Console.ReadKey();
                    RoomManagmentMainMenu = true;

                    while (RoomManagmentMainMenu)
                    {

                        Program.MainMenu(ref RoomManagmentMainMenu);

                    }
                }
                Room RoomToEdit = Room.FindRoomByRoomNumber(RoomNumberToEdit, blocktomanageitsroom);
                blocktomanageitsroom.BlockRoomsList.Remove(RoomToEdit);
                if (RoomToEdit != null)
                {
                    Console.Write("Please Enter The New Room Number :");

                    int NewRoomNumber = 0;

                    try
                    {
                        NewRoomNumber = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Press Any Button");
                        Console.ReadKey();
                        RoomManagmentMainMenu = true;

                        while (RoomManagmentMainMenu)
                        {

                            Program.MainMenu(ref RoomManagmentMainMenu);

                        }
                    }
                    Console.Write("Please Enter The New Floor Of Room :");
                    int NewRoomFloor = 0;

                    try
                    {
                        NewRoomFloor = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Press Any Button");
                        Console.ReadKey();
                        RoomManagmentMainMenu = true;

                        while (RoomManagmentMainMenu)
                        {

                            Program.MainMenu(ref RoomManagmentMainMenu);

                        }
                    }
                    Console.Write("Please Enter The New Room Capacity :");
                    int NewRoomCapacity = 0;

                    try
                    {
                        NewRoomCapacity = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Press Any Button");
                        Console.ReadKey();
                        RoomManagmentMainMenu = true;

                        while (RoomManagmentMainMenu)
                        {

                            Program.MainMenu(ref RoomManagmentMainMenu);

                        }
                    }
                    Room EditedRoom = new Room(NewRoomNumber, NewRoomFloor, NewRoomCapacity, blocktomanageitsroom);
                    blocktomanageitsroom.BlockRoomsList.Add(EditedRoom);

                    if (EditedRoom != null)
                    {
                        Console.WriteLine("Room Edited Successfuly");
                        Console.WriteLine("Press Any Button");
                        Console.ReadKey();
                    }
                }

            }
            else
            {
                Console.WriteLine("There Is No Any Definded Room To Edit !");
                Console.WriteLine("Press Any Button!");
            }

        }
        public static void DisplayRoom(Block blocktomanageitsroom)
        {
            if(blocktomanageitsroom.BlockRoomsList.Count>0)
            {
                Console.Clear();
                Console.WriteLine("List Of Rooms From This Block :");
                for (int i = 0; i < blocktomanageitsroom.BlockRoomsList.Count; i++)
                {
                    Console.WriteLine($"{i + 1} : Room {blocktomanageitsroom.BlockRoomsList[i].roomNum}");
                }
                Console.WriteLine("\n");
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("There Is No Definded Room To Display");
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
            }
        }
    }
}

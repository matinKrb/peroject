using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class Block
    {
        public static bool BlockMainMenu = true;    
        public string BlockName { get; set; }

        private int BlockFloors;
        public int blockFloors
        {
            get { return BlockFloors; }
            set
            {
                if (value > 0)
                {
                    BlockFloors = value;
                }
                else
                {
                    Console.WriteLine("Invalid blockFloor!");
                }
            }
        }
        private int BlockRooms;
        public int blockRoom
        {
            get { return BlockRooms; }
            set
            {
                if (value > 0)
                {
                    BlockRooms = value;
                }
                else
                {
                    Console.WriteLine("Invalid blockRoom!");
                }
            }
        }


        public BlockManager MgBlock { get; set; }
        public List<Room> BlockRoomsList { get; set; } = new List<Room>();
        public Hostel HostelBlock { get; set; }

        public Block(string blockName, int blockFloors, int blockRoom, BlockManager mgBlock, List<Room> blockRooms, Hostel hostelBlock)
        {
            BlockName = blockName;
            BlockFloors = blockFloors;
            BlockRooms = blockRoom;
            MgBlock = mgBlock;
            BlockRoomsList = blockRooms;
            HostelBlock = hostelBlock;
        }
        public Block(string blockName, int blockFloors, int blockRoom, BlockManager mgBlock, Hostel hostelBlock)
        {
            BlockName = blockName;
            BlockFloors = blockFloors;
            BlockRooms = blockRoom;
            MgBlock = mgBlock;
            HostelBlock = hostelBlock;
        }

        public static Block FindBlockByName(string name , Hostel chossenhostel)
        {
            Block result = null;
            for (int i = 0; i < chossenhostel.BlockList.Count; i++)
            {
                if (chossenhostel.BlockList[i].BlockName == name)
                {
                    result = chossenhostel.BlockList[i];
                }

            }
            if (result == null)
            {
                Console.WriteLine("Block Not Found");
                Console.WriteLine("Press Any Button ");
                Console.ReadKey();

                BlockMainMenu = true;

                while (BlockMainMenu)
                {

                    Program.MainMenu(ref BlockMainMenu);

                }
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class Block
    {
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
        private int BlockRoom;
        public int blockRoom
        {
            get { return BlockRoom; }
            set
            {
                if (value > 0)
                {
                    BlockRoom = value;
                }
                else
                {
                    Console.WriteLine("Invalid blockRoom!");
                }
            }
        }


        public BlockManager MgBlock { get; set; }
        public List<Room> BlockRooms { get; set; }
        public Hostel HostelBlock { get; set; }

        public Block(string blockName, int blockFloors, int blockRoom, BlockManager mgBlock, List<Room> blockRooms, Hostel hostelBlock)
        {
            BlockName = blockName;
            BlockFloors = blockFloors;
            BlockRoom = blockRoom;
            MgBlock = mgBlock;
            BlockRooms = blockRooms;
            HostelBlock = hostelBlock;
        }
        public Block(string blockName, int blockFloors, int blockRoom, BlockManager mgBlock, Hostel hostelBlock)
        {
            BlockName = blockName;
            BlockFloors = blockFloors;
            BlockRoom = blockRoom;
            MgBlock = mgBlock;
            HostelBlock = hostelBlock;
        }

        public static Block FindBlockByName(string name , Hostel chossenhostel)
        {
            Block result = null;
            for (int i = 0; i < chossenhostel.BlockList.Count; i++)
            {
                if (Lists.HostelList[i].Name == name)
                {
                    result = chossenhostel.BlockList[i];
                }

            }
            if (result == null)
            {
                Console.WriteLine("Block Not Found");
            }
            return result;
        }
    }
}

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
        public int BlockFloors
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
        public int BlockRoom
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
    }
}

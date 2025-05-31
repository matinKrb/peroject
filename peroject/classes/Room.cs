using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class Room
    {
        public int RoomNum
        {
            get { return RoomNum; }
            set
            {
                if (value > 0)
                {
                    RoomNum = value;
                }
                else
                {
                    Console.WriteLine("Invalid RoomNum!");
                }
            }
        }


        public int RoomFloor
        {
            get { return RoomFloor; }
            set
            {
                if (value > 0)
                {
                    RoomFloor = value;
                }
                else
                {
                    Console.WriteLine("Invalid RoomFloor!");
                }
            }
        }
        public int Capacity
        {
            get { return Capacity; }
            set
            {
                if (value > 0 && value <= 6)
                {
                    Capacity = value;
                }
                else
                {
                    Console.WriteLine("Invalid Capacity!");
                }
            }
        }
        public List<Equipment> RoomEq { get; set; }
        public List<Student> RoomSt { get; set; }
        public Block RoomBlock { get; set; }

        public Room(int roomNum, int roomFloor, int capacity, List<Equipment> roomEq, List<Student> roomSt, Block roomBlock)
        {
            RoomNum = roomNum;
            RoomFloor = roomFloor;
            Capacity = capacity;
            RoomEq = roomEq;
            RoomSt = roomSt;
            RoomBlock = roomBlock;
        }
    }
}

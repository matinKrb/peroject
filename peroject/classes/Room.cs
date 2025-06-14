﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{

    
    public class Room
    {
        public static bool RoomMainMenu = true;
        private int RoomNum;
        public int roomNum
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
                    Console.WriteLine("Press Any Butten");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        private int RoomFloor;
        public int roomFloor
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
                    Console.WriteLine("Press Any Butten");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        private int Capacity;
        public int capacity
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
                    Console.WriteLine("Press Any Butten");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        public List<Equipment> RoomEq { get; set; } = new List<Equipment>();
        public List<Student> RoomSt { get; set; } = new List<Student>();
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

        public Room(int roomNum, int roomFloor, int capacity, Block roomBlock)
        {
            this.roomNum = roomNum;
            this.roomFloor = roomFloor;
            this.capacity = capacity;
            RoomBlock = roomBlock;
        }

        public static Room FindRoomByRoomNumber(int roomnumber,Block blocktomanageitsroom)
        {
            Room result = null;
            for (int i = 0; i < blocktomanageitsroom.BlockRoomsList.Count; i++)
            {
                if (blocktomanageitsroom.BlockRoomsList[i].RoomNum == roomnumber)
                {
                    result = blocktomanageitsroom.BlockRoomsList[i];
                }

            }
            if (result == null)
            {
                Console.WriteLine("Room Not Found");
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
                RoomMainMenu = true;
                while (RoomMainMenu)
                {
                    Program.MainMenu(ref RoomMainMenu);
                }

            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class BlockManager:Student
    {
        public string Position { get; set; }
        public Block MnBlock { get; set; }

        public BlockManager(string position, Block mnBlock, long studentId, Room stRoom, Block stBlock, Hostel stHostel, List<Equipment> stEquipment, string name, string family, string phoneNumber, long nationalCode, string addres) :base(studentId,stRoom,stBlock,stHostel, stEquipment,name, family, phoneNumber, nationalCode, addres)
        {
            Position = position;
            MnBlock = mnBlock;
        }
    }
}

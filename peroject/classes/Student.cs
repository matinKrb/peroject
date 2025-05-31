using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class Student : Person
    {
        List<Student> StudentsList = new List<Student>();

        public long StudentId
        {
            get { return StudentId; }
            set
            {
                if (value >= 100000000 && value < 1000000000)
               {
                    StudentId= value;
                }
                else
                {
                    Console.WriteLine("Invalid Student ID!");
                }
            }
        }
        public Room StRoom { get; set; }
        public Block StBlock { get; set; }
        public Hostel StHostel { get; set; }
        public List<Equipment> StEquipment { get; set; }

        public Student(long studentId, Room stRoom, Block stBlock, Hostel stHostel, List<Equipment> stEquipment, string name, string family, string phoneNumber, long nationalCode, string addres) : base(name, family, nationalCode , phoneNumber, addres)
        {
            StudentId = studentId;
            StRoom = stRoom;
            StBlock = stBlock;
            StHostel = stHostel;
            StEquipment = stEquipment;
        }
        public void SignUp()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class Student : Person
    {

        public long StudentId {  get; set; }
        //{
        //    //get { return StudentId; }
        //    //set
        //    //{
        //    //    if (value >= 100000000 && value < 1000000000)
        //    //   {
        //    //        StudentId= value;
        //    //    }
        //    //    else
        //    //    {
        //    //        Console.WriteLine("Invalid Student ID!");
        //    //    }
        //    //}
        //}
        public Room StRoom { get; set; }
        public Block StBlock { get; set; }
        public Hostel StHostel { get; set; }
        public List<Equipment> StEquipment { get; set; }

        public Student( long studentId , string name , string family , string phoneNumber , long nationalCode , string address) : base( name , family , nationalCode , phoneNumber , address)
        {
            StudentId = studentId;
        }

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
        public static Student FindStudentByName(string family)
        {
            Student result = null;
            for (int i = 0; i < Lists.StudentList.Count; i++)
            {
                if (Lists.StudentList[i].Family == family)
                {
                    result = Lists.StudentList[i]  ;
                }
            }
            if (result == null)
            {
                Console.WriteLine("Student Not Found");
            }
            return result;
        }
        public static Student FindStudentByStudentId(long Studenid)
        {
            Student result = null;
            for (int i = 0; i < Lists.StudentList.Count; i++)
            {
                if (Lists.StudentList[i].StudentId == Studenid)
                {
                    result = Lists.StudentList[i];
                }
            }
            if (result == null)
            {
                Console.WriteLine("Student Not Found");
            }
            return result;
        }
    }
}

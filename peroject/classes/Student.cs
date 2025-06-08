using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class Student : Person
    {
        public static bool StudentMainMenu = true;

        public int DayOfAccommodationHostory = 0;
        public int MonthOfAccommodationHostory = 0;
        public int YearOfAccommodationHostory = 0;
        private long studentId;
        public long StudentId
        {
            get { return studentId; }
            set
            {
                if (value >= 100000000 && value < 1000000000)
                {
                    studentId = value;
                }
                else
                {
                    Console.WriteLine("Invalid Student ID!");
                    Console.WriteLine("Press Any Butten");
                    Console.ReadKey();
                    Console.Clear();
                    Program.MainMenu(ref StudentMainMenu);
                }
            }
        }
        public Room StRoom { get; set; }
        public Block StBlock { get; set; }
        public Hostel StHostel { get; set; }
        public List<Equipment> StEquipment { get; set; } = new List<Equipment>();

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
        public Student(long studentId, Room stRoom, Block stBlock, Hostel stHostel, string name, string family, string phoneNumber, long nationalCode, string addres) : base(name, family, nationalCode, phoneNumber, addres)
        {
            StudentId = studentId;
            StRoom = stRoom;
            StBlock = stBlock;
            StHostel = stHostel;
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
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
                StudentMainMenu = true;
                while (StudentMainMenu)
                {
                    Program.MainMenu(ref StudentMainMenu);
                }
            }
            return result;
        }
        public static Student FindStudentByStudentId(long Studentid)
        {
            Student result = null;
            for (int i = 0; i < Lists.StudentList.Count; i++)
            {
                if (Lists.StudentList[i].StudentId == Studentid)
                {
                    result = Lists.StudentList[i];
                }
            }
            if (result == null)
            {
                Console.WriteLine("Student Not Found");
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
                StudentMainMenu = true;
                while (StudentMainMenu)
                {
                    Program.MainMenu(ref StudentMainMenu);
                }
            }
            return result;
        }
    }
}

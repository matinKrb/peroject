using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class StudentManagement
    {
        public static int NumberOFRegisteredStudent = 0;
        public static bool StudentManagmentMainMenu = true;

        public static void DisplayStudentManagmentMenu()
        {
            Console.Clear();
            Console.WriteLine(" 1 : Add New Student ");
            Console.WriteLine(" 2 : Delete a Student ");
            Console.WriteLine(" 3 : Edit a Student ");
            Console.WriteLine(" 4 : Find a Student ");
            Console.WriteLine(" 5 : Student Registration In Hostel ");
            Console.WriteLine(" 6 : Transfer Student  ");
            Console.WriteLine(" 7 : Display All Information Of A Student  ");

            Console.WriteLine('\n');

            Console.Write("Please Enter The Option Number :");

            int DisplayStudentManagmentMenuOption = 0;

            try
            {
                DisplayStudentManagmentMenuOption = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
                StudentManagmentMainMenu = true;

                while (StudentManagmentMainMenu)
                {

                    Program.MainMenu(ref StudentManagmentMainMenu);

                }
            }

            switch (DisplayStudentManagmentMenuOption)
            {
                case 1:
                    AddStudent();
                    break;

                case 2:
                    RemoveStudentByStudentId();
                    break;

                case 3:
                    EditStudent();
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("1: Find By Family");
                    Console.WriteLine("2: Find By Student ID");
                    Console.Write("Please Enter The Option Number :");
                    int FindStudentMenu = 0;

                    try
                    {
                        FindStudentMenu = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Press Any Button");
                        Console.ReadKey();
                        StudentManagmentMainMenu = true;

                        while (StudentManagmentMainMenu)
                        {

                            Program.MainMenu(ref StudentManagmentMainMenu);

                        }
                    }
                    switch (FindStudentMenu)
                    {
                        case 1:FindStudentByFamily();
                            break;

                        case 2:FindStudentByStudentId();
                            break;
                    }

                    break;

                case 5:
                    StudentRegistrationInHostel();
                    break;

                case 6:
                    MovingStudent();
                    break;

                case 7:
                    DisplayAllInfoStudent();
                    break;


            }


        }
        public static void AddStudent()
        {
            Console.Clear();

            Console.Write("Please Enter Student Name :");
            string name = Console.ReadLine();
            Console.Write("Please Enter Student Family :");
            string family = Console.ReadLine();
            Console.Write("Please Enter Student Student Id :");
            long StudentId = 0;
            try
            {
                StudentId = Convert.ToInt64(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
                StudentManagmentMainMenu = true;

                while (StudentManagmentMainMenu)
                {

                    Program.MainMenu(ref StudentManagmentMainMenu);

                }
            }
            Console.Write("Please Enter Student National Code :");

            long nationalcode = 0;

            try
            {
                nationalcode = Convert.ToInt64(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
                StudentManagmentMainMenu = true;

                while (StudentManagmentMainMenu)
                {

                    Program.MainMenu(ref StudentManagmentMainMenu);

                }
            }
            Console.Write("Please Enter Student Phone Number :");
            string phonenumber = Console.ReadLine();
            Console.Write("Please Enter Student Address :");
            string address = Console.ReadLine();

            Student NewStudent = new Student(StudentId, name, family, phonenumber, nationalcode, address);

            Lists.StudentList.Add(NewStudent);
            Console.WriteLine('\n');
            Console.WriteLine("Student Added Successfuly");
            Console.WriteLine("Press Any Button");
            Console.ReadKey();

        }
        public static void RemoveStudentByStudentId()
        {
            Console.Clear();

            if (Lists.StudentList.Count > 0)
            {
                Console.WriteLine("List Of Student With Student ID:");
                for (int i = 0; i < Lists.StudentList.Count; i++)
                {
                    Console.WriteLine($"{i + 1} : {Lists.StudentList[i].Family} {Lists.StudentList[i].StudentId}");

                }
                Console.WriteLine('\n');

                Console.Write("Please Enter The Student Id Wich You Wanna Delete :");
                long StudentId = 0;

                try
                {
                    StudentId = Convert.ToInt64(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Press Any Button");
                    Console.ReadKey();
                    StudentManagmentMainMenu = true;

                    while (StudentManagmentMainMenu)
                    {

                        Program.MainMenu(ref StudentManagmentMainMenu);

                    }
                }
                Student StudentToRemove = Student.FindStudentByStudentId(StudentId);
                Lists.StudentList.Remove(StudentToRemove);

                Console.WriteLine('\n');
                if (StudentToRemove != null)
                {
                    Console.WriteLine("Student Removed Successfuly");
                }


                Console.WriteLine("Press Any Button");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("List Of Students Is Empty!");
            }
        }

        public static void EditStudent()
        {

            Console.Clear();
            if (Lists.StudentList.Count > 0)
            {
                Console.WriteLine("List Of Students With Student Id:");
                for (int i = 0; i < Lists.StudentList.Count; i++)
                {
                    Console.WriteLine($"{i + 1} : {Lists.StudentList[i].Family} , {Lists.StudentList[i].StudentId}");

                }

                Console.WriteLine('\n');

                Console.Write("Please Enter The Student Id Wich You Wanna Edit :");
                long StudentId = 0;

                try
                {
                    StudentId = Convert.ToInt64(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Press Any Button");
                    Console.ReadKey();
                    StudentManagmentMainMenu = true;

                    while (StudentManagmentMainMenu)
                    {

                        Program.MainMenu(ref StudentManagmentMainMenu);

                    }
                }

                Student ToEditStudent = Student.FindStudentByStudentId(StudentId);


                if (ToEditStudent != null)
                {
                    Console.Write("Please Enter The New Name Of Student :");
                    string name = Console.ReadLine();
                    Console.Write("Please Enter The New Family Of Student :");
                    string family = Console.ReadLine();
                    Console.Write("Please Enter The New Student ID :");
                    long NewStudentId = 0;
                    try
                    {
                        NewStudentId = Convert.ToInt64(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Press Any Button");
                        Console.ReadKey();
                        StudentManagmentMainMenu = true;

                        while (StudentManagmentMainMenu)
                        {

                            Program.MainMenu(ref StudentManagmentMainMenu);

                        }
                    }

                    Console.Write("Please Enter The New National Code Of Student :");
                    long editednationalcode = 0;

                    try
                    {
                        editednationalcode = Convert.ToInt64(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Press Any Button");
                        Console.ReadKey();
                        StudentManagmentMainMenu = true;

                        while (StudentManagmentMainMenu)
                        {

                            Program.MainMenu(ref StudentManagmentMainMenu);

                        }
                    }
                    Console.Write("Please Enter The New Phone Number Of Student :");
                    string phonenumber = Console.ReadLine();
                    Console.Write("Please Enter The New Address Of Student :");
                    string address = Console.ReadLine();

                    ToEditStudent.Name = name;
                    ToEditStudent.Family = family;
                    ToEditStudent.StudentId = NewStudentId;
                    ToEditStudent.NationalCode = editednationalcode;
                    ToEditStudent.PhoneNumber = phonenumber;
                    ToEditStudent.Addres = address;
                    Console.WriteLine('\n');
                    Console.WriteLine("Student Edited Successfuly");
                }
            }
            else
            {
                Console.WriteLine("List Of Student Is Empty!");
            }


            Console.WriteLine("Press Any Button");
            Console.ReadKey();
        }
        public static void FindStudentByFamily()
        {Console.Clear();
            Console.Write("Please Enter The Student Family Wich You Want To Find :");
            string FamilyToFind = Console.ReadLine();
            Student FindedStudent=Student.FindStudentByName(FamilyToFind);
            if (FindedStudent != null)
            {
                Console.WriteLine($"Name Is :{FindedStudent.Name} , Family Is : {FindedStudent.Family} , Student ID Is : {FindedStudent.StudentId} , National Code Is : {FindedStudent.NationalCode} , Phone Number Is : {FindedStudent.PhoneNumber} , Address Is : {FindedStudent.Addres}");
                Console.WriteLine("Press Any Button!");
            }
            

        }
        public static void FindStudentByStudentId()
        {
            Console.Clear();
            Console.Write("Please Enter The Student Id Wich You Want To Find :");
            long StudentIdToFind = 0;
            try
            {
                StudentIdToFind = Convert.ToInt64(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
                StudentManagmentMainMenu = true;

                while (StudentManagmentMainMenu)
                {

                    Program.MainMenu(ref StudentManagmentMainMenu);

                }
            }
            Student FindedStudentByID = Student.FindStudentByStudentId(StudentIdToFind);
            if (FindedStudentByID!=null)
            {
                Console.WriteLine($"Name Is :{FindedStudentByID.Name} , Family Is : {FindedStudentByID.Family} , Student ID Is : {FindedStudentByID.StudentId} , National Code Is : {FindedStudentByID.NationalCode} , Phone Number Is : {FindedStudentByID.PhoneNumber} , Address Is : {FindedStudentByID.Addres}");
            }
        }



        public static void StudentRegistrationInHostel()
        {
            Console.Clear();
            if (Lists.StudentList.Count>0)
            {
                Console.Write("Please Enter The Student Id Who You Want to Registration To Hostel :");
                long StudentIdToRegister = 0;

                try
                {
                    StudentIdToRegister = Convert.ToInt64(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Press Any Button");
                    Console.ReadKey();
                    StudentManagmentMainMenu = true;

                    while (StudentManagmentMainMenu)
                    {

                        Program.MainMenu(ref StudentManagmentMainMenu);

                    }
                }
                Student StudentToRegister = Student.FindStudentByStudentId(StudentIdToRegister);

                Console.WriteLine('\n');
                if (Lists.HostelList.Count>0)
                {
                    Console.WriteLine("List Of Hotels :");
                    Console.WriteLine('\n');
                    for (int i = 0; i < Lists.HostelList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1} : {Lists.HostelList[i].Name}");
                    }
                    Console.WriteLine('\n');
                    Console.Write("Please Enter The Name Of Hostel Wich You Want To Register Student At :");
                    string HostelNameToRegister = Console.ReadLine();

                    StudentToRegister.StHostel = Hostel.FindHostelByName(HostelNameToRegister);
                    Console.WriteLine('\n');
                    Console.WriteLine("Registering Hostel Successfuly");
                    Console.WriteLine("Press Any Button to Regitration Block And Room");
                    Console.ReadKey();

                    if (StudentToRegister.StHostel.BlockList.Count>0)
                    {
                        Console.Clear();
                        Console.WriteLine("List Of Blocks From This Hostel :");
                        for (int i = 0; i < StudentToRegister.StHostel.BlockList.Count; i++)
                        {
                            Console.WriteLine($"{i+1} : {StudentToRegister.StHostel.BlockList[i].BlockName}");
                        }
                        Console.WriteLine('\n');
                        Console.Write("Please Enter The Name Of Block Wich You Want To Register Student At :");
                        string BlockNameToRegister = Console.ReadLine();

                        StudentToRegister.StBlock = Block.FindBlockByName(BlockNameToRegister,StudentToRegister.StHostel);
                        Console.WriteLine('\n');
                        Console.WriteLine("Registering Block Successfuly");
                        Console.WriteLine("Press Any Button to Regitration Room");
                        Console.ReadKey();
                        if (StudentToRegister.StBlock.BlockRoomsList.Count>0)
                        {
                            Console.Clear();
                            Console.WriteLine("List Of Rooms From This Block With Capacity :");
                            for (int i = 0; i < StudentToRegister.StBlock.BlockRoomsList.Count; i++)
                            {
                                Console.WriteLine($"{i+1} : Room {StudentToRegister.StBlock.BlockRoomsList[i].roomNum} , Remaining Capacity : {StudentToRegister.StBlock.BlockRoomsList[i].capacity}");
                            }
                            Console.WriteLine('\n');
                            Console.Write("Please Enter The Room Number Wich You Want To Register Student At :");
                            int RoomNumberToRegister = 0;

                            try
                            {
                                RoomNumberToRegister = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                Console.WriteLine("Press Any Button");
                                Console.ReadKey();
                                StudentManagmentMainMenu = true;

                                while (StudentManagmentMainMenu)
                                {

                                    Program.MainMenu(ref StudentManagmentMainMenu);

                                }
                            }

                            StudentToRegister.StRoom = Room.FindRoomByRoomNumber(RoomNumberToRegister, StudentToRegister.StBlock);
                            if (StudentToRegister.StRoom.capacity>0)
                            {

                                Console.WriteLine("Registering Room Successfuly");
                                Console.WriteLine("Press Any Button To Specify The Registration Date");
                                Console.ReadKey();
                                Console.Clear();
                                Console.Write("Please Enter The Year Of Registration :");

                                int Year = 0;

                                try
                                {
                                    Year = int.Parse(Console.ReadLine());
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    Console.WriteLine("Press Any Button");
                                    Console.ReadKey();
                                    StudentManagmentMainMenu = true;

                                    while (StudentManagmentMainMenu)
                                    {

                                        Program.MainMenu(ref StudentManagmentMainMenu);

                                    }
                                }
                                StudentToRegister.YearOfAccommodationHostory = Year;
                                Console.WriteLine('\n');
                                Console.Write("Please Enter The Month Of Registration :");

                                int Month = 0;

                                try
                                {
                                    Month = int.Parse(Console.ReadLine());
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    Console.WriteLine("Press Any Button");
                                    Console.ReadKey();
                                    StudentManagmentMainMenu = true;

                                    while (StudentManagmentMainMenu)
                                    {

                                        Program.MainMenu(ref StudentManagmentMainMenu);

                                    }
                                }
                                StudentToRegister.MonthOfAccommodationHostory = Month;
                                Console.WriteLine('\n');
                                Console.Write("Please Enter The Day Of Registration :");

                                int Day = 0;

                                try
                                {
                                    Day = int.Parse(Console.ReadLine());
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    Console.WriteLine("Press Any Button");
                                    Console.ReadKey();
                                    StudentManagmentMainMenu = true;

                                    while (StudentManagmentMainMenu)
                                    {

                                        Program.MainMenu(ref StudentManagmentMainMenu);

                                    }
                                }
                                StudentToRegister.DayOfAccommodationHostory = Day;

                                Console.WriteLine('\n');
                                Console.WriteLine("Specifying The Registration Date Successfuly");
                                Console.WriteLine("Press Any Button");
                                Console.ReadKey();

                                Lists.RegisteredStudent.Add(StudentToRegister);
                                NumberOFRegisteredStudent++;
                                StudentToRegister.StHostel.Capacity--;
                                StudentToRegister.StRoom.capacity--;


                                Console.Clear();
                                Console.WriteLine("Registering Successfuly");
                                Console.WriteLine("Press Any Button");
                                Console.ReadKey();

                            }
                            else
                            {
                                Console.WriteLine("This Room Has No Capacity !");
                            }
                        }
                        else
                        {
                            Console.WriteLine('\n');
                            Console.WriteLine("There Is No Room From This Block");
                            Console.WriteLine("Press Any Button");
                            Console.ReadKey();
                        }

                    }
                    else
                    {
                        Console.WriteLine('\n');
                        Console.WriteLine("There Is No Block From This Hostel");
                        Console.WriteLine("Press Any Button");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("There Is No Hostel To Register !");
                    Console.WriteLine("Press Any Button");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("There Is No Student To Register !");
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
            }
        }
        public static void MovingStudent()
        {
            Console.Clear();
            if (Lists.StudentList.Count>0)
            {
                Console.Write("Please Enter The Student Id Who You Want to Change His Room (And bLock And Hostel) :");
                long StudentIdToMove = 0;

                try
                {
                    StudentIdToMove = Convert.ToInt64(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Press Any Button");
                    Console.ReadKey();
                    StudentManagmentMainMenu = true;

                    while (StudentManagmentMainMenu)
                    {

                        Program.MainMenu(ref StudentManagmentMainMenu);

                    }
                }
                Student StudentToMove = Student.FindStudentByStudentId(StudentIdToMove);

                Console.WriteLine('\n');
                if (Lists.HostelList.Count > 0)
                {
                    Console.WriteLine("List Of Hotels :");
                    Console.WriteLine('\n');
                    for (int i = 0; i < Lists.HostelList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1} : {Lists.HostelList[i].Name}");
                    }
                    Console.WriteLine('\n');
                    Console.Write("Please Enter The Name Of Hostel Wich You Want To Transfer The Student To :");
                    string HostelNameToMove = Console.ReadLine();
                    
                    StudentToMove.StHostel = Hostel.FindHostelByName(HostelNameToMove);
                    Console.WriteLine('\n');
                    Console.WriteLine("Replacing Hostel Successfuly");
                    Console.WriteLine("Press Any Button to Replace Block And Room");
                    Console.ReadKey();

                    if (StudentToMove.StHostel.BlockList.Count > 0)
                    {
                        Console.Clear();
                        Console.WriteLine("List Of Blocks From New Hostel :");
                        for (int i = 0; i < StudentToMove.StHostel.BlockList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1} : {StudentToMove.StHostel.BlockList[i].BlockName}");
                        }
                        Console.WriteLine('\n');
                        Console.Write("Please Enter The Name Of Block Wich You Want To Transfer The Student To :");
                        string BlockNameToMove = Console.ReadLine();

                        StudentToMove.StBlock = Block.FindBlockByName(BlockNameToMove, StudentToMove.StHostel);
                        Console.WriteLine('\n');
                        Console.WriteLine("Replacing Block Successfuly");
                        Console.WriteLine("Press Any Button to Replace Room");
                        Console.ReadKey();
                        if (StudentToMove.StBlock.BlockRoomsList.Count > 0)
                        {
                            Console.Clear();
                            Console.WriteLine("List Of Rooms From This Block :");
                            for (int i = 0; i < StudentToMove.StBlock.BlockRoomsList.Count; i++)
                            {
                                Console.WriteLine($"{i + 1} : Room {StudentToMove.StBlock.BlockRoomsList[i].roomNum} , Capacity : {StudentToMove.StBlock.BlockRoomsList[i].capacity}");
                            }
                            Console.WriteLine('\n');
                            Console.Write("Please Enter The Room Nuber Wich You Want To Transfer The Student To :");
                            int RoomNumberToMove = 0;

                            try
                            {
                                RoomNumberToMove = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                Console.WriteLine("Press Any Button");
                                Console.ReadKey();
                                StudentManagmentMainMenu = true;

                                while (StudentManagmentMainMenu)
                                {
                                    Program.MainMenu(ref StudentManagmentMainMenu);
                                }
                            }

                            StudentToMove.StRoom = Room.FindRoomByRoomNumber(RoomNumberToMove, StudentToMove.StBlock);

                            Console.WriteLine("Replacing Room Successfuly");
                            Console.WriteLine("Press Any Button");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Transfering Student Successfuly");
                            StudentToMove.StHostel.Capacity--;
                            StudentToMove.StRoom.capacity--;
                            Console.WriteLine("Press Any Button");
                            Console.ReadKey();

                        }
                        else
                        {
                            Console.WriteLine('\n');
                            Console.WriteLine("There Is No Room From This Block To Replace");
                            Console.WriteLine("Press Any Button");
                            Console.ReadKey();
                        }

                    }
                    else
                    {
                        Console.WriteLine('\n');
                        Console.WriteLine("There Is No Block From This Hostel To Replace");
                        Console.WriteLine("Press Any Button");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("There Is No Hostel To Replace!");
                    Console.WriteLine("Press Any Button");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("There Is No Student To Transfer!");
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
            }
        }
        public static void DisplayAllInfoStudent()
        {
            Console.Clear();
            if (Lists.RegisteredStudent.Count > 0)
            {
                Console.Write("Please Enter The Student Id Who You Want To Display His Information :");
                long StudentIdToDisplay = 0;

                try
                {
                    StudentIdToDisplay = Convert.ToInt64(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Press Any Button");
                    Console.ReadKey();
                    StudentManagmentMainMenu = true;

                    while (StudentManagmentMainMenu)
                    {

                        Program.MainMenu(ref StudentManagmentMainMenu);

                    }
                }
                Student StudentToDisplay = Student.FindStudentByStudentId(StudentIdToDisplay);
                int counter = 0;
                foreach (var item in Lists.RegisteredStudent)
                {
                    if (item == StudentToDisplay)
                    {
                        counter++;
                    }
                }

                if (counter>0)
                {
                    Console.Clear();
                    Console.WriteLine($"Name : {StudentToDisplay.Name}");
                    Console.WriteLine($"Family : {StudentToDisplay.Family}");
                    Console.WriteLine($"National Code : {StudentToDisplay.NationalCode}");
                    Console.WriteLine($"Phone Number : {StudentToDisplay.PhoneNumber}");
                    Console.WriteLine($"Address : {StudentToDisplay.Addres}");
                    Console.WriteLine($"Student Id : {StudentToDisplay.StudentId}");
                    Console.WriteLine('\n');
                    Console.WriteLine($"Student Hostel : {StudentToDisplay.StHostel.Name}");
                    Console.WriteLine($"Student Block : {StudentToDisplay.StBlock.BlockName}");
                    Console.WriteLine($"Student Room : {StudentToDisplay.StRoom.roomNum}");
                    Console.WriteLine('\n');
                    Console.WriteLine("List Of Student Equipment :");
                    for (int i = 0; i < StudentToDisplay.StEquipment.Count; i++)
                    {
                        Console.WriteLine($"{i + 1} : {StudentToDisplay.StEquipment[i].EqType}");
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("Press Any Button");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Please Register Student In The Hostel First");
                    Console.WriteLine("Press Any Button");
                    Console.ReadKey();
                }

            }
            else
            {
                Console.WriteLine("Please Register Student In The Hostel First");
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
            }
        }
    }
}

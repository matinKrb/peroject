using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class StudentManagement
    {
        public static bool StudentManagmentMainMenu = true;

        public static void DisplayStudentManagmentMenu()
        {
            Console.Clear();
            Console.WriteLine(" 1 : Add New Student ");
            Console.WriteLine(" 2 : Delete a Student ");
            Console.WriteLine(" 3 : Edit a Student ");
            Console.WriteLine(" 4 : Find a Student ");
            Console.WriteLine(" 5 : Display All Information Of A Student  ");
            Console.WriteLine(" 6 : Student Registration In Hostel ");
            Console.WriteLine(" 7 : Transfer Student  ");

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
                    break;

                case 6:
                    break;

                case 7:
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
    }
}

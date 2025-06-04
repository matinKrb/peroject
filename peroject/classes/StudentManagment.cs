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
                    break;

                case 3:
                    break;

                case 4:
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

            Student NewStudent = new Student(StudentId ,name,family , phonenumber , nationalcode , address);
            
            Lists.StudentList.Add(NewStudent);
            
        }
    }
}

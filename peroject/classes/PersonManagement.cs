using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class PersonManagement
    {
        public static void DisplayPersonManagemantMenu()
        {
            Console.Clear();
            Console.WriteLine("1 : Manage Hostels Manager");
            Console.WriteLine("2 : Manage Blocks Manager");
            Console.WriteLine("3 : Manage Students");

            Console.Write("Please Enter The Option Number : ");
            int PersonManagementOption = 0;

            try
            {
                PersonManagementOption = int.Parse(Console.ReadLine());
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            switch (PersonManagementOption)
            {
                case 1:
                    HostelManagerManagment.DisplayHostelManagerMenu();
                    break;

                case 2:BlockManagerManagment.DisplayBlockManagerMenu();
                    break;

                case 3:
                    StudentManagement.DisplayStudentManagmentMenu();

                    break;
            }
        }
    }
}

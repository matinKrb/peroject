using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class BlockManagerManagment
    {public static bool BlockManagerManagmentMenu = true;
        public static void DisplayBlockManagerMenu()
        {
            Console.Clear();
            Console.WriteLine("1 : Add A New Block Manager");
            Console.WriteLine("2 : Delete A Block Manager");
            Console.WriteLine("3 : Edit A Block Manager Info");
            Console.WriteLine("4 : Display Block Managers List");
            Console.WriteLine("\n");

            Console.Write("Please Enter The Option Number : ");
            int BlockManagerManagementOption = 0;

            try
            {
                BlockManagerManagementOption = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press Any Button");
                Console.ReadKey();
                BlockManagerManagmentMenu = true;

                while (BlockManagerManagmentMenu)
                {

                    Program.MainMenu(ref BlockManagerManagmentMenu);

                }
            }

            switch (BlockManagerManagementOption)
            {
                case 1:
                    AddBlockManager();
                    break;

                case 2:
                    
                    break;

                case 3:
                    
                    break;

                case 4:
                   
                    break;
            }
            
        }
        public static void AddBlockManager() 
        {
            Console.Clear();
            if (Lists.StudentList.Count>0)
            {
                Console.WriteLine("List Of Students With Family And Student Id  :");
                Console.WriteLine('\n');

                for (int i = 0; i < Lists.StudentList.Count; i++)
                {
                    Console.WriteLine($"{i + 1} : {Lists.StudentList[i].Family} , {Lists.StudentList[i].StudentId}");
                }
                Console.WriteLine("\n");
                Console.Write("Please Enter Student Id Who You Want To Be Block Manager :");
                long StudentIdToBeManager = 0;

                try
                {
                    StudentIdToBeManager = Convert.ToInt64(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Press Any Button");
                    Console.ReadKey();
                    BlockManagerManagmentMenu = true;

                    while (BlockManagerManagmentMenu)
                    {

                        Program.MainMenu(ref BlockManagerManagmentMenu);

                    }
                }

                Student StudentToBeManager = Student.FindStudentByStudentId(StudentIdToBeManager);

                if (StudentToBeManager != null)
                {

                    string Name = StudentToBeManager.Name;
                    string Family = StudentToBeManager.Family;
                    long StudentId = StudentToBeManager.StudentId;
                    string PhoneNumber = StudentToBeManager.PhoneNumber;
                    long NationalCode = StudentToBeManager.NationalCode;
                    string Addres = StudentToBeManager.Addres;

                    BlockManager NewBlockManager = new BlockManager(StudentId, Name, Family, PhoneNumber, NationalCode, Addres);


                    Lists.blockManagersList.Add(NewBlockManager);

                    Console.WriteLine('\n');
                    Console.WriteLine("Block Manager Added Successfuly");
                    Console.WriteLine("Press Any Button !");
                    Console.ReadKey();


                }
            }
            else
            {
                Console.WriteLine("List Of Students Is Empty!");
            }



            

            
        }
    }
}

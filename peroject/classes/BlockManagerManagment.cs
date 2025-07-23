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
            Console.WriteLine("3 : Change Block Manager(Replacing)");
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
                    RemoveBlockManager();
                    break;

                case 3:
                    ChangeBlockManager();
                    break;

                case 4:
                   DisplayBlockManagersList();
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
                    Console.WriteLine("Block Manager Added Successfully");
                    Console.WriteLine("Press Any Button !");
                    Console.ReadKey();


                }
            }
            else
            {
                Console.WriteLine("List Of Students Is Empty!");
                Console.WriteLine("Press Any Button !");
                Console.ReadKey();
            }



            

            
        }

        public static void RemoveBlockManager() 
        {
            Console.Clear();
            Console.Write("Please Enter The Student Id Of Block Manager Who You Wanna Remove :");

            long StudentIdToRmoveBlockManager = 0;

            try
            {
                StudentIdToRmoveBlockManager = Convert.ToInt64(Console.ReadLine());
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

            BlockManager BlockManagerToRemove = BlockManager.FindBlockManagerByStudentId(StudentIdToRmoveBlockManager);

            if (BlockManagerToRemove != null) 
            {
                Lists.blockManagersList.Remove(BlockManagerToRemove);
                Console.WriteLine('\n');
                Console.WriteLine("Block Manager Removed Successfuly!");
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("Press Any Key ");
                Console.ReadKey();
            }



        }

        public static void ChangeBlockManager() 
        {
            RemoveBlockManager();
            Console.WriteLine('\n');
            Console.WriteLine("Now You Have To Choose A Student Id To Be Block Manager ");
            AddBlockManager();

        }

        public static void DisplayBlockManagersList() 
        {
            Console.WriteLine("Block Managers: ");
            Console.WriteLine('\n');

            for (int i  = 0; i  < Lists.blockManagersList.Count; i++)
            {
                Console.WriteLine($"{i+1}: Name: {Lists.blockManagersList[i].Name} , Family: {Lists.blockManagersList[i].Family}  , Phone Number : {Lists.blockManagersList[i].PhoneNumber} ,National Code : {Lists.blockManagersList[i].NationalCode} , Student Id: {Lists.blockManagersList[i].StudentId}");
                Console.WriteLine();
            }
            Console.WriteLine("Press Any Button !");
            Console.ReadKey();
            
        }
    }
}

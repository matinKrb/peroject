using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class EquipmentReporting
    {
        public static void EquipmentReportingMenu()
        {
            Console.Clear();
            Console.WriteLine("1 : List Of All Equipment");
            Console.WriteLine("2 : List Of Equipment Allocated To Each Room");
            Console.WriteLine("3 : List Of Equipment Allocated To Each Student");
            Console.WriteLine("4 : List Of Defective And Fixing Equipment");
            Console.WriteLine('\n');
            Console.Write("Please Enter The Option Number : ");

            int EquipmentReportingoption = 0;

            try
            {
                EquipmentReportingoption = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            switch (EquipmentReportingoption)
            {
                case 1:
                    Console.Clear();
                    ListOfAllInfo();
                    break;

                case 2:
                    Console.Clear();
                    ListOfEquipmentRoom();
                    break;

                case 3:
                    Console.Clear();

                    break;

                case 4:
                    Console.Clear();
                    break;



            }
        }
        public static void ListOfAllInfo()
        {
            Console.Clear();
            Console.WriteLine("List Of All Equipment With Property Number :");
            for (int i = 0; i < Lists.EquipmentsList.Count; i++)
            {
                Console.WriteLine($"{i+1} : {Lists.EquipmentsList[i].EqType} , {Lists.EquipmentsList[i].PropNum}");
            }
            Console.WriteLine('\n');
            Console.WriteLine("Press Any Button");
            Console.ReadKey();
        }

        public static void ListOfEquipmentRoom()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class SpecializadReport
    {
        public static void SpecializadReportMenu()
        {
            Console.Clear();
            Console.WriteLine("1 : Fix Requests Report");
            Console.WriteLine("2 : Student Accommodation History Report");
            Console.WriteLine('\n');
            Console.Write("Please Enter The Option Number : ");

            int SpecializadReportingoption = 0;

            try
            {
                SpecializadReportingoption = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            switch (SpecializadReportingoption)
            {
                case 1:
                    Console.Clear();
                    ReportFixRequest();
                    break;

                case 2:
                    Console.Clear();
                    StudentAccommodationHostoryReport();
                    break;
            }
        }

        public static void ReportFixRequest()
        {
            Console.Clear();

        }

        public static void StudentAccommodationHostoryReport()
        {
            Console.Clear();
            if (StudentManagement.NumberOFRegisteredStudent > 0)
            {
                Console.WriteLine("Press any Button To Display Student Accommodation Hostory");
                Console.ReadKey();
                Console.Clear();
                for (int i = 0; i < Lists.RegisteredStudent.Count; i++)
                {
                    Console.WriteLine($"Student : {Lists.RegisteredStudent[i].Name} {Lists.RegisteredStudent[i].Family} , With Student Id : {Lists.RegisteredStudent[i].StudentId} , Registered On : {Lists.RegisteredStudent[i].DayOfAccommodationHostory}/{Lists.RegisteredStudent[i].MonthOfAccommodationHostory}/{Lists.RegisteredStudent[i].YearOfAccommodationHostory} , In Room : {Lists.RegisteredStudent[i].StRoom.roomNum} , In Block : {Lists.RegisteredStudent[i].StBlock.BlockName} , In Hostel : {Lists.RegisteredStudent[i].StHostel.Name}");
                }

                Console.WriteLine('\n');
                Console.WriteLine("Press any Button");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("There Are No Registered Student");
                Console.WriteLine("Press any Button");
                Console.ReadKey();
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class Reporting
    {
        public static void ReportingMenu()
        {
            Console.Clear();
            Console.WriteLine("1 : Accommodation Status Report :");
            Console.WriteLine("2 : Equipment Report :");
            Console.WriteLine("3 : Specializad Report :");
            Console.WriteLine('\n');
            Console.Write("Please Enter The Option Number : ");

            int Reportingoption = 0;

            try
            {
                Reportingoption = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            switch (Reportingoption)
            {
                case 1:
                    Console.Clear();
                    AccommodationReporting.AccommodationReportingMenu();
                    break;

                case 2:
                    Console.Clear();
                    EquipmentReporting.EquipmentReportingMenu();
                    break;

                case 3:
                    Console.Clear();
                    SpecializadReport.SpecializadReportMenu();
                    break;



            }
        }
    }
}

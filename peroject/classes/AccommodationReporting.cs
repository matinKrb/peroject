using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class AccommodationReporting
    {
        public static void AccommodationReportingMenu()
        {
            Console.Clear();
            Console.WriteLine("1 : General Statistics On Student Accommodation");
            Console.WriteLine("2 : List Of Empty And Full Room");
            Console.WriteLine("3 : Remaining Capacity Of Each Hostel And Block");
            Console.WriteLine('\n');
            Console.Write("Please Enter The Option Number : ");

            int AccommodationReportingoption = 0;

            try
            {
                AccommodationReportingoption = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            switch (AccommodationReportingoption)
            {
                case 1:
                    Console.Clear();
                    break;

                case 2:
                    Console.Clear();
                    break;

                case 3:
                    Console.Clear();
                    break;



            }
        }
    }
}

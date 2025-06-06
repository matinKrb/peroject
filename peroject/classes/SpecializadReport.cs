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
            Console.WriteLine("1 : Report Fix Requests");
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
                    break;

                case 2:
                    Console.Clear();
                    break;
            }
        }
    }
}

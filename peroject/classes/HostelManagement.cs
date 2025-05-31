using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public static class HostelManagement
    {
        public static void AddHostel()
        {
            Console.Write("Please Enter The Hostel Name");
            string HostelName = Console.ReadLine();
            Console.Write("Please Enter The Hostel Address ");
            string HostelAddress = Console.ReadLine();
            Console.Write("Please Enter The Hostel Capacity ");
            int HostelCapacity = int.Parse(Console.ReadLine());

            for (int i = 0; i < Lists.HostelManagerList.Count; i++)
            {
                Console.WriteLine($"{i+1} : {Lists.HostelManagerList[i].Name} {Lists.HostelManagerList[i].Family}"); 
                
            }
            Console.Write("Please Enter The Family Of Hostel Manager Who You Want To Be Manager Of This Hostel :");
            //در مکان باید مقدار های بالا رو یه سازنده کلاس خوابگاه بفرستیم

            string HMFamily = Console.ReadLine();

            HostelManager NewHostelManager= HostelManager.FindHostelManagerByFamily(HMFamily);



        }
    }
}

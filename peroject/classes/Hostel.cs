using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class Hostel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Capacity 
        {
            get { return Capacity; }
            set 
            {
                if (value >= 0)
                {
                    Capacity = value;
                }
                else
                {
                    Console.WriteLine(" invalid Capacity!");
                }
            }
        }
        public HostelManager ManagerName { get; set; }
        public List<Block> Blocks { get; set; }

        public static Hostel FindHostelByName(string name)
        {
            Hostel result = null;
            for (int i = 0; i < Lists.HostelManagerList.Count; i++)
            {
                if (Lists.HostelList[i].Name == name)
                {
                    result = Lists.HostelList[i];
                }
                else
                {
                    Console.WriteLine("Hostel Not Found");
                }
            }
            return result;
        }


        public Hostel(string name, string address, int capacity, HostelManager managerName, List<Block> blocks)
        {
            Name = name;
            Address = address;
            Capacity = capacity;
            ManagerName = managerName;
            Blocks = blocks;
        }
        public Hostel(string name, string address, int capacity, HostelManager managerName)
        {
            Name = name;
            Address = address;
            Capacity = capacity;
            ManagerName = managerName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class HostelManager : Person
    {
        public string Position { get; set; }

        public Hostel MnHostel { get; set; }

        public HostelManager(string position, Hostel mnHostel, string name, string family, string phoneNumber, long nationalCode, string addres) : base(name, family, nationalCode, phoneNumber, addres)
        {
            Position = position;
            MnHostel = mnHostel;
        }
    }
}

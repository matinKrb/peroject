﻿using System;
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

        public HostelManager(string position, string name, string family, string phoneNumber, long nationalCode, string addres) : base(name, family, nationalCode, phoneNumber, addres)
        {
            Position = position;
        }

        public static HostelManager FindHostelManagerByFamily(string family)
        {
            HostelManager result = null;
            for (int i = 0; i < Lists.HostelManagerList.Count; i++)
            {
                if (Lists.HostelManagerList[i].Family == family)
                {
                    result = Lists.HostelManagerList[i];
                }
            }
            if (result == null)
            {
                Console.WriteLine("Hostel Manager Not Found");
            }
            return result;
        }

        public static HostelManager FindHostelManagerByNationalCode(long nationalcode)
        {
            HostelManager result = null;
            for (int i = 0; i < Lists.HostelManagerList.Count; i++)
            {
                if (Lists.HostelManagerList[i].NationalCode == nationalcode)
                {
                    result = Lists.HostelManagerList[i];
                }
            }
            if (result == null)
            {
                Console.WriteLine("Hostel Manager Not Found");
            }
            return result;
        }
    }
}

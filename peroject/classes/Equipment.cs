using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class Equipment
    {
        public string EqType {  get; set; }
        
        public int PartNumber
        {
            get { return PartNumber; }
            set
            {
                if (value >= 001 && value <= 005)
                {
                    PartNumber = value;
                }
                else
                {
                    Console.WriteLine("Invalid Part Number!");
                }
            }
        }
        public long PropNum
        {
            get { return PropNum; }
            set
            {
                if ( value >= 10000000 && value < 100000000)
                {
                    PropNum = value;
                }
                else
                {
                    Console.WriteLine("Invalid Property Number!");
                }
            }
        }
        public string Status
        {
            get { return Status; }
            set
            {
                if (value == "Intact" && value == "Damaged" && value == "Fixing")
                {
                    EqType = value;
                }
                else
                {
                    Console.WriteLine("Invalid Equipment Status!");
                }
            }
        }
        public Room EqRoom{ get; set; }
        public Student EqOwner{ get; set; }

        public Equipment(string eqType, int partNumber, long propNum, string status, Room eqRoom, Student eqOwner)
        {
            EqType = eqType;
            PartNumber = partNumber;
            PropNum = propNum;
            Status = status;
            EqRoom = eqRoom;
            EqOwner = eqOwner;
        }
        public Equipment(string eqType, int partNumber, long propNum)
        {
            EqType = eqType;
            PartNumber = partNumber;
            PropNum = propNum;
        }

    }
}

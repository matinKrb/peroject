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
        
        public string PartNumber { get; set; }

        public string PropNum { get; set; } 
        
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

        public Equipment(string eqType, string partNumber, String propNum, string status, Room eqRoom, Student eqOwner)
        {
            EqType = eqType;
            PartNumber = partNumber;
            PropNum = propNum;
            Status = status;
            EqRoom = eqRoom;
            EqOwner = eqOwner;
        }
        public Equipment(string eqType, string partNumber, string propNum)
        {
            EqType = eqType;
            PartNumber = partNumber;
            PropNum = propNum;
        }

    }
}

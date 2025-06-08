using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class ReportFixingRequest
    {
        public Student RequestfixingStudent;
        public Equipment FixingEquipment;

        public ReportFixingRequest(Student requestfixingStudent, Equipment fixingEquipment)
        {
            RequestfixingStudent =requestfixingStudent;
            FixingEquipment = fixingEquipment;
        }
    }
}

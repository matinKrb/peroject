using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class Person
    {

        
        public string Name { get; set; }
        public string Family { get; set; }
        public long NationalCode { get; set; }

        private string _phoneNumber;

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (value.Length == 11)
                {
                    _phoneNumber = value;
                }
                else
                {
                    Console.WriteLine("Invalid Phone Number!");
                }
            }
        }
        public string Addres { get; set; }

        public Person(string name, string family, long nationalCode, string phoneNumber, string addres)
        {
            Name = name;
            Family = family;
            NationalCode = nationalCode;
            PhoneNumber = phoneNumber;
            Addres = addres;
        }
    }
}

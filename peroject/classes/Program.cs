using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1 : create an account");
                Console.WriteLine("2 : Login to your account");
                int EnterOption = int.Parse(Console.ReadLine());

                switch (EnterOption) 
                {
                    case 1:
                        Console.WriteLine("1 : Im student ");
                        Console.WriteLine("2 : Im Hostel Manager ");
                        int SignUpOption = int.Parse(Console.ReadLine());

                        switch (SignUpOption)
                        {
                            case 1: 



                        }

                        break;
                        
                

                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sso_hack;


namespace LoadDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            SSO_SDK dll = new SSO_SDK();
            Console.WriteLine(dll.GetEmpnum());
            Console.WriteLine(dll.GetEmpName());
            Console.WriteLine(dll.GetEmpStatus());
        }
    }
}

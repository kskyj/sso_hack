using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace simpletest
{
    class Program
    {
        public static string path = @"c:\sso.txt";
        private static void SimpleFilePrint()
        {
            string empnumValue = File.ReadAllText(path, Encoding.Default);
            Console.WriteLine(empnumValue);
        }
        private static void SpecficLineFilePrint(int lineNumber)
        {
            string[] lines = File.ReadAllLines(path, Encoding.Default);
            Console.WriteLine(lines[lineNumber - 1]); 
        }
        static void Main(string[] args)
        {
            SimpleFilePrint();
            SpecficLineFilePrint(1);
            SpecficLineFilePrint(2);

        }
    }
}
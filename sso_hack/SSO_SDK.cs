using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sso_hack
{
    public class SSO_SDK
    {
        public string SpecficLineFilePrint(int lineNumber)
        {
            string path = @"c:\sso.txt";
            string[] lines = File.ReadAllLines(path, Encoding.Default);
            return (lines[lineNumber - 1]);
        }
        public string GetEmpnum()
        {
            string empnum = SpecficLineFilePrint(1);
            return empnum;
        }
        public string GetEmpName()
        {
            string empname = SpecficLineFilePrint(2);
            return empname;
        }
        public int GetEmpStatus()
        {
            return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace EXE_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Regex cmdRegEx = new Regex(@"/(?<name>.+?)=(?<val>.+)");

            Dictionary<string, string> cmdArgs = new Dictionary<string, string>();
            foreach (string s in args)
            {
                Match m = cmdRegEx.Match(s);
                if (m.Success)
                {
                    cmdArgs.Add(m.Groups[1].Value, m.Groups[2].Value);
                }
            }
            foreach (KeyValuePair<string, string> entry in cmdArgs)
            {
                Console.WriteLine(entry.Key+","+ entry.Value);
            }
            

            string root = @"C:\VTS";
            // If directory does not exist, create it. 
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
        }
    }
}

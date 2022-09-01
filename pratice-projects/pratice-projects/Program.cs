using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pratice_projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = File.ReadAllText("E:\\project-pratice\\pratice-project\\studentdata.txt");
            Console.WriteLine(data);
        }
    }
}

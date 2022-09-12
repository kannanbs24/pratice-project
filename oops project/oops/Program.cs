using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace oops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.gets();
            s.prints();
            s = new teacher();
            s.gets();
            s.prints();
            s = new subject();
            s.gets();
            s.prints();

        }
    }
}

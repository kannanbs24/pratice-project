using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class student
    {
        public string name;
        public int classes;
        public char section;
        
      public  virtual void gets()
        {
            Console.WriteLine("enter the student details");
            Console.WriteLine("-------------------");
            Console.WriteLine("enter the student name");
            name=Console.ReadLine();
            Console.WriteLine("enter the classes");
            classes=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the section");
            section=Convert.ToChar(Console.ReadLine());
        }
      public  virtual void prints()
        {
            Console.WriteLine("print the student details");
            Console.WriteLine(name);
            Console.WriteLine(classes);
            Console.WriteLine(section);
        }
    }
    public class teacher:student
    {
        public string subject;
        public override void gets()
        {
            Console.WriteLine("enter the teacher details");
            Console.WriteLine("-------------------");
            Console.WriteLine("enter the teacher name");
            name = Console.ReadLine();
            Console.WriteLine("enter the classes");
            classes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the section");
            section = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("enter the subject");
            subject = Console.ReadLine();
        }
        public override void prints()
        {
            Console.WriteLine("print the teacher details");
            Console.WriteLine(name);
            Console.WriteLine(classes);
            Console.WriteLine(section);
            Console.WriteLine(subject);
        }
    }
    public class subject : student
    {
        public string subject_code;
        public override void gets()
        {
            Console.WriteLine("enter the subject details");
            Console.WriteLine("-------------------");
            Console.WriteLine("enter the subject name");
            name = Console.ReadLine();
            Console.WriteLine("enter the subject code");
            subject_code = Console.ReadLine();
          
        }
        public override void prints()
        {
            Console.WriteLine("print the subject details");
            Console.WriteLine(name);
            Console.WriteLine(subject_code);
          
        }
    }

}

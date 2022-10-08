using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bal
{
    public class subjectcs
    {
        public int subjects_id1 { get; set; }
       public  string subjects_name1 { get; set; }
    }
    public class classes
    {
        public int class_roomno { get; set; }
        public int class_strength { get; set; }
    }
    public class student
    {
        public int student_id { get; set; }
        public string student_name { get; set; }
        public int student_class { get; set; }

    }
}

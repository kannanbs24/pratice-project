using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ballib;
using dallib;
namespace hellperlib
{
    public class Helper
    {
        DAL dal = null;
        public Helper()
        {
            dal = new DAL();
        }


        public bool Addmarks(BAL employee)
        {
            return dal.Insert(employee);

        }

        public bool Editmarks(BAL employee)
        {
            return dal.Update(employee);
        }

        public BAL searchmarks(int empid)
        {
            return dal.Find(empid);
        }
        public List<BAL> listmarks()
        {
            return dal.list();
        }
        public bool removemarks(int employee_id)
        {
            return dal.Delete(employee_id);
        }
    }
}

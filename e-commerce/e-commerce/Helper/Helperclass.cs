using BAL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class Helperclass
    {
        DAL1 dal = null;
        public Helperclass()
        {
            dal = new DAL1();
        }


        public bool AddE(Laptop school)
        {
            return dal.Insert(school);

        }

        public bool Edit(Laptop school)
        {
            return dal.Update(school);
        }

        public Laptop search(int id)
        {
            return dal.Find(id);
        }
        public List<Laptop> List()
        {
            return dal.List();
        }
        public bool remove(int id)
        {
            return dal.Delete(id);
        }
    }
}
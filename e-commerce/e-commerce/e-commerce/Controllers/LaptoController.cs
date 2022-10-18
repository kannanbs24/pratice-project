using BAL;
using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using e_commerce.Models;
namespace e_commerce.Controllers
{
    public class LaptoController : Controller
    {
        // GET: Lapto
        Helperclass helper = null;
        public LaptoController()
        {
            helper = new Helperclass();
        }

        public ActionResult Index()
        {
            var stulist = helper.List();
            List<laptop> modelsList = new List<laptop>();
            foreach (var item in stulist)
            {
                modelsList.Add(new laptop
                {
                    laptop_id = item.laptop_id,
                    laptop_name = item.laptop_name,
                    Cost = item.Cost,
                    Descr = item.Descr
                });
            }

            return View(modelsList);
        }
        public ActionResult Details(int id)
        {
            var data = helper.search(id);
            laptop emp = new laptop();
            emp.laptop_id = id;
            emp.laptop_name = data.laptop_name;
            emp.Cost = data.Cost;
            emp.Descr = data.Descr;

            return View(emp);

        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            Laptop bal = new Laptop();
            bal.laptop_id = Convert.ToInt32(Request["laptop_id"]);
            bal.laptop_name = Request["laptop_name"].ToString();
            bal.Cost = Convert.ToInt32(Request["Cost"]);
            bal.Descr = Request["Descr"].ToString();



            bool ans = helper.AddE(bal);
            if (ans)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            var emp = helper.search(id);
            laptop model = new laptop();
            model.laptop_id = id;
            model.laptop_name = emp.laptop_name;
            model.Cost = emp.Cost;
            model.Descr = emp.Descr;


            return View(model);
        }


        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var emp = helper.search(id);
                emp.laptop_id = Convert.ToInt32(Request["laptop_id"]);
                emp.laptop_name = Request["laptop_name"].ToString();
                emp.Cost = Convert.ToInt32(Request["Cost"]);
                emp.Descr = Request["Descr"].ToString();
                bool ans = helper.Edit(emp);


                if (ans)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }


            }
            catch
            {
                return View();
            }
        }


        public ActionResult Delete(int id)
        {
            var emp = helper.search(id);
            laptop model = new laptop();
            model.laptop_id = id;
            model.laptop_name = emp.laptop_name;
            model.Cost = emp.Cost;
            model.Descr = emp.Descr;



            return View(model);
        }


        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var dataFound = helper.search(id);
                if (dataFound != null)
                {
                    bool ans = helper.remove(id);
                    if (ans)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View();
                    }
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

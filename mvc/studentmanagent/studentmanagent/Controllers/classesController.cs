using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using helper;
using bussinesslogic;
using studentmanagent.Models;
namespace studentmanagent.Controllers
{
    public class classesController : Controller
    {
        Helper helper = null;
        public classesController()
        {
            helper = new Helper();
        }

        public ActionResult Index()
        {
            var stulist = helper.classList();
            List<classmodel> modelsList = new List<classmodel>();
            foreach (var item in stulist)
            {
                modelsList.Add(new classmodel
                {
                   class_id = item.class_id,
                    class_strength = item.class_strength

                });
            }

            return View(modelsList);
        }
        public ActionResult Details(int id)
        {
            var data = helper.searchclass(id);
            classmodel emp = new classmodel();
            emp.class_id = id;
            emp.class_strength = data.class_strength;


            return View(emp);

        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            BAL bal = new BAL();
            bal.class_id = Convert.ToInt32(Request["class_id"]);
            bal.class_strength = Request["class_strength"].ToString();
           


            bool ans = helper.Addclass(bal);
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
            var emp = helper.searchclass(id);
            classmodel model = new classmodel();
            model.class_id = id;
            model.class_strength = emp.class_strength;




            return View(model);
        }


        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var emp = helper.searchclass(id);
                emp.class_id = Convert.ToInt32(Request["class_id"]);
                emp.class_strength = Request["class_strength"].ToString();
                //       emp.student_class = Convert.ToInt32(Request["student_class"]);

                bool ans = helper.editclass(emp);


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
            var emp = helper.searchclass(id);
            classmodel model = new classmodel();
            model.class_id = id;
            model.class_strength = emp.class_strength;
            //    model.student_class = emp.student_class;



            return View(model);
        }


        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var dataFound = helper.searchclass(id);
                if (dataFound != null)
                {
                    bool ans = helper.removeclass(id);
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
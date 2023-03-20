using big_project_LT_Web_TEAM3.Models;
using Microsoft.AspNetCore.Mvc;

namespace big_project_LT_Web_TEAM3.Controllers
{
    public class TeacherController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var model = context.Teacher;
            return View(model);
        }
        public IActionResult Detail(int id)
        {
            var model = context.Teacher.FirstOrDefault(tc => tc.Id == id);
            return View(model);
        }
        public IActionResult Update(Teacher tc)
        {
            var model = context.Teacher.FirstOrDefault(tc2 => tc2.Id == tc.Id);
            if(model == null)
                return NotFound();
            {
                return View("Detail",model);
            }
        }
        public ActionResult Edit(Teacher tc)
        {
            var model = context.Teacher.FirstOrDefault(tc2=>tc2.Id == tc.Id);
            model = tc;
            return View(model);
        }
        public ActionResult Delete(Teacher tc)
        {
            var model = context.Teacher.FirstOrDefault(tc => tc.Id == tc.Id);
            
            if (model == null)
                return NotFound();
            {   
                context.Teacher.Remove(model);
                var newmodel = context.Teacher;
                return View("Index", newmodel);
            }
        }
        public IActionResult Create(Teacher tc)
        {
            return View();
        }
        public IActionResult CreateNew(Teacher tc)
        {
            context.Teacher.Add(tc);
            return View("Detail",tc);
        }

    }
}

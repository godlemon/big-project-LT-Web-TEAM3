using big_project_LT_Web_TEAM3.Models;
using Microsoft.AspNetCore.Mvc;

namespace big_project_LT_Web_TEAM3.Controllers
{
    public class TeacherController : Controller
    {
        private readonly Context context;
        public TeacherController(Context context)
        {
            this.context = context;
        }
        public  IActionResult Index()
        {
            var model = context.Teacher;
            return View(model);
        }
        public IActionResult Details(int id)
        {
            var model = context.Teacher.FirstOrDefault(tc => tc.Id == id);
            return View(model);
        }
        public IActionResult Update(Teacher tc)
        {
            var model = context.Teacher.FirstOrDefault(tc2 => tc.Id == tc2.Id);
            if (model == null)
                return NotFound();
            context.Entry(model).CurrentValues.SetValues(tc);
            context.SaveChanges();
            return View("Details", model);
        }
        public IActionResult Edit(Teacher tc)
        {
            var model = context.Teacher.FirstOrDefault(tc2=>tc.Id == tc2.Id);
            return View(model);
        }
        public ActionResult Delete(Teacher tc)
        {
            var model = context.Teacher.FirstOrDefault(tc1 => tc.Id == tc1.Id);
            
            if (model == null)
                return NotFound();
            {   
                context.Teacher.Remove(model);
                var newmodel = context.Teacher;
                context.SaveChanges();
                return View("Index", newmodel);
            }
        }
        public IActionResult Create(Teacher tc)
        {
            return View();
        }
        public IActionResult CreateNew(Teacher tc)
        {
            context.Add(tc);
            context.SaveChanges();
            return View("Details",tc);
            
        }

    }
}

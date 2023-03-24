using big_project_LT_Web_TEAM3.Models;
using Microsoft.AspNetCore.Mvc;

namespace big_project_LT_Web_TEAM3.Controllers
{
    public class ClassifyController : Controller
    {
        private readonly Context context;
        public ClassifyController(Context context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var model = context.Classify;
            return View(model);
        }
        public IActionResult Index1()
        {
            var model = context.Classify;
            return View(model);
        }
        public IActionResult Details(int id)
        {
            var model = context.Classify.FirstOrDefault(tc => tc.Id == id);
            return View(model);
        }
        public IActionResult Details1(int id)
        {
            var model = context.Classify.FirstOrDefault(tc => tc.Id == id);
            return View(model);
        }
        public IActionResult Update(Classify tc)
        {
            var model = context.Classify.FirstOrDefault(tc2 => tc.Id == tc2.Id);
            if (model == null)
                return NotFound();
            context.Entry(model).CurrentValues.SetValues(tc);
            context.SaveChanges();
            return View("Details", model);
        }
        public IActionResult Edit(Classify tc)
        {
            var model = context.Classify.FirstOrDefault(tc2 => tc.Id == tc2.Id);
            return View(model);
        }

        public ActionResult Delete(Classify tc)
        {
            var model = context.Classify.FirstOrDefault(tc1 => tc.Id == tc1.Id);

            if (model == null)
                return NotFound();
            {
                context.Classify.Remove(model);
                var newmodel = context.Classify;
                context.SaveChanges();
                return View("Index", newmodel);
            }

        }
        public IActionResult Create(Classify tc)
        {
            return View();
        }
        public IActionResult CreateNew(Classify tc)
        {
            context.Add(tc);
            context.SaveChanges();
            return View("Details", tc);

        }
    }
}

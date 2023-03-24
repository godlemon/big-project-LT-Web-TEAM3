using big_project_LT_Web_TEAM3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace big_project_LT_Web_TEAM3.Controllers
{
    public class DocumentController : Controller
    {
        private readonly Context context;
        public DocumentController(Context context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var model = context.Document.Include(d => d.Classify);
            return View(model);
        }
        public IActionResult Details(int id)
        {
            var model = context.Document.FirstOrDefault(tc => tc.Id == id);
            return View(model);
        }
        public IActionResult Update(Document tc)
        {
            var model = context.Document.FirstOrDefault(tc2 => tc.Id == tc2.Id);
            if (model == null)
                return NotFound();
            context.Entry(model).CurrentValues.SetValues(tc);
            context.SaveChanges();
            return View("Details", model);
        }
        public IActionResult Edit(Document tc)
        {
            var model = context.Document.FirstOrDefault(tc2 => tc.Id == tc2.Id);
            return View(model);
        }
        public ActionResult Delete(Document tc)
        {
            var model = context.Document.FirstOrDefault(tc1 => tc.Id == tc1.Id);

            if (model == null)
                return NotFound();
            {
                context.Document.Remove(model);
                var newmodel = context.Document;
                context.SaveChanges();
                return View("Index", newmodel);
            }

        }
        public IActionResult Create(Document tc)
        {
            ViewData["Classify"] = context.Classify.ToArray();
            return View();
        }
        public IActionResult CreateNew(Document tc, int classify)
        {
            tc.Classify = context.Classify.FirstOrDefault(c => c.Id == classify);
            context.Add(tc);
            context.SaveChanges();
            return View("Details", tc);

        }
    }
}

using big_project_LT_Web_TEAM3.Models;
using Microsoft.AspNetCore.Mvc;

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
            var model = context.Document;
            return View(model);
        }
        public IActionResult Detail(int id)
        {
            var model = context.Document.FirstOrDefault(tc => tc.Id == id);
            return View(model);
        }
        public IActionResult Update(Document tc)
        {
            var model = context.Document.FirstOrDefault(tc2 => tc2.Id == tc.Id);
            if (model == null)
                return NotFound();
            {
                return View("Detail", model);
            }
            context.SaveChanges();
        }
        public ActionResult Edit(Document tc)
        {
            var model = context.Document.FirstOrDefault(tc2 => tc2.Id == tc.Id);
            model = tc;
            return View(model);
            context.SaveChanges();
        }
        public ActionResult Delete(Document tc)
        {
            var model = context.Document.FirstOrDefault(tc => tc.Id == tc.Id);

            if (model == null)
                return NotFound();
            {
                context.Document.Remove(model);
                var newmodel = context.Document;
                return View("Index", newmodel);
            }
            context.SaveChanges();
        }
        public IActionResult Create(Document tc)
        {
            return View();
        }
        public IActionResult CreateNew(Document tc)
        {
            context.Document.Add(tc);
            return View("Detail", tc);
            context.SaveChanges();
        }
    }
}

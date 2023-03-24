using big_project_LT_Web_TEAM3.Models;
using Microsoft.AspNetCore.Mvc;

namespace big_project_LT_Web_TEAM3.Controllers
{
    public class SendDocumentController : Controller
    {
        private readonly Context context;
        public SendDocumentController(Context context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var model = context.SendDocument;
            return View(model);
        }
        public IActionResult Details(int id)
        {
            var model = context.SendDocument.FirstOrDefault(tc => tc.Id == id);
            return View(model);
        }
        public IActionResult Update(SendDocument tc)
        {
            var model = context.SendDocument.FirstOrDefault(tc2 => tc.Id == tc2.Id);
            if (model == null)
                return NotFound();
            context.Entry(model).CurrentValues.SetValues(tc);
            context.SaveChanges();
            return View("Details", model);
        }
        public IActionResult Edit(SendDocument tc)
        {
            var model = context.SendDocument.FirstOrDefault(tc2 => tc.Id == tc2.Id);
            return View(model);
        }
        public ActionResult Delete(SendDocument tc)
        {
            var model = context.SendDocument.FirstOrDefault(tc1 => tc.Id == tc1.Id);

            if (model == null)
                return NotFound();
            {
                context.SendDocument.Remove(model);
                var newmodel = context.SendDocument;
                context.SaveChanges();
                return View("Index", newmodel);
            }
        }
        public IActionResult Create(SendDocument tc)
        {
            return View();
        }
        public IActionResult CreateNew(SendDocument tc)
        {
            context.Add(tc);
            context.SaveChanges();
            return View("Details", tc);

        }
    }
}

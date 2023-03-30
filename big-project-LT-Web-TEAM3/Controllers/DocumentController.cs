using big_project_LT_Web_TEAM3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Text;

namespace big_project_LT_Web_TEAM3.Controllers
{
    public class DocumentController : Controller
    {
        private readonly Context context;
        public DocumentController(Context context)
        {
            this.context = context;
        }

        public IActionResult Index(int page = 1, string orderBy = "DocumentName", bool dsc = false)
        {
            var model = context.Paging(page, orderBy, dsc);
            
            ViewData["Pages"] = model.pages;
            ViewData["Page"] = model.page;
            ViewData["DocumentName"] = false;
            ViewData["WhiterName"] = false;
            ViewData["Filename"] = false;
            ViewData["EndDate"] = false;
            ViewData["Classifys"] = false;
            ViewData[orderBy] = !dsc;
            return View(model.documents);
        }
        public IActionResult Details(int id)
        {
            var model = context.Document.Include(d => d.Classifys).FirstOrDefault(tc => tc.Id == id);
            return View(model);
        }
        public IActionResult Update(Document tc, int classifyId, IFormFile file)
        {
            var model = context.Document.Include(d => d.Classifys).FirstOrDefault(tc2 => tc.Id == tc2.Id);

            if (model == null)
                return NotFound();
            tc.Classifys = context.Classify.FirstOrDefault(c => c.Id == classifyId);
            if (file == null)
            {
                file = new FormFile(new MemoryStream(Encoding.UTF8.GetBytes("default")), 0, 0, "default", "Trống.txt");
            }
            context.Upload(tc, file);

            context.Entry(model).CurrentValues.SetValues(tc);
            context.SaveChanges();
            return View("Details", model);
        }
        public IActionResult Edit(Document tc)
        {
            ViewData["Classify"] = context.Classify.ToArray();
            var model = context.Document.Include(d => d.Classifys).FirstOrDefault(tc2 => tc.Id == tc2.Id);
            return View(model);
        }
        public ActionResult Delete(Teacher tc)
        {
            var model = context.Document.Include(d => d.Classifys).FirstOrDefault(tc1 => tc.Id == tc1.Id);

            if (model == null)
                return NotFound();
            {
                context.Document.Remove(model);
                var newmodel = context.Document;
                context.SaveChanges();
                return View("Index", newmodel);
            }
        }

        public IActionResult Create()
        {
            ViewData["Classify"] = context.Classify.ToArray();

            return View();
        }
        public async Task<IActionResult> CreateNew(Document tc, int classify, IFormFile file)
        {
            
            tc.Classifys = context.Classify.FirstOrDefault(c => c.Id == classify);
            tc.state = true;
            if(file == null)
            {
                file = new FormFile(new MemoryStream(Encoding.UTF8.GetBytes("default")), 0, 0, "default", "Trống.txt");
            }
            context.Upload(tc, file);

            context.Add(tc);
            context.SaveChanges();
            return View("Details", tc);
        }
        public IActionResult Read(int id)
        {
            var b = context.Document.Include(d => d.Classifys).FirstOrDefault(tc => tc.Id == id);
            if (b == null) return NotFound();
            if (!System.IO.File.Exists(context.GetDataPath(b.Filename))) return NotFound();
            var (stream, type) = context.Download(b);
            return File(stream, type, b.Filename);
        }
        public IActionResult Search(string term)
        {
            var newmodel = context.Document;
            if (term == null) return View("index", newmodel);
            return View("Index", context.Get(term));
        }
    }

}

using big_project_LT_Web_TEAM3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
        public IActionResult Create(int dcm,int tcm)
        {
            var documents = context.Document.ToList();
            var documentList = new SelectList(documents, "Id", "DocumentName");
            TempData["Documents"] = documentList;
            var teachers = context.Teacher.ToList();
            var teacherlist = new SelectList(teachers, "Id", "TenGV");
            TempData["Teachers"] = teacherlist;
            var sendDocument = new SendDocument
            {
                DocumentId = dcm,
                TeacherId = tcm
            };
            return View(sendDocument);
        }
        public IActionResult CreateNew(SendDocument sendDocument, int dcm, string file)
        {
            sendDocument.SendTime = DateTime.Now;
            var document = context.Document.FirstOrDefault(d => d.Id == sendDocument.DocumentId);
            var teacher = context.Teacher.FirstOrDefault(d => d.Id == sendDocument.TeacherId);
            if (document != null && teacher != null)
            {
                sendDocument.SendedDocument = document.DocumentName;
                sendDocument.DocumentOwer = document.WhiterName;
                sendDocument.DocumentId = document.Id;
                sendDocument.FileDocument = document.Filename;
                sendDocument.receiver = teacher.TenGV;
                context.Add(sendDocument);
                context.SaveChanges();
                return View("Details", sendDocument);
            }
            else
            {
                return NotFound();
            }
        }


    }
}

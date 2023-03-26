using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using static System.Reflection.Metadata.BlobBuilder;

namespace big_project_LT_Web_TEAM3.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Document> Document { get; set; }
        public DbSet<SendDocument> SendDocument { get; set; }  
        public DbSet<Classify> Classify { get; set; }

        public string GetDataPath(string file) => $"Data\\{file}";
        public void Upload(Document document, IFormFile file)
        {
            if (file != null)
            {
                var path = GetDataPath(file.FileName);
                using var stream = new FileStream(path, FileMode.Create);
                file.CopyTo(stream);
                document.Filename = file.FileName;
            }
        }
        public (Stream, string) Download(Document b)
        {
            var memory = new MemoryStream();
            using var stream = new FileStream(GetDataPath(b.Filename), FileMode.Open);
            stream.CopyTo(memory);
            memory.Position = 0;
            var type = Path.GetExtension(b.Filename) switch
            {
                "pdf" => "application/pdf",
                "docx" => "application/vnd.ms-word",
                "doc" => "application/vnd.ms-word",
                "txt" => "text/plain",
                _ => "application/pdf"
            };
            return (memory, type);
        }
        public Document[] Get(string search)
        {
            var s = search.ToLower();
            return Document.Where(b =>
                b.DocumentName.ToLower().Contains(s) ||
                b.WhiterName.ToLower().Contains(s) ||
                b.Filename.ToLower().Contains(s) ||
                b.EndDate.ToString() == s
            ).ToArray();
        }

        public (Document[] documents, int pages, int page) Paging(int page, string orderBy = "DocumentName", bool dsc = false)
        {
            int size = 5;
            var allDocuments = Document.Include(d => d.Classifys).ToList();
            int pages = (int)Math.Ceiling((double)allDocuments.Count / size);
            var documents = allDocuments.Skip((page - 1) * size).Take(size).AsQueryable().OrderBy($"{orderBy} {(dsc ? "descending" : "")}").ToArray();
            return (documents, pages, page);
        }
        
    }
}

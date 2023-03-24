using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace big_project_LT_Web_TEAM3.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Document> Document { get; set; }
        public DbSet<SendDocument> SendDocument { get; set; }  
        public DbSet<Classify> Classify { get; set; }
    }
}

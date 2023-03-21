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
        public DbSet<classify> classify { get; set; }
        public Context()
        {
            { 
                Teacher.Add(new Teacher { Id = 1, TenGV = "Nguyễn Thùy Dung", ChucVuGV = "Hiệu trưởng"});
                Teacher.Add(new Teacher { Id = 2, TenGV = "Nguyễn Văn Chính", ChucVuGV = "Trường khoa" });
                Teacher.Add(new Teacher { Id = 3, TenGV = "Koro sensei", ChucVuGV = "Giáo viên E6" });
                Teacher.Add(new Teacher { Id = 4, TenGV = "Gojou Satouru", ChucVuGV = "Giáo viên" });
            }

        }
    }
}

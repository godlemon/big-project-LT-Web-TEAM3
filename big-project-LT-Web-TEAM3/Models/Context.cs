using Microsoft.CodeAnalysis;

namespace big_project_LT_Web_TEAM3.Models
{
    public class Context
    {
        public List<Teacher> Teacher { get; set; }
        public List<Document> Document { get; set; }
        public Context()
        {
            Teacher = new List<Teacher>();
            { 
                Teacher.Add(new Teacher { IdTeacher = 1, TenGV = "Nguyễn Thùy Dung", ChucVuGV = "Hiệu trưởng"});
                Teacher.Add(new Teacher { IdTeacher = 2, TenGV = "Nguyễn Văn Chính", ChucVuGV = "Trường khoa" });
                Teacher.Add(new Teacher { IdTeacher = 3, TenGV = "Koro sensei", ChucVuGV = "Giáo viên E6" });
                Teacher.Add(new Teacher { IdTeacher = 4, TenGV = "Gojou Satouru", ChucVuGV = "Giáo viên" });
            }
            Document = new List<Document>();
            {
            }
            
        }
    }
}

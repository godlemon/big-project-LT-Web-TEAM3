namespace big_project_LT_Web_TEAM3.Models
{
    public class Content
    {
        public List<Teacher> Teacher { get; set; }
        public List<Document> Document { get; set; }
        public Content()
        {
            Teacher = new List<Teacher>();
            { 
                Teacher.Add(new Teacher { Id = 1, TenGV = "Nguyễn Thùy Dung", ChucVuGV = "Hiệu trưởng"});
                Teacher.Add(new Teacher { Id = 2, TenGV = "Nguyễn Văn Chính", ChucVuGV = "Trường khoa" });
                Teacher.Add(new Teacher { Id = 3, TenGV = "Koro sensei", ChucVuGV = "Giáo viên E6" });
                Teacher.Add(new Teacher { Id = 4, TenGV = "Gojou Satouru", ChucVuGV = "Giáo viên" });
            }
            
        }
    }
}

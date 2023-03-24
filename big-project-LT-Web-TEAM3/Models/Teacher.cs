using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace big_project_LT_Web_TEAM3.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required, DisplayName("Tên giáo viên")]
        public string TenGV { get; set; }
        [Required, DisplayName("Chức vụ giáo viên")]
        public string ChucVuGV { get; set; }
    }
}

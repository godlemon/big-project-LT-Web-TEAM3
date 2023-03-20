using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace big_project_LT_Web_TEAM3.Models
{
    public class Document
    {
        [Required]
        public int IdDocument { get; set; }
        [Required, DisplayName("Người Viết")]
        public string WhiteName { get; set; }
        [Required, DisplayName("Hạn lưu trữ")]
        public DateTime EndDate { get; set; }
        [Required, DisplayName("Người Viết")]
        public string Classify { get; set; }
    }
}

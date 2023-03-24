using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace big_project_LT_Web_TEAM3.Models
{
    public class Document
    {
        [Required]
        public int Id { get; set; }

        [Required, DisplayName("Tên văn bản")]
        public string DocumentName { get; set; }
        [Required, DisplayName("Người Viết")]
        public string WhiterName { get; set; }
        [Required, DisplayName("Hạn lưu trữ")]
        public DateTime EndDate { get; set; }
        [Required, DisplayName("Phân loại")]
        public Classify Classify { get; set; }
    }
}

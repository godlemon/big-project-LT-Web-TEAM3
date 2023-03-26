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
        [DisplayName("Người Viết")]
        public string WhiterName { get; set; }
        [DisplayName("Tên file")]
        public string Filename { get; set; }
        [Required, DisplayName("Hạn lưu trữ")]
        public DateTime EndDate { get; set; }
        [Required]
        public Boolean state { get; set; }
        [Required, DisplayName("Phân loại")]
        public Classify Classifys { get; set; }

        public ICollection<SendDocument> SendDocuments { get; set; }
    }
}

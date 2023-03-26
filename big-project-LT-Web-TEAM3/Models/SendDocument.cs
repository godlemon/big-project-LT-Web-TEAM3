using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace big_project_LT_Web_TEAM3.Models
{
    public class SendDocument
    {
        [Required]
        public int Id { get; set; }
        [Required, DisplayName("Người nhận")]
        public string receiver { get; set; }
        [Required, DisplayName("Người Viết")]
        public string DocumentOwer { get; set; }
        [Required, DisplayName("Văn bản gửi")]
        public string SendedDocument { get; set; }

        [DisplayName("File đính kèm")]
        public string FileDocument { get; set; }
        [Required, DisplayName("Ngày gửi")]
        public DateTime SendTime { get; set; }
        [DisplayName("Văn bản")]
        public int DocumentId { get; set; }
        public Document Document { get; set; }
        [DisplayName("Giáo viên")]
        public int TeacherId { get; set; }
        public Teacher Teacher  { get; set; }
    }
}

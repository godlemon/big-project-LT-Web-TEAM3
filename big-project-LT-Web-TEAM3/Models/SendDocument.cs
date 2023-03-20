using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace big_project_LT_Web_TEAM3.Models
{
    public class SendDocument
    {
        [Required]
        public int Id { get; set; }
        public Teacher teacher { get; set; }
        public Document Document { get; set; }
    }
}


using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace big_project_LT_Web_TEAM3.Models
{
    public class Classify
    {
        [Required]
        public int Id { get; set; }
        [Required, DisplayName("Tên loại văn bản")]
        public string Name { get; set; }
        [Required, DisplayName("Miêu tả")]
        public string Description { get; set; }
        public ICollection<Document> Tags { get; set; }
    }
}

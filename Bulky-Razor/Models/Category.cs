using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Bulky_Razor.Models
{
    public class Category
    {
        [Key]//primary key ,Id will be primary key automatically
        public int Id { get; set; }
        [Required]//not null
        [DisplayName("Category Name")]
        [MaxLength(300)]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Order must be greater than 0 and less than 100")]
        public int DisplayOrder { get; set; }
    }
}

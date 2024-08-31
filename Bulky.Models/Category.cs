using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bulky.Models
{
    public class Category
    {
        [Key]//primary key ,Id will be primary key automatically
        public int Id { get; set; }
        [Required]//not null
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Order must be greater than 0 and less than 100")]
        public int DisplayOrder { get; set; }

    }
}

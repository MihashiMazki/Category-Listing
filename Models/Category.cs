using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace learning.Models
{
	public class Category
	{
        [Key]
        public int id { get; set; }

        [Required]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1,1000,ErrorMessage ="RAWR!")]
        public int DisplayOrder { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}

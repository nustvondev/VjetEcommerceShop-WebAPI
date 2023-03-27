using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VjetEcommerce.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        [MaxLength(250)]
        public string ID { set; get; }

        [Required]
        public string Content { set; get; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VjetEcommerce.Model.Models
{
    [Table("SupportOnlines")]
    public class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        [MaxLength(50)]
        public string Department { set; get; }

        

        [MaxLength(50)]
        public string Phone { set; get; }

        [MaxLength(50)]
        public string Email { set; get; }


        [MaxLength(50)]
        public string Facebook { set; get; }

        public bool Status { set; get; }

      
    }
}
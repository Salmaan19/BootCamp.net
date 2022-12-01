using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameWork.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Column("varchar")]
        public string Name { get; set; }

        public string Email { get; set; }

        public int age { get; set; }
    }
}

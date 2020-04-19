using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EdujarBackend.Models.Schema
{
    [Table("Teachers")]
    public class Teacher 
    {
        [Key]
        public int TeacherId { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }
        
        public virtual User User { get; set; }
    }
}
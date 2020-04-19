using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EdujarBackend.Models.Schema
{
    [Table("Students")]
    public class Student 
    {
        [Key]
        public int StudentId { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }
        
        public virtual User User { get; set; }

        [ForeignKey("ParentId")]
        public int ParentId {get; set; }

        public virtual Parent Parent {get; set; }

        [ForeignKey("PerformanceId")]
        public int PerformanceId {get; set; }

        public virtual Performance Performance {get; set; }

    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EdujarBackend.Models.Schema
{
    [Table("Parents")]
    public class Parent 
    {
        [Key]
        public int ParentId { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

         [ForeignKey("EventId")]
        public int EventId { get; set; }
        
        public virtual Event Event{ get; set; }

    }
}
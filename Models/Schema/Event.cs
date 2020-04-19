using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EdujarBackend.Models.Schema
{
    [Table("Eventos")]
    public class Event 
    {
        [Key]
        public int EventId { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Date {get; set; }

        public string Location {get; set; }


    }
}
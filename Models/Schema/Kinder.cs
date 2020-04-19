using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EdujarBackend.Models.Schema
{
    [Table("Kinders")]
    public class Kinder 
    {
        [Key]
        public int KinderId { get; set; }

        public int Number { get; set; }

        public bool AoB {get; set; }
    }
}
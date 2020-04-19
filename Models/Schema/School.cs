using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EdujarBackend.Models.Schema
{
    [Table("Schools")]
    public class School 
    {
        [Key]
        public int SchoolID { get; set; }

        public string LegalName { get; set; }

        public string History {get; set; }
    }
}
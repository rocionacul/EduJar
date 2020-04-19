using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EdujarBackend.Models.Schema
{
    [Table("Performances")]
    public class Performance 
    {
        [Key]
        public int PerformanceId { get; set; }

        public string PeriodCovered { get; set; }

        public string Description {get; set; }
    }
}
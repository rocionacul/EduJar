using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EdujarBackend.Models.Schema
{
    [Table("Games")]
    public class Game 
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Level {get; set;}
        public string Objective {get; set;}
        public int LessExpected {get; set; }
        public int Result {get; set; }
        public bool Enabled {get; set; }
        public byte[] Binary { get; set; }
    }
}
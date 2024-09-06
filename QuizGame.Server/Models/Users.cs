using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizGame.Server.Models
{
    public class Users
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName = "char(50)")]
        [Required]
        public string name { get; set; }
        [Column(TypeName = "char(50)")]
        [Required]
        public string email { get; set; }
        [Column(TypeName = "char(50)")]
        public string? password { get; set; }
        public int? score { get; set; }
        public int? quiz_time { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizGame.Server.Models
{
    public class OperatingSystems
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName="char(250)")]
        public string questions  { get; set; }
        [Column(TypeName = "char(100)")]
        public string image_name { get; set; }
        [Column(TypeName = "char(100)")]
        public string a_answer { get; set; }
        [Column(TypeName = "char(100)")]
        public string b_answer{ get; set; }
        [Column(TypeName = "char(100)")]
        public string c_answer { get; set; }
        [Column(TypeName = "char(100)")]
        public string d_answer { get; set; }
        [Column(TypeName = "char(100)")]
        public string correct_answer { get; set; }
    }
}

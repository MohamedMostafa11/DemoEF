using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoEF.Models
{
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int teacherId { get; set; }
        [MinLength(10)]
        [MaxLength(60)]
        public string teacherName { get; set; }
        [Range(23,70)]
        public int teacherage { get; set; }
    }
}

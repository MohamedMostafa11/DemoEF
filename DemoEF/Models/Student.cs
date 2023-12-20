using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoEF.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int studentId { get; set; }
        [MinLength(5)]
        [MaxLength(50)]
        public string studentName { get; set; }
        public bool IsActive { get; set; }
        [Range(6,18)]
        public int studentage { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApiDemo.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]// this is pk col in DB
        public int Rollno { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Percentage { get; set; }

        [Required]
        public int City { get; set; }


    }
}

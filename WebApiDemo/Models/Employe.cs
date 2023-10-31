using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApiDemo.Models
{
    [Table("Employe")]
    public class Employe
    {
        [Key]// this is pk col in DB
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public int Salary { get; set; }


    }
}

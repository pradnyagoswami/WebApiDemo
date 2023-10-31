using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApiDemo.Models
{
    
      [Table("Book")]
        public class Book
        {
            [Key]// this is pk col in DB
            public int Id { get; set; }

            [Required]
            public string? Name { get; set; }

            [Required]
            public string? Author { get; set; }

            [Required]
            public int Price { get; set; }


        }



    }


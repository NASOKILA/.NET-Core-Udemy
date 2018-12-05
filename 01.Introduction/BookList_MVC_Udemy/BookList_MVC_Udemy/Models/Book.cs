using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookList_MVC_Udemy.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        [MaxLength(9, ErrorMessage = "The ISBN must not be more then 9 characters long.")]
        public string ISBN { get; set; }
        
        public bool Avaliable { get; set; }
    }
}

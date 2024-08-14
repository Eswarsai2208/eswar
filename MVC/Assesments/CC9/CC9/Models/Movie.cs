using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CC9.Models
{
    public class Movie
    {
        [Key]
        public int Mid { get; set; }

        [Required]
        [StringLength(100)]
        public string Moviename { get; set; }

        [Required]
        public DateTime DateofRelease { get; set; }
    }
}
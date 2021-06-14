using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lecture5.Models
{
    public class Product
    {
        public string Id { get; set; }
        [Required]
        //[Required(ErrorMessage = "Please put your name")]
        public string Name { get; set; }
        [Required]
        [Range(1, 160)]
        public int Credit { get; set; }
        [Required]
        public double Cgpa { get; set; }
        [Required]
        public DateTime Dob { get; set; }
        [Required]
        public string Dept_id { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
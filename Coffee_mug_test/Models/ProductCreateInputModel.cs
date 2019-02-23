using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee_mug_test.Models
{
    public class ProductCreateInputModel
    {
        [Required]
        [MaxLength(100, ErrorMessage = "Name is too long")]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}

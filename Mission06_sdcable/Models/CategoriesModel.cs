using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_sdcable.Models
{
    public class CategoriesModel
    {
            [Key]
            [Required]
            public int CategoryId { get; set; }
            public string Category { get; set; }
    }
}

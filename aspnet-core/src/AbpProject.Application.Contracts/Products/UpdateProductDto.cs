using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AbpProject.Products
{
    public class UpdateProductDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        public ProductType Type { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime UpdateDate { get; set; } = DateTime.Now;

        [Required]
        public float Price { get; set; }
    }
}

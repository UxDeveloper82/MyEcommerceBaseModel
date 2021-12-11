using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcommerceBaseModel.Models
{
    public class ProductTypes
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Product Type")]
        public string ProductType { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Shop.Models
{
    public class Customers
    {
        [Key]
        public int ID  { get; set; }
        [MaxLength(100)]
        public String Name { get; set; }
        public int Price { get; set; }
    }
}

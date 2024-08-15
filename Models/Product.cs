using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Models
{
    internal class Product
    {
        public int ProdId { get; set; }
        public string Name { get; set; }
        [Range(5,500)]
        public double Price { get; set; }
    }
}

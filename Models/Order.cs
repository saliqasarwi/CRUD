using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Models
{
    internal class Order
    {
        public int OrdId { get; set; }

        public string Address { get; set; }

        public DateTime createdAt { get; set; }
    }
}

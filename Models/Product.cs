using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveBranchBakes.Models
{
    public abstract class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = "";
        public string Category { get; set; } = "";
        public decimal Price { get; set; }

        public abstract bool IsAvailable(DateTime date);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnionArchitectureApp.Domain.Common;

namespace OnionArchitectureApp.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public int Quantity { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Domain.Common
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; } 
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Application.Dto
{
    public class ProductViewDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }= string.Empty;
    }
}
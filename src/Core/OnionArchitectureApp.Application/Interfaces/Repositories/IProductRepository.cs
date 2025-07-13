using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnionArchitectureApp.Domain.Entities;

namespace OnionArchitectureApp.Application.Interfaces.Repositories
{
    public interface IProductRepository : IGenericRepositoryAsync<Product>
    {
        
    }
}
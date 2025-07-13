using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnionArchitectureApp.Application.Wrappers;
using MediatR;
using OnionArchitectureApp.Application.Dto;

namespace OnionArchitectureApp.Application.Features.Queries.GetProductById
{
   
    public class GetProductByIdQuery : IRequest<ServiceResponse<GetProductByIdViewModel>>
    {
        public Guid Id { get; set; }
    }
}
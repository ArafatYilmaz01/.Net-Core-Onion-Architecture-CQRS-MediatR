using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using OnionArchitectureApp.Application.Dto;
using OnionArchitectureApp.Application.Interfaces.Repositories;
using OnionArchitectureApp.Application.Wrappers;

namespace OnionArchitectureApp.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQueryHandler:IRequestHandler<GetProductByIdQuery, ServiceResponse<GetProductByIdViewModel>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductByIdQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<GetProductByIdViewModel>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.Id);
            var viewModel = _mapper.Map<GetProductByIdViewModel>(product);

            return new ServiceResponse<GetProductByIdViewModel>(viewModel);
        }
    }
  
}
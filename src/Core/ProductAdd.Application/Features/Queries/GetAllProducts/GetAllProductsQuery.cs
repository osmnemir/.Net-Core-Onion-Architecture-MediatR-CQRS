using AutoMapper;
using MediatR;
using ProductAdd.Application.Dto;
using ProductAdd.Application.Interfaces.Repository;
using ProductAdd.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAdd.Application.Features.Queries.GetAllProducts
{
    public class GetAllProductsQuery:IRequest<List<ProductViewDto>>
    {
        public class GetAllProductQueryHandler : IRequestHandler<GetAllProductsQuery, ServiceResponse<List<ProductViewDto>>>
        {
            private readonly IProductRepository _productRepository;
            private readonly IMapper mapper;

            public GetAllProductQueryHandler(IProductRepository productRepository, IMapper mapper)
            {
                _productRepository = productRepository;
                this.mapper = mapper;
            }
            public async Task<ServiceResponse<List<ProductViewDto>>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
            {
                var products = await _productRepository.GetAllAsync();
                var viewModel = mapper.Map<List<ProductViewDto>>(products);

                return new ServiceResponse<List<ProductViewDto>>(viewModel);
            }
        }
    }
}

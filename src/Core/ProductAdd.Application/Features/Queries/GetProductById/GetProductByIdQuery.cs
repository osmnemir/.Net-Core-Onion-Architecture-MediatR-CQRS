using AutoMapper;
using MediatR;
using ProductAdd.Application.Interfaces.Repository;
using ProductAdd.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAdd.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<ServiceResponse<GetProductByIdViewModel>>
    {
        public Guid Id { get; set; }

        public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ServiceResponse<GetProductByIdViewModel>>
        {
            private readonly IMapper mapper;
            private readonly IProductRepository productRepository;

            public GetProductByIdQueryHandler(IMapper mapper, IProductRepository productRepository)
            {
                this.mapper = mapper;
                this.productRepository = productRepository;
            }
            public async Task<ServiceResponse<GetProductByIdViewModel>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
            {
                var product = await productRepository.GetByIdAsync(request.Id);
                var dto = mapper.Map<GetProductByIdViewModel>(product);
                return new ServiceResponse<GetProductByIdViewModel>(dto);
            }
        }
    }
}

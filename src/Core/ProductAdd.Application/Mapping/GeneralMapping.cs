using AutoMapper;
using ProductAdd.Application.Dto;
using ProductAdd.Application.Features.Commands.CreateProduct;
using ProductAdd.Application.Features.Queries.GetProductById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAdd.Application.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<ProductApp.Domain.Entities.Product, ProductViewDto>().ReverseMap();
            CreateMap<ProductApp.Domain.Entities.Product, CreateProductCommand>().ReverseMap();
            CreateMap<ProductApp.Domain.Entities.Product, GetProductByIdViewModel>().ReverseMap();
        }
    }
}

using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAdd.Application.Features.Commands.CreateProduct;
using ProductAdd.Application.Features.Queries.GetAllProducts;
using ProductAdd.Application.Features.Queries.GetProductById;
using ProductAdd.Application.Interfaces.Repository;

namespace ProductApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllProductsQuery();
            return Ok(await mediator.Send(query));
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var query = new GetProductByIdQuery() { Id = id };
            return Ok(await mediator.Send(query));
        }


        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCommand createProduct)
        {

            return Ok(await mediator.Send(createProduct));
        }
    }
}

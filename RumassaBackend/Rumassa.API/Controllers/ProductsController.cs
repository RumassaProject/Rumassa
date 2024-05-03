using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rumassa.Application.UseCases.CatalogCases.Commands;
using Rumassa.Application.UseCases.CatalogCases.Queries;
using Rumassa.Domain.Entities.DTOs;
using Rumassa.Domain.Entities;
using Rumassa.Application.UseCases.ProductCases.Queries;
using Rumassa.Application.UseCases.ProductCases.Commands;

namespace Rumassa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IMediator _mediator;
        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ResponseModel> Create(CreateProductCommand request)
        {
            var result = await _mediator.Send(request);

            return result;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> GetAll(int pageIndex, int size)
        {
            var result = await _mediator.Send(new GetAllProductsQuery
            {
                PageIndex = pageIndex,
                Size = size
            });

            return result;
        }

        [HttpGet("{id}")]
        public async Task<Product> GetById()
        {
            var result = await _mediator.Send(new GetProductByIdQuery());

            return result;
        }

        [HttpPut("{id}")]
        public async Task<ResponseModel> Update(UpdateProductCommand request)
        {
            var result = await _mediator.Send(request);

            return result;
        }

        [HttpDelete("{id}")]
        public async Task<ResponseModel> Delete(DeleteProductCommand request)
        {
            var result = await _mediator.Send(request);

            return result;
        }

    }
}

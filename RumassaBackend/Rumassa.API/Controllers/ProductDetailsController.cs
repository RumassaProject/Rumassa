using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rumassa.Domain.Entities.DTOs;
using Rumassa.Domain.Entities;
using Rumassa.Application.UseCases.ProductDetailsCases.Commands;
using Rumassa.Application.UseCases.ProductDetailsCases.Queries;

namespace Rumassa.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductDetailsController : ControllerBase
    {

        private readonly IMediator _mediator;
        public ProductDetailsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ResponseModel> Create(CreateProductDetailsCommand request)
        {
            var result = await _mediator.Send(request);

            return result;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductDetails>> GetAll()
        {
            var result = await _mediator.Send(new GetAllProductDetailsQuery());

            return result;
        }

        [HttpGet]
        public async Task<ProductDetails> GetById(Guid id)
        {
            var result = await _mediator.Send(new GetProductDetailByIdQuery()
            {
                Id = id
            });

            return result;
        }

        [HttpPut]
        public async Task<ResponseModel> Update(UpdateProductDetailsCommand request)
        {
            var result = await _mediator.Send(request);

            return result;
        }

        [HttpDelete]
        public async Task<ResponseModel> Delete(DeleteProductDetailsCommand request)
        {
            var result = await _mediator.Send(request);

            return result;
        }

    }
}

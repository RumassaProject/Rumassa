using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rumassa.Application.UseCases.CatalogCases.Commands;
using Rumassa.Application.UseCases.CatalogCases.Queries;
using Rumassa.Domain.Entities.DTOs;
using Rumassa.Domain.Entities;
using Rumassa.Application.UseCases.OrderCases.Commands;
using Rumassa.Application.UseCases.OrderCases.Queries;

namespace Rumassa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private readonly IMediator _mediator;
        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ResponseModel> Create(CreateOrderCommand request)
        {
            var result = await _mediator.Send(request);

            return result;
        }

        [HttpGet]
        public async Task<IEnumerable<Order>> GetAll()
        {
            var result = await _mediator.Send(new GetAllOrdersQuery());

            return result;
        }

        [HttpGet("{id}")]
        public async Task<Order> GetById()
        {
            var result = await _mediator.Send(new GetOrderByIdQuery());

            return result;
        }

        [HttpPut("{id}")]
        public async Task<ResponseModel> Update(UpdateOrderCommand request)
        {
            var result = await _mediator.Send(request);

            return result;
        }

        [HttpDelete("{id}")]
        public async Task<ResponseModel> Delete(DeleteOrderCommand request)
        {
            var result = await _mediator.Send(request);

            return result;
        }

    }
}

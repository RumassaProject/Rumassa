using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rumassa.Application.UseCases.CatalogCases.Commands;
using Rumassa.Application.UseCases.CatalogCases.Queries;
using Rumassa.Domain.Entities.DTOs;
using Rumassa.Domain.Entities;
using Rumassa.Application.UseCases.DeliveryCases.Commands;
using Rumassa.Application.UseCases.DeliveryCases.Queries;

namespace Rumassa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryController : ControllerBase
    {

        private readonly IMediator _mediator;
        public DeliveryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ResponseModel> Create(CreateDeliveryCommand request)
        {
            var result = await _mediator.Send(request);

            return result;
        }

        [HttpGet]
        public async Task<IEnumerable<Delivery>> GetAll()
        {
            var result = await _mediator.Send(new GetAllDeliveriesQuery());

            return result;
        }

        [HttpGet("{id}")]
        public async Task<Delivery> GetById(Guid id)
        {
            var result = await _mediator.Send(new GetDeliveryByIdQuery()
            {
                Id = id
            });

            return result;
        }

        [HttpPut("{id}")]
        public async Task<ResponseModel> Update(UpdateDeliveryCommand request)
        {
            var result = await _mediator.Send(request);

            return result;
        }

        [HttpDelete("{id}")]
        public async Task<ResponseModel> Delete(DeleteDeliveryCommand request)
        {
            var result = await _mediator.Send(request);

            return result;
        }

    }
}

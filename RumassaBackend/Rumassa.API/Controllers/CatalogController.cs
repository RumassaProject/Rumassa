using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rumassa.Application.UseCases.CatalogCases.Commands;
using Rumassa.Application.UseCases.CatalogCases.Queries;
using Rumassa.Domain.Entities;
using Rumassa.Domain.Entities.DTOs;

namespace Rumassa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CatalogController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ResponseModel> Create(CreateCatalogCommand request)
        {
            var result = await _mediator.Send(request);

            return result;
        }

        [HttpGet]
        public async Task<IEnumerable<Catalog>> GetAll()
        {
            var result = await _mediator.Send(new GetAllCatalogsQuery());

            return result;
        }

        [HttpGet("{id}")]
        public async Task<Catalog> GetById()
        {
            var result = await _mediator.Send(new GetCatalogByIdQuery());

            return result;
        }

        [HttpPut("{id}")]
        public async Task<ResponseModel> Update(UpdateCatalogCommand request)
        {
            var result = await _mediator.Send(request);
        
            return result;
        }

        [HttpDelete("{id}")]
        public async Task<ResponseModel> Delete(DeleteCatalogCommand request)
        {
            var result = await _mediator.Send(request);

            return result;
        }
    }
}

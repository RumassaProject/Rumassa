using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rumassa.Application.UseCases.CatalogCases.Commands;
using Rumassa.Application.UseCases.CatalogCases.Queries;
using Rumassa.Domain.Entities.DTOs;
using Rumassa.Domain.Entities;
using Rumassa.Application.UseCases.NewsCases.Commands;
using Rumassa.Application.UseCases.NewsCases.Queries;

namespace Rumassa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {

        private readonly IMediator _mediator;
        public NewsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ResponseModel> Create(CreateNewsCommand request)
        {
            var result = await _mediator.Send(request);

            return result;
        }

        [HttpGet]
        public async Task<IEnumerable<News>> GetAll()
        {
            var result = await _mediator.Send(new GetAllNewsQuery());

            return result;
        }

        [HttpGet("{id}")]
        public async Task<News> GetById()
        {
            var result = await _mediator.Send(new GetNewsByIdQuery());

            return result;
        }

        [HttpPut("{id}")]
        public async Task<ResponseModel> Update(UpdateNewsCommand request)
        {
            var result = await _mediator.Send(request);

            return result;
        }

        [HttpDelete("{id}")]
        public async Task<ResponseModel> Delete(DeleteNewsCommand request)
        {
            var result = await _mediator.Send(request);

            return result;
        }

    }
}

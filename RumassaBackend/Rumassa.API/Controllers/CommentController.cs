using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rumassa.Application.UseCases.CatalogCases.Commands;
using Rumassa.Application.UseCases.CatalogCases.Queries;
using Rumassa.Domain.Entities.DTOs;
using Rumassa.Domain.Entities;
using Rumassa.Application.UseCases.CommentCases.Commands;
using Rumassa.Application.UseCases.CommentCases.Queries;

namespace Rumassa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {

        private readonly IMediator _mediator;
        public CommentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ResponseModel> Create(CreateCommentCommand request)
        {
            var result = await _mediator.Send(request);

            return result;
        }

        [HttpGet]
        public async Task<IEnumerable<Comment>> GetAll(GetAllCommentsQuery request)
        {
            var result = await _mediator.Send(request);

            return result;
        }

        [HttpGet("{id}")]
        public async Task<Comment> GetById(GetCommentByIdQuery request)
        {
            var result = await _mediator.Send(request);

            return result;
        }

        [HttpPut("{id}")]
        public async Task<ResponseModel> Update(UpdateCommentCommand request)
        {
            var result = await _mediator.Send(request);

            return result;
        }

        [HttpDelete("{id}")]
        public async Task<ResponseModel> Delete(DeleteCommentCommand request)
        {
            var result = await _mediator.Send(request);

            return result;
        }

    }
}

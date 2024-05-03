using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rumassa.Application.UseCases.CatalogCases.Commands;
using Rumassa.Application.UseCases.CatalogCases.Queries;
using Rumassa.Domain.Entities.DTOs;
using Rumassa.Domain.Entities;
using Rumassa.Application.UseCases.CategoryCases.Commands;
using Rumassa.Application.UseCases.CategoryCases.Queries;

namespace Rumassa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly IMediator _mediator;
        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ResponseModel> Create(CreateCategoryCommand request)
        {
            var result = await _mediator.Send(request);

            return result;
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> GetAll(GetAllCategoriesQuery request)
        {
            var result = await _mediator.Send(request);

            return result;
        }

        [HttpGet("{id}")]
        public async Task<Category> GetById(GetCategoryByIdQuery request)
        {
            var result = await _mediator.Send(request);

            return result;
        }

        [HttpPut("{id}")]
        public async Task<ResponseModel> Update(UpdateCategoryCommand request)
        {
            var result = await _mediator.Send(request);

            return result;
        }

        [HttpDelete("{id}")]
        public async Task<ResponseModel> Delete(DeleteCategoryCommand request)
        {
            var result = await _mediator.Send(request);

            return result;
        }

    }
}

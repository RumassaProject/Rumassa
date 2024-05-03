using MediatR;
using Microsoft.AspNetCore.Http;
using Rumassa.Domain.Entities.DTOs;

namespace Rumassa.Application.UseCases.ProductCases.Commands
{
    public class CreateProductCommand : IRequest<ResponseModel>
    {
        public string Name { get; set; }
        public List<IFormFile> Photos { get; set; }
        public Guid? OrderId { get; set; }
        public Guid? NewsId { get; set; }
    }
}

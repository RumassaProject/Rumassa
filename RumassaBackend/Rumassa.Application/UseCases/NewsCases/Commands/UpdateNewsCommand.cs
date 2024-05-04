using MediatR;
using Microsoft.AspNetCore.Http;
using Rumassa.Domain.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumassa.Application.UseCases.NewsCases.Commands
{
    public class UpdateNewsCommand : IRequest<ResponseModel>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public IFormFile CardPhoto { get; set; }
        public DateTimeOffset Date { get; set; } = DateTimeOffset.UtcNow;
        public string Description { get; set; }
        public Guid? UserId { get; set; }
    }
}

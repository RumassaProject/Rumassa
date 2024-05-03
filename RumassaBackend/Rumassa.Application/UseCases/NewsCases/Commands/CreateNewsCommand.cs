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
    public class CreateNewsCommand : IRequest<ResponseModel>
    {
        public string Title { get; set; }
        public IFormFile CardPhoto { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Description { get; set; }
        public Guid? UserId { get; set; }
    }
}

using MediatR;
using Rumassa.Domain.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumassa.Application.UseCases.CatalogCases.Commands
{
    public class UpdateCatalogCommand:IRequest<ResponseModel>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}

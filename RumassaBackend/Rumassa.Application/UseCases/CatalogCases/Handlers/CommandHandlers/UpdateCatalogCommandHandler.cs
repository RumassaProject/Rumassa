using MediatR;
using Microsoft.EntityFrameworkCore;
using Rumassa.Application.Abstractions;
using Rumassa.Application.UseCases.CatalogCases.Commands;
using Rumassa.Application.UseCases.OrderCases.Commands;
using Rumassa.Domain.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumassa.Application.UseCases.CatalogCases.Handlers.CommandHandlers
{
    public class UpdateCatalogCommandHandler:IRequestHandler<UpdateCatalogCommand, ResponseModel>
    {

        private readonly IRumassaDbContext _context;

        public UpdateCatalogCommandHandler(IRumassaDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(UpdateCatalogCommand request, CancellationToken cancellationToken)
        {
            var catalog = await _context.Catalogs.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (catalog != null)
            {
                catalog.Name = request.Name;

                _context.Catalogs.Update(catalog);

                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    StatusCode = 201,
                    Message = $"Catalog Updated",
                    IsSuccess = true
                };
            }

            return new ResponseModel
            {
                Message = "Catalog is not found",
                StatusCode = 400
            };
        }

    }
}

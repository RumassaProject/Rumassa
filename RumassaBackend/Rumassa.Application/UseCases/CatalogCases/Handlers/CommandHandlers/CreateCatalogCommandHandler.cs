

using MediatR;
using Rumassa.Application.Abstractions;
using Rumassa.Application.UseCases.CatalogCases.Commands;
using Rumassa.Application.UseCases.OrderCases.Commands;
using Rumassa.Domain.Entities;
using Rumassa.Domain.Entities.DTOs;

namespace Rumassa.Application.UseCases.CatalogCases.Handlers.CommandHandlers
{
    public class CreateCatalogCommandHandler : IRequestHandler<CreateCatalogCommand, ResponseModel>
    {
        private readonly IRumassaDbContext _context;

        public CreateCatalogCommandHandler(IRumassaDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(CreateCatalogCommand request, CancellationToken cancellationToken)
        {
            if (request != null)
            {
                var catalog = new Catalog
                {
                    Name = request.Name,
                };

                await _context.Catalogs.AddAsync(catalog, cancellationToken);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    StatusCode = 201,
                    Message = $"Catalog Created",
                    IsSuccess = true
                };
            }

            return new ResponseModel
            {
                Message = "Catalog is might be null",
                StatusCode = 400
            };
        }
    }
}

using MediatR;
using Microsoft.EntityFrameworkCore;
using Rumassa.Application.Abstractions;
using Rumassa.Application.UseCases.CatalogCases.Queries;
using Rumassa.Application.UseCases.OrderCases.Queries;
using Rumassa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumassa.Application.UseCases.CatalogCases.Handlers.QueryHandlers
{
    public class GetCatalogByIdQueryHandler : IRequestHandler<GetCatalogByIdQuery, Catalog>
    {
        private readonly IRumassaDbContext _context;

        public GetCatalogByIdQueryHandler(IRumassaDbContext context)
        {
            _context = context;
        }

        public async Task<Catalog> Handle(GetCatalogByIdQuery request, CancellationToken cancellationToken)
        {
            var catalog = await _context.Catalogs.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (catalog != null)
            {
                return catalog;
            }

            throw new Exception("Catalog Not Found!");
        }
    }
}

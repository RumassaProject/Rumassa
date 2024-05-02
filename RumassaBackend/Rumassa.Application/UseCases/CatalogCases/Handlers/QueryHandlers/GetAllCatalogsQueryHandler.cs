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
    public class GetAllCatalogsQueryHandler : IRequestHandler<GetAllCatalogsQuery, List<Catalog>>
    {
        private readonly IRumassaDbContext _context;

        public GetAllCatalogsQueryHandler(IRumassaDbContext context)
        {
            _context = context;
        }

        public async Task<List<Catalog>> Handle(GetAllCatalogsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Catalogs.ToListAsync(cancellationToken);
        }
    }
}

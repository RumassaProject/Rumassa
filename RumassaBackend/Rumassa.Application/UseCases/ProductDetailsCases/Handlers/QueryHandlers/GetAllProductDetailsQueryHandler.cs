using MediatR;
using Microsoft.EntityFrameworkCore;
using Rumassa.Application.Abstractions;
using Rumassa.Application.UseCases.OrderCases.Queries;
using Rumassa.Application.UseCases.ProductDetailsCases.Queries;
using Rumassa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumassa.Application.UseCases.ProductDetailsCases.Handlers.QueryHandlers
{
    public class GetAllProductDetailsQueryHandler : IRequestHandler<GetAllProductDetailsQuery, IEnumerable<ProductDetails>>
    {

        private readonly IRumassaDbContext _context;

        public GetAllProductDetailsQueryHandler(IRumassaDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProductDetails>> Handle(GetAllProductDetailsQuery request, CancellationToken cancellationToken)
        {
            return await _context.ProductDetails.ToListAsync(cancellationToken);
        }

    }
}

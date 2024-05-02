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
    public class GetProductDetailByIdQueryHandler : IRequestHandler<GetProductDetailByIdQuery, ProductDetails>
    {

        private readonly IRumassaDbContext _context;

        public GetProductDetailByIdQueryHandler(IRumassaDbContext context)
        {
            _context = context;
        }

        public async Task<ProductDetails> Handle(GetProductDetailByIdQuery request, CancellationToken cancellationToken)
        {
            var productdetails = await _context.ProductDetails.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (productdetails != null)
            {
                return productdetails;
            }

            throw new Exception("Product Details Not Found!");
        }

    }
}

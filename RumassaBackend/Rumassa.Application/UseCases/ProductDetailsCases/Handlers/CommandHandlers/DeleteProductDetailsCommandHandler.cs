using MediatR;
using Microsoft.EntityFrameworkCore;
using Rumassa.Application.Abstractions;
using Rumassa.Application.UseCases.OrderCases.Commands;
using Rumassa.Application.UseCases.ProductDetailsCases.Commands;
using Rumassa.Domain.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumassa.Application.UseCases.ProductDetailsCases.Handlers.CommandHandlers
{
    public class DeleteProductDetailsCommandHandler : IRequestHandler<DeleteProductDetailsCommand, ResponseModel>
    {

        private readonly IRumassaDbContext _context;

        public DeleteProductDetailsCommandHandler(IRumassaDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(DeleteProductDetailsCommand request, CancellationToken cancellationToken)
        {
            var productdetails = await _context.ProductDetails.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (productdetails != null)
            {
                _context.ProductDetails.Remove(productdetails);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    StatusCode = 201,
                    Message = $"Product Details Deleted",
                    IsSuccess = true
                };
            }

            return new ResponseModel
            {
                Message = "Product Details is not found",
                StatusCode = 400
            };
        }

    }
}

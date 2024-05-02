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
    public class UpdateProductDetailsCommandHandler : IRequestHandler<UpdateProductDetailsCommand, ResponseModel>
    {

        private readonly IRumassaDbContext _context;

        public UpdateProductDetailsCommandHandler(IRumassaDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(UpdateProductDetailsCommand request, CancellationToken cancellationToken)
        {
            var productdetails = await _context.ProductDetails.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (productdetails != null)
            {
                productdetails.Description = request.Description;
                productdetails.ProductIs = request.ProductIs;
                productdetails.Vitamins = request.Vitamins;
                productdetails.Recommendation = request.Recommendation;
                productdetails.OnePortion = request.OnePortion;
                productdetails.TotalPortion = request.TotalPortion;
                productdetails.QuantityPerPortion = request.QuantityPerPortion;
                productdetails.PercentPerDay = request.PercentPerDay;
                productdetails.ProductId = request.ProductId;

                _context.ProductDetails.Update(productdetails);

                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    StatusCode = 201,
                    Message = $"Product Details Updated",
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

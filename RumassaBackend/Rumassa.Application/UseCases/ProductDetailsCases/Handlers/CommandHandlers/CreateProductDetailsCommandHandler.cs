using Rumassa.Application.Abstractions;
using Rumassa.Application.UseCases.OrderCases.Commands;
using Rumassa.Domain.Entities.DTOs;
using Rumassa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Rumassa.Application.UseCases.ProductDetailsCases.Commands;

namespace Rumassa.Application.UseCases.ProductDetailsCases.Handlers.CommandHandlers
{
    public class CreateProductDetailsCommandHandler : IRequestHandler<CreateProductDetailsCommand, ResponseModel>
    {

        private readonly IRumassaDbContext _context;

        public CreateProductDetailsCommandHandler(IRumassaDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(CreateProductDetailsCommand request, CancellationToken cancellationToken)
        {
            if (request != null)
            {
                var productdetails = new ProductDetails()
                {
                    Description = request.Description,
                    ProductIs = request.ProductIs,
                    Vitamins = request.Vitamins,
                    Recommendation = request.Recommendation,
                    OnePortion = request.OnePortion,
                    TotalPortion = request.TotalPortion,
                    QuantityPerPortion = request.QuantityPerPortion,
                    PercentPerDay = request.PercentPerDay,
                    ProductId = request.ProductId,
                };

                await _context.ProductDetails.AddAsync(productdetails, cancellationToken);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    StatusCode = 201,
                    Message = $"Product Details Created",
                    IsSuccess = true
                };
            }

            return new ResponseModel
            {
                Message = "Product Details is might be null",
                StatusCode = 400
            };
        }

    }
}

using MediatR;
using Rumassa.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumassa.Application.UseCases.ProductDetailsCases.Queries
{
    public class GetProductDetailByIdQuery : IRequest<ProductDetails>
    {

        public Guid Id { get; set; }

    }
}

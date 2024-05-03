using MediatR;
using Rumassa.Domain.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumassa.Application.UseCases.ProductDetailsCases.Commands
{
    public class CreateProductDetailsCommand : IRequest<ResponseModel>
    {

        public List<string> Description { get; set; }
        public string ProductIs { get; set; }
        public string Vitamins { get; set; }
        public string Recommendation { get; set; }
        public string OnePortion { get; set; }
        public string TotalPortion { get; set; }
        public string QuantityPerPortion { get; set; }
        public string PercentPerDay { get; set; }
        public Guid? ProductId { get; set; }

    }
}

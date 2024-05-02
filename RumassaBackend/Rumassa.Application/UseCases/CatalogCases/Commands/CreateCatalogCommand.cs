﻿using MediatR;
using Rumassa.Domain.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumassa.Application.UseCases.CatalogCases.Commands
{
    public class CreateCatalogCommand:IRequest<ResponseModel>
    {

        public string Name { get; set; }

    }
}

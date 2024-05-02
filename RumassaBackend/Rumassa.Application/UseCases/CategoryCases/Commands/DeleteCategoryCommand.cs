﻿using MediatR;
using Rumassa.Domain.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumassa.Application.UseCases.CategoryCases.Commands
{
    public class DeleteCategoryCommand : IRequest<ResponseModel>
    {
        public Guid Id { get; set; }

    }
}

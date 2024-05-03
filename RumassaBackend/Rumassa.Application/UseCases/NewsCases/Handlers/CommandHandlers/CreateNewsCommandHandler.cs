﻿using MediatR;
using Microsoft.AspNetCore.Hosting;
using Rumassa.Application.Abstractions;
using Rumassa.Application.UseCases.NewsCases.Commands;
using Rumassa.Domain.Entities;
using Rumassa.Domain.Entities.DTOs;

namespace Rumassa.Application.UseCases.NewsCases.Handlers.CommandHandlers
{
    public class CreateNewsCommandHandler : IRequestHandler<CreateNewsCommand, ResponseModel>
    {
        private readonly IRumassaDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CreateNewsCommandHandler(IRumassaDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<ResponseModel> Handle(CreateNewsCommand request, CancellationToken cancellationToken)
        {
            if (request != null)
            {
                var file = request.CardPhoto;
                string filePath = "";
                string fileName = "";

                try
                {
                    fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    filePath = Path.Combine(_webHostEnvironment.WebRootPath, "ProductPhotos", fileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                catch (Exception ex)
                {
                    return new ResponseModel()
                    {
                        Message = ex.Message,
                        StatusCode = 500,
                        IsSuccess = false
                    };
                }

                var news = new News()
                {
                    Title = request.Title,
                    CardPhotoPath = filePath,
                    Date = request.Date,
                    Description = request.Description,
                    UserId = request.UserId,
                };

                await _context.News.AddAsync(news, cancellationToken);
                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel()
                {
                    StatusCode = 201,
                    Message = $"News Created",
                    IsSuccess = true
                };
            }

            return new ResponseModel
            {
                Message = "News is might be null",
                StatusCode = 400
            };
        }
    }
}

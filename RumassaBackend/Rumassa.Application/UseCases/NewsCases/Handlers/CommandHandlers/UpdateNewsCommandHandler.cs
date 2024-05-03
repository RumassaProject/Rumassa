using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Rumassa.Application.Abstractions;
using Rumassa.Application.UseCases.CatalogCases.Commands;
using Rumassa.Application.UseCases.NewsCases.Commands;
using Rumassa.Domain.Entities.Auth;
using Rumassa.Domain.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Rumassa.Application.UseCases.NewsCases.Handlers.CommandHandlers
{
    public class UpdateNewsCommandHandler : IRequestHandler<UpdateNewsCommand, ResponseModel>
    {
        private readonly IRumassaDbContext _context;
        private readonly IHostEnvironment _hostEnvironment;

        public UpdateNewsCommandHandler(IRumassaDbContext context, IHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        public async Task<ResponseModel> Handle(UpdateNewsCommand request, CancellationToken cancellationToken)
        {
            var news = await _context.News.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (news != null)
            {
                if (request.CardPhoto != null)
                {
                    var photoPath = news.CardPhotoPath;
                    if (File.Exists(photoPath))
                    {
                        File.Delete(photoPath);
                    }

                    var file = request.CardPhoto;
                    string filePath = "";
                    string fileName = "";

                    try
                    {
                        fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                        filePath = Path.Combine(_hostEnvironment.ContentRootPath, "ProductPhotos", fileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }

                        news.CardPhotoPath = filePath;
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
                }

                news.Title = request.Title;
                news.Date = request.Date;
                news.Description = request.Description;
                news.UserId = request.UserId;

                _context.News.Update(news);

                await _context.SaveChangesAsync(cancellationToken);

                return new ResponseModel
                {
                    StatusCode = 201,
                    Message = $"News Updated",
                    IsSuccess = true
                };
            }

            return new ResponseModel
            {
                Message = "News is not found",
                StatusCode = 400
            };
        }
    }
}

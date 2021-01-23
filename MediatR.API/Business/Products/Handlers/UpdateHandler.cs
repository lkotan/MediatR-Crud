using MediatR.API.Business.Products.Commands;
using MediatR.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.API.Business.Products.Handlers
{
    public class UpdateHandler : IRequestHandler<UpdateCommand, Product>
    {
        private readonly MediatRContext _context;

        public UpdateHandler(MediatRContext context) => _context = context;

        public async Task<Product> Handle(UpdateCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Products.FirstOrDefaultAsync(x => x.Id == request.Id);
            entity.Name = request.Name;
            entity.Price = request.Price;

            await _context.SaveChangesAsync();

            return entity;
        }
    }
}

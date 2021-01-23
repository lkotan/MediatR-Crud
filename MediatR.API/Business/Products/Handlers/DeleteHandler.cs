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
    public class DeleteHandler : IRequestHandler<DeleteCommand, string>
    {
        private readonly MediatRContext _context;

        public DeleteHandler(MediatRContext context) => _context = context;

        public async Task<string> Handle(DeleteCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Products.FirstOrDefaultAsync(x => x.Id == request.Id);
            _context.Remove(entity);

            await _context.SaveChangesAsync();

            return "İşlem Başarılı";
        }
    }
}

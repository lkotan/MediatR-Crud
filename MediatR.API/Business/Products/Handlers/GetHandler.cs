using MediatR.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.API.Business.Products
{
    public class GetHandler : IRequestHandler<GetQuery, Product>
    {
        private readonly MediatRContext _context;

        public GetHandler(MediatRContext context) => _context = context;

        public async Task<Product> Handle(GetQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.FirstOrDefaultAsync(x => x.Id == request.Id);
        }
    }
}

using MediatR.API.Business.Products.Queries;
using MediatR.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.API.Business.Products.Handlers
{
    public class GetAllHandler : IRequestHandler<GetAllQuery, List<Product>>
    {
        private readonly MediatRContext _context;

        public GetAllHandler(MediatRContext context) => _context = context;

        public async Task<List<Product>> Handle(GetAllQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.OrderByDescending(x=>x.Id).ToListAsync();
        }
    }
}

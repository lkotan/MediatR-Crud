using MediatR.API.Business.Products.Commands;
using MediatR.API.Models;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.API.Business.Products.Handlers
{
    public class AddHandler : IRequestHandler<AddCommand, Product>
    {
        private readonly MediatRContext _context;

        public AddHandler(MediatRContext context) => _context = context;

        public async Task<Product> Handle(AddCommand request, CancellationToken cancellationToken)
        {
            Product prd = new Product
            {
                Name=request.Name,
                Price=request.Price
            };
            await _context.Products.AddAsync(prd);
            await _context.SaveChangesAsync();
            return prd;
        }
    }
}

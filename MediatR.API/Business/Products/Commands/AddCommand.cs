using MediatR.API.Models;

namespace MediatR.API.Business.Products.Commands
{
    public class AddCommand:IRequest<Product>
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}

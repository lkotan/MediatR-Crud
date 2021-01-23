using MediatR.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatR.API.Business.Products
{
    public class GetQuery:IRequest<Product>
    {
        public int Id { get; set; }
    }
}

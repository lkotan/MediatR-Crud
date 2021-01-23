using MediatR.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatR.API.Business.Products.Commands
{
    public class DeleteCommand:IRequest<string>
    {
        public int Id { get; set; }
    }
}

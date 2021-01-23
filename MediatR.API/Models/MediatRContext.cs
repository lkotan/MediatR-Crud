using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatR.API.Models
{
    public class MediatRContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        public MediatRContext(DbContextOptions<MediatRContext> options):base(options)
        {

        }
    }
}

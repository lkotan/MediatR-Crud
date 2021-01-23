using MediatR.API.Business.Products;
using MediatR.API.Business.Products.Commands;
using MediatR.API.Business.Products.Queries;
using MediatR.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MediatR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController:ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator) => _mediator = mediator;


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetAllQuery()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute]GetQuery request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody]AddCommand request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody]UpdateCommand request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute]DeleteCommand request)
        {
            return Ok(await _mediator.Send(request));
        }
    }
}

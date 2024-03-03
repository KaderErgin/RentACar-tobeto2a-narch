using Application.Features.Customers.Commands.Create;
using Application.Features.Customers.Queries.GetList;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;

namespace WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CustomersController : BaseController
{

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateCustomerCommand command)
    {
        CreatedCustomerResponse response = await Mediator.Send(command);
        return Created("", response);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
    {
        GetListCustomerQuery query = new() { PageRequest = pageRequest };
        GetListResponse<GetListCustomerItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }
}

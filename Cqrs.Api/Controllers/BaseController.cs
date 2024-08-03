using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Cqrs.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class BaseController : ControllerBase
{
    private readonly ISender _sender;
    public BaseController(ISender sender)
    {
        _sender = sender;
    }
}

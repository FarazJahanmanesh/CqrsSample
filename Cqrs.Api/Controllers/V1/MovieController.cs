using Azure;
using DataBase.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Cqrs.Api.Controllers.V1;
public class MovieController : BaseController
{
    private readonly IMediator _mediator;
    public MovieController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<DataBase.Commands.Response> CreateMovie() =>
        await _mediator.Send(new CreateMovieCommand { MyProperty = 1 });
}

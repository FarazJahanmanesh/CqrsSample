using MediatR;
namespace DataBase.Commands;
public class CreateMovieCommand : IRequest<Response>
{
    public int MyProperty { get; set; }
}
public class Response
{
    public int Id { get; set; }
}

public class CreateMovieCommandHandler : IRequestHandler<CreateMovieCommand, Response>
{
    private static List<string> _responses = new List<string>();
    public async Task<Response> Handle(CreateMovieCommand request, CancellationToken cancellationToken)
    {
        _responses.Add(request.MyProperty.ToString());
        Random random = new Random();
        return new Response
        {
            Id = random.Next(1, 21)
        };
    }
}
namespace CqrsSample.Api.Controller;

public class ProductController : BaseController
{
    private readonly ReadUnitOfWork _readUnitOfWork;
    private readonly WriteUnitOfWork _writeUnitOfWork;
    public ProductController(ReadUnitOfWork readUnitOfWork, WriteUnitOfWork writeUnitOfWork)
    {
        _readUnitOfWork = readUnitOfWork;
        _writeUnitOfWork = writeUnitOfWork;
    }
}

using CqrsSample.Api.Contracts;
using CqrsSample.Api.Contracts.Repository;
using CqrsSample.Api.Repository;
namespace CqrsSample.Api;

public class ReadUnitOfWork: IReadUnitOfWork
{
    private ReadProductRepository _readProductRepository;
    public IReadProductRepository ReadProductRepository
    {
        get
        {
            return _readProductRepository ??= new ReadProductRepository();
        }
    }
}
